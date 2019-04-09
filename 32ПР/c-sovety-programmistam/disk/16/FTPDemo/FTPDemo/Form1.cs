using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;



namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FTPUploadFile(string filename)
        {

            FileInfo fileInf = new FileInfo(filename);

            string uri = "ftp://" + "ftp.narod.ru" + "/" + fileInf.Name;

            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided

            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + "ftp.narod.ru" + "/" + fileInf.Name));

            // Provide the WebPermission Credintials

            reqFTP.Credentials = new NetworkCredential("hotel-vega", "1/2ivanov");

            // By default KeepAlive is true, where the control connection is not closed

            // after a command is executed.

            reqFTP.KeepAlive = false;

            // Specify the command to be executed.

            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.

            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file

            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb

            int buffLength = 2048;

            byte[] buff = new byte[buffLength];

            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read the file to be uploaded

            FileStream fs = fileInf.OpenRead();

            try
            {

                // Stream to which the file to be upload is written

                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time

                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends

                while (contentLen != 0)
                {

                    // Write Content from the file stream to the FTP Upload Stream

                    strm.Write(buff, 0, contentLen);

                    contentLen = fs.Read(buff, 0, buffLength);

                }

                // Close the file stream and the Request Stream

                strm.Close();

                fs.Close();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Upload Error");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FTPUploadFile(@"c:\ruspro.gif");
        }

        public string[] GetFileList()
        {
            string[] downloadFiles;
            StringBuilder result = new StringBuilder();
            FtpWebRequest reqFTP;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + "ftp.narod.ru" + "/"));
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential("hotel-vega", "1/2ivanov");
                reqFTP.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = reqFTP.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());

                string line = reader.ReadLine();
                while (line != null)
                {
                    result.Append(line);
                    result.Append("\n");
                    line = reader.ReadLine();
                }
                // to remove the trailing '\n'
                result.Remove(result.ToString().LastIndexOf('\n'), 1);
                reader.Close();
                response.Close();
                return result.ToString().Split('\n');
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                downloadFiles = null;
                return downloadFiles;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] allFiles = GetFileList();
            foreach (string file in allFiles)
            {
                listBox1.Items.Add(file);
            }
        }

        private void FTPDownloadFile(string filePath, string fileName)
        {
            FtpWebRequest reqFTP;
            try
            {
                //filePath Ц полный путь к папке, где должен быть создан файл 
                //fileName  - им€ создаваемого файла на локальном компьютере

                FileStream outputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new
                    Uri("ftp://" + "ftp.narod.ru" + "/" + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;

                // »спользуйте реальные данные дл€ логина и парол€
                reqFTP.Credentials = new NetworkCredential("csharp", "narod");
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();

                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FTPDownloadFile("c:/temp", "ruspro.gif");
        }

    }
}