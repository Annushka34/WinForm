// При написании программы использовался исходный код
// из примера 
// Using managed code to detect what .NET Framework versions and service packs are installed
// который можно найти по адресу 
// http://www.codeproject.com/useritems/frameworkversiondetection.asp


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Globalization;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        const string Netfx11RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v1.1.4322";
        const string Netfx20RegKeyName = "Software\\Microsoft\\NET Framework Setup\\NDP\\v2.0.50727";
        const string Netfx11PlusRegValueName = "Install";
        const string Netfx11PlusSPxRegValueName = "SP";
        const string Netfx20PlusBuildRegValueName = "Increment";
        
        /// <summary>
        /// Версии .NET Framework
        /// </summary>
        public enum FrameworkVersion
        {
            // .NET Framework 1.0
            Fx10,
            // .NET Framework 1.1
            Fx11,
            // .NET Framework 2.0
            Fx20,
            // .NET Framework 3.0
            Fx30,
            // .NET Framework 3.5 (Orcas)
            Fx35,
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            bool fx11Installed = IsInstalled(FrameworkVersion.Fx11);
            bool fx20Installed = IsInstalled(FrameworkVersion.Fx20);

            listBox1.Items.Add(String.Format(".NET Framework 1.1 installed? {0}", fx11Installed));

            if (fx11Installed)
            {
                listBox1.Items.Add(String.Format(".NET Framework 1.1 Exact Version: {0}",
                  GetExactVersion(FrameworkVersion.Fx11)));
                listBox1.Items.Add(String.Format(".NET Framework 1.1 Service Pack: {0}",
                  GetServicePackLevel(FrameworkVersion.Fx11)));
            }


            listBox1.Items.Add(String.Format(".NET Framework 2.0 installed? {0}", fx20Installed));
            if (fx20Installed)
            {
                listBox1.Items.Add(String.Format(".NET Framework 2.0 Exact Version: {0}",
                  GetExactVersion(FrameworkVersion.Fx20)));
                listBox1.Items.Add(String.Format(".NET Framework 2.0 Service Pack: {0}",
                  GetServicePackLevel(FrameworkVersion.Fx20)));
            }
        }

        /// <summary>
        /// Determines if the specified .NET Framework version is installed
        /// on the local computer.
        /// </summary>
        /// <param name="frameworkVersion">One of the
        /// <see cref="FrameworkVersion"/> values.</param>
        /// <returns><see langword="true"/> if the specified .NET Framework
        /// version is installed; otherwise <see langword="false"/>.</returns>
        public static bool IsInstalled(FrameworkVersion frameworkVersion)
        {
            bool ret = false;

            switch (frameworkVersion)
            {
                case FrameworkVersion.Fx11:
                    ret = IsNetfx11Installed();
                    break;

                case FrameworkVersion.Fx20:
                    ret = IsNetfx20Installed();
                    break;

                default:
                    break;
            }

            return ret;
        }

        private static bool IsNetfx11Installed()
        {
            bool found = false;
            int regValue = 0;

            if (GetRegistryValue(RegistryHive.LocalMachine, 
                Netfx11RegKeyName, Netfx11PlusRegValueName, 
                RegistryValueKind.DWord, out regValue))
            {
                if (regValue == 1)
                {
                    found = true;
                }
            }

            return found;
        }

        private static bool IsNetfx20Installed()
        {
            bool found = false;
            int regValue = 0;

            if (GetRegistryValue(RegistryHive.LocalMachine, 
                Netfx20RegKeyName, Netfx11PlusRegValueName, 
                RegistryValueKind.DWord, out regValue))
            {
                if (regValue == 1)
                {
                    found = true;
                }
            }

            return found;
        }


        private static bool GetRegistryValue<T>(RegistryHive hive, string key, 
            string value, RegistryValueKind kind, out T data)
        {
            bool success = false;
            data = default(T);

            using (RegistryKey baseKey = RegistryKey.OpenRemoteBaseKey(hive, String.Empty))
            {
                if (baseKey != null)
                {
                    using (RegistryKey registryKey = baseKey.OpenSubKey(key, 
                        RegistryKeyPermissionCheck.ReadSubTree))
                    {
                        if (registryKey != null)
                        {
                            // If the key was opened, try to retrieve the value.
                            RegistryValueKind kindFound = registryKey.GetValueKind(value);
                            if (kindFound == kind)
                            {
                                object regValue = registryKey.GetValue(value, null);
                                if (regValue != null)
                                {
                                    data = (T)Convert.ChangeType(regValue, typeof(T), 
                                        CultureInfo.InvariantCulture);
                                    success = true;
                                }
                            }
                        }
                    }
                }
            }
            return success;
        }

        /// <summary>
        /// Retrieves the exact version number for the specified .NET Framework
        /// version.
        /// </summary>
        /// <param name="frameworkVersion">One of the
        /// <see cref="FrameworkVersion"/> values.</param>
        /// <returns>A <see cref="Version">version</see> representing
        /// the exact version number for the specified .NET Framework version.
        /// If the specified .NET Frameowrk version is not found, a 
        /// <see cref="Version"/> is returned that represents a 0.0.0.0 version
        /// number.
        /// </returns>
        public static Version GetExactVersion(FrameworkVersion frameworkVersion)
        {
            Version fxVersion = new Version();

            switch (frameworkVersion)
            {
                case FrameworkVersion.Fx11:
                    fxVersion = GetNetfx11ExactVersion();
                    break;

                case FrameworkVersion.Fx20:
                    fxVersion = GetNetfx20ExactVersion();
                    break;

                default:
                    break;
            }

            return fxVersion;
        }

        
        private static Version GetNetfx11ExactVersion()
        {
            int regValue = 0;

            // We can only get -1 if the .NET Framework is not
            // installed or there was some kind of error retrieving
            // the data from the registry
            Version fxVersion = new Version();

            if (GetRegistryValue(RegistryHive.LocalMachine, 
                Netfx11RegKeyName, Netfx11PlusRegValueName, 
                RegistryValueKind.DWord, out regValue))
            {
                if (regValue == 1)
                {
                    // In the strict sense, we are cheating here, but the registry key name itself
                    // contains the version number.
                    string[] tokens = Netfx11RegKeyName.Split(new string[] { "NDP\\v" }, 
                        StringSplitOptions.None);
                    if (tokens.Length == 2)
                    {
                        fxVersion = new Version(tokens[1]);
                    }
                }
            }

            return fxVersion;
        }

        private static Version GetNetfx20ExactVersion()
        {
            string regValue = String.Empty;

            // We can only get -1 if the .NET Framework is not
            // installed or there was some kind of error retrieving
            // the data from the registry
            Version fxVersion = new Version();

            if (GetRegistryValue(RegistryHive.LocalMachine, 
                Netfx20RegKeyName, Netfx20PlusBuildRegValueName, 
                RegistryValueKind.String, out regValue))
            {
                if (!String.IsNullOrEmpty(regValue))
                {
                    // In the strict sense, we are cheating here, but the registry key name itself
                    // contains the version number.
                    string[] versionTokens = Netfx20RegKeyName.Split(new string[] { "NDP\\v" }, 
                        StringSplitOptions.None);
                    if (versionTokens.Length == 2)
                    {
                        string[] tokens = versionTokens[1].Split('.');
                        if (tokens.Length == 3)
                        {
                            fxVersion = new Version(Convert.ToInt32(tokens[0], 
                                NumberFormatInfo.InvariantInfo), Convert.ToInt32(tokens[1], 
                                NumberFormatInfo.InvariantInfo), Convert.ToInt32(tokens[2], 
                                NumberFormatInfo.InvariantInfo), Convert.ToInt32(regValue, 
                                NumberFormatInfo.InvariantInfo));
                        }
                    }
                }
            }

            return fxVersion;
        }

        /// <summary>
        /// Retrieves the service pack level for the specified .NET Framework
        /// version.
        /// </summary>
        /// <param name="frameworkVersion">One of the
        /// <see cref="FrameworkVersion"/> values.</param>
        /// <returns>An <see cref="Int32">integer</see> value representing
        /// the service pack level for the specified .NET Framework version. If
        /// the specified .NET Frameowrk version is not found, -1 is returned.
        /// </returns>
        public static int GetServicePackLevel(FrameworkVersion frameworkVersion)
        {
            int servicePackLevel = -1;

            switch (frameworkVersion)
            {
                case FrameworkVersion.Fx11:
                    servicePackLevel = GetNetfx11SPLevel();
                    break;

                case FrameworkVersion.Fx20:
                    servicePackLevel = GetNetfx20SPLevel();
                    break;

                default:
                    break;
            }

            return servicePackLevel;
        }

        private static int GetNetfx11SPLevel()
        {
            int regValue = 0;

            // We can only get -1 if the .NET Framework is not
            // installed or there was some kind of error retrieving
            // the data from the registry
            int servicePackLevel = -1;

            if (GetRegistryValue(RegistryHive.LocalMachine, 
                Netfx11RegKeyName, Netfx11PlusSPxRegValueName, 
                RegistryValueKind.DWord, out regValue))
            {
                servicePackLevel = regValue;
            }

            return servicePackLevel;
        }

        private static int GetNetfx20SPLevel()
        {
            int regValue = 0;

            // We can only get -1 if the .NET Framework is not
            // installed or there was some kind of error retrieving
            // the data from the registry
            int servicePackLevel = -1;

            if (GetRegistryValue(RegistryHive.LocalMachine, 
                Netfx20RegKeyName, Netfx11PlusSPxRegValueName, 
                RegistryValueKind.DWord, out regValue))
            {
                servicePackLevel = regValue;
            }

            return servicePackLevel;
        }
    }
}