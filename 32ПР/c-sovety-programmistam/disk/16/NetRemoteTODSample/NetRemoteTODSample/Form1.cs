using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("netapi32.dll", EntryPoint = "NetRemoteTOD", SetLastError = true,
        CharSet = CharSet.Unicode, ExactSpelling = true,
        CallingConvention = CallingConvention.StdCall)]
        private static extern int NetRemoteTOD(string UncServerName, ref IntPtr BufferPtr);

        [DllImport("netapi32.dll", EntryPoint = "NetApiBufferFree")]
        public static extern NERR NetApiBufferFree(IntPtr Buffer);

        [StructLayout(LayoutKind.Sequential)]
        private struct TIME_OF_DAY_INFO
        {
            public int tod_elapsedt;
            public int tod_msecs;
            public int tod_hours;
            public int tod_mins;
            public int tod_secs;
            public int tod_hunds;
            public int tod_timezone;
            public int tod_tinterval;
            public int tod_day;
            public int tod_month;
            public int tod_year;
            public int tod_weekday;
        }



        // список ошибок, возвращаемых NetServerEnum
        public enum NERR
        {
            NERR_Success = 0, // успех
            ERROR_ACCESS_DENIED = 5,
            ERROR_NOT_ENOUGH_MEMORY = 8,
            ERROR_BAD_NETPATH = 53,
            ERROR_NETWORK_BUSY = 54,
            ERROR_INVALID_PARAMETER = 87,
            ERROR_INVALID_LEVEL = 124,
            ERROR_MORE_DATA = 234,
            ERROR_EXTENDED_ERROR = 1208,
            ERROR_NO_NETWORK = 1222,
            ERROR_INVALID_HANDLE_STATE = 1609,
            ERROR_NO_BROWSER_SERVERS_FOUND = 6118,
        }


        public int[] GetRemoteTime(string ServerName)
        {
            TIME_OF_DAY_INFO result = new TIME_OF_DAY_INFO();
            IntPtr pintBuffer = IntPtr.Zero;
            int[] TOD_INFO = new int[12];

            // Получим дату и время с сервера
            int pintError = NetRemoteTOD(ServerName, ref pintBuffer);
            if (pintError > 0) { throw new System.ComponentModel.Win32Exception(pintError); }

            // Получим данные структуры
            result = (TIME_OF_DAY_INFO)Marshal.PtrToStructure(pintBuffer, typeof(TIME_OF_DAY_INFO));

            TOD_INFO[0] = result.tod_elapsedt;
            TOD_INFO[1] = result.tod_msecs;
            TOD_INFO[2] = result.tod_hours;
            TOD_INFO[3] = result.tod_mins;
            TOD_INFO[4] = result.tod_secs;
            TOD_INFO[5] = result.tod_hunds;
            TOD_INFO[6] = result.tod_timezone;
            TOD_INFO[7] = result.tod_tinterval;
            TOD_INFO[8] = result.tod_day;
            TOD_INFO[9] = result.tod_month;
            TOD_INFO[10] = result.tod_year;
            TOD_INFO[11] = result.tod_weekday;

            // Освобождаем буфер
            NetApiBufferFree(pintBuffer);

            return TOD_INFO;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ServerName = @"\\skynet";

            int[] TOD_Info = new int[12];

            try
            {
                TOD_Info = GetRemoteTime(ServerName);

            }
            catch (Exception err)
            {
                // Выводим сообщение об ошибке
                MessageBox.Show("NetRemoteTOD from " + ServerName + " failed!\nError: "
                    + err.Message);
                return;
            }

            TOD_Info[2] -= TOD_Info[6] / 60;

            MessageBox.Show(String.Format("Дата/Время сервера {0} : {1}.{2}.{3}  {4}:{5}:{6}",
                    ServerName, TOD_Info[8], TOD_Info[9],
                    TOD_Info[10], TOD_Info[2], TOD_Info[3],
                    TOD_Info[4]));
        }



    }
}