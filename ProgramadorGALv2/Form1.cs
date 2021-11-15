using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ProgramadorGALv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBoxFile.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            btnDesc.Enabled = false;
            cBoxCOM.Items.AddRange(ports);
        }

        private void cBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCone_Click(object sender, EventArgs e)
        {
            
            try
            {
                btnCone.Enabled = false;
                btnDesc.Enabled = true;
                progressBar1.Value = 50;
                serialPort1.PortName = cBoxCOM.Text;
                serialPort1.BaudRate = 38400;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DtrEnable = true;
                //serialPort1.ReadTimeout = 2000;
                serialPort1.Open();
               
                string datarec = serialPort1.ReadTo(">");
                
                txtTerm.Text = datarec;

                serialPort1.Close();
                progressBar1.Value = 100;






            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnReadInfo_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnReadInfo_Click_1(object sender, EventArgs e)
        {
            try
            {
                string GAL = cBoxGAL.Text;
                string COM = cBoxCOM.Text;
                if (GAL == "")
                {
                    txtTerm.Text = "Seleccionar GAL";
                }
                else if (COM == "")
                {
                    txtTerm.Text = "Seleccionar Puerto COM";
                }
                else
                {
                    List<object> argument = new List<object>();
                    argument.Add(COM);
                    argument.Add(GAL);

                    workRead.RunWorkerAsync(argument);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void btnReadDev_Click(object sender, EventArgs e)
        {
            try
            {
                //btnReadDev.Enabled = false;
                string GAL = cBoxGAL.Text;
                string COM = cBoxCOM.Text;
                if(GAL == "")
                {
                    txtTerm.Text = "Seleccionar GAL";
                }
                else if(COM == "")
                {
                    txtTerm.Text = "Seleccionar Puerto COM";
                }
                else
                {
                    if(workReadDevice.IsBusy != true)
                    {
                        List<object> argument = new List<object>();
                        argument.Add(COM);
                        argument.Add(GAL);

                        workReadDevice.RunWorkerAsync(argument);
                    }
                }               
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string GAL = cBoxGAL.Text;
                string COM = cBoxCOM.Text;
                string FILE = openFileDialog1.FileName;
                if (GAL == "")
                {
                    txtTerm.Text = "Seleccionar GAL";
                }
                else if (COM == "")
                {
                    txtTerm.Text = "Seleccionar Puerto COM";
                }
                else if(FILE == "")
                {
                    txtTerm.Text = "Seleccionar Archivo JEDEC";
                }
                else
                {
                    List<object> argument = new List<object>();
                    argument.Add(COM);
                    argument.Add(GAL);
                    argument.Add(FILE);

                    workWrite.RunWorkerAsync(argument);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                string GAL = cBoxGAL.Text;
                string COM = cBoxCOM.Text;
                string FILE = openFileDialog1.FileName;
                if (GAL == "")
                {
                    txtTerm.Text = "Seleccionar GAL";
                }
                else if (COM == "")
                {
                    txtTerm.Text = "Seleccionar Puerto COM";
                }
                else if (FILE == "")
                {
                    txtTerm.Text = "Seleccionar Archivo JEDEC";
                }
                else
                {
                    List<object> argument = new List<object>();
                    argument.Add(COM);
                    argument.Add(GAL);
                    argument.Add(FILE);

                    workVerify.RunWorkerAsync(argument);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            try
            {
                string GAL = cBoxGAL.Text;
                string COM = cBoxCOM.Text;
                string FILE = openFileDialog1.FileName;
                if (GAL == "")
                {
                    txtTerm.Text = "Seleccionar GAL";
                }
                else if (COM == "")
                {
                    txtTerm.Text = "Seleccionar Puerto COM";
                }
                else
                {
                    List<object> argument = new List<object>();
                    argument.Add(COM);
                    argument.Add(GAL);

                    workErase.RunWorkerAsync(argument);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVPP_Click(object sender, EventArgs e)
        {
            

            try
            {
                //string GAL = cBoxGAL.Text;
                string COM = cBoxCOM.Text;
                progressBar1.Value = 0;

                if(true)
                {
                    progressBar1.Value = 50;
                }
               

                if (COM == "")
                {
                    txtTerm.Text = "Seleccionar Puerto COM";

                }
                else
                {
                    if(workVPP.IsBusy != true)
                    {
                        
                        workVPP.RunWorkerAsync(argument : COM);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            btnCone.Enabled = true;
            btnDesc.Enabled = false;
            btnVPP.BackColor = Color.Transparent;
            btnReadDev.BackColor = Color.Transparent;
            btnRead.BackColor = Color.Transparent;
            btnErase.BackColor = Color.Transparent;
            btnWrite.BackColor = Color.Transparent;
            btnVerify.BackColor = Color.Transparent;

            txtBoxFile.Clear();
            txtTerm.Clear();
            

            progressBar1.Value = 0;
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intBuffer;
            intBuffer = serialPort1.BytesToRead;
            byte[] byteBuffer = new byte[intBuffer];
            serialPort1.Read(byteBuffer, 0, intBuffer);
            this.Invoke(new EventHandler(DoUpDate));
        }

        private void DoUpDate(object s, EventArgs e)
        {
            txtTerm.Text = serialPort1.ReadLine();
        }

        private void Form1_FromClosing(object sender, EventArgs e)
        {
            serialPort1.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            cBoxCOM.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cBoxCOM.Items.AddRange(ports);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void workReadDevice_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> Device  = e.Argument as List<object>;
            string COM = (string) Device.ElementAt(0);
            string GAL = (string) Device.ElementAt(1);


            string command = "/c afterburner_w64 i -t " + GAL + " -d " + COM + " -v";
            txtTerm.Invoke(new Action(() =>
            {
                txtTerm.Text = txtTerm.Text = command;
            }));
            
            workReadDevice.ReportProgress(50);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            procStartInfo.FileName = "cmd";
            procStartInfo.Arguments = command;
            // This means that it will be redirected to the Process.StandardOutput StreamReader.

            process.StartInfo = procStartInfo;
            //progressBar1.Value = 30;
            workReadDevice.ReportProgress(60);
            process.Start();
            string result = process.StandardOutput.ReadToEnd();

            string result2 = getBetween(result, "V ", " GAL,");
            if (result2 != "Unknown")
            {
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******READ DEVICE INFO: OK*******\r\n" + result + "****************************";
                }));
                btnReadDev.BackColor = Color.YellowGreen;
            }
            else
            {
                btnReadDev.BackColor = Color.Red;
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******READ DEVICE INFO: FAIL*******\r\n" + result + "\r\n****************************";
                }));

            }

            workReadDevice.ReportProgress(100);
            //btnReadDev.Enabled = true;



        }

        private void workReadDevice_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void workVPP_DoWork(object sender, DoWorkEventArgs e)
        {
            string COM = (string) e.Argument;
            string command = "/c afterburner_w64 s -d " + COM + " -v";
            //txtTerm.Text = command;
            workVPP.ReportProgress(20);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            procStartInfo.FileName = "cmd";
            procStartInfo.Arguments = command;
            workVPP.ReportProgress(40);
            // This means that it will be redirected to the Process.StandardOutput StreamReader.

            process.StartInfo = procStartInfo;
            //progressBar1.Value = 30;

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            result = getBetween(result, "\r\n\r\nresult=", "\r\n");
            workVPP.ReportProgress(60);
            if (result == "0")
            {
                txtTerm.Invoke(new Action(() =>
                {
                    
                    txtTerm.Text = "\r\nTEST VPP: OK";
                }));
                

                btnVPP.BackColor = Color.YellowGreen;
            }
            else
            {
                btnVPP.BackColor = Color.Red;
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "\r\nRevisar Programador y conexion USB";
                }));
                
            }


            /*
            System.Diagnostics.ProcessStartInfo procStartInfo =
            new System.Diagnostics.ProcessStartInfo("cmd", command);*/
            //System.Diagnostics.Process.Start("CMD.exe", command);


            // The following commands are needed to redirect the standard output.
            // This means that it will be redirected to the Process.StandardOutput StreamReader.
            //procStartInfo.RedirectStandardOutput = true;
            //procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            //procStartInfo.CreateNoWindow = true;
            // Now we create a process, assign its ProcessStartInfo and start it
            workVPP.ReportProgress(100);
            //progressBar1.Value = 100;
        }

        private void workVPP_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtTerm.Clear();
        }

        private void workRead_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> Device = e.Argument as List<object>;
            string COM = (string)Device.ElementAt(0);
            string GAL = (string)Device.ElementAt(1);


            string command = "/c afterburner_w64 r -t " + GAL + " -d " + COM + " -v";
            txtTerm.Invoke(new Action(() =>
            {
                txtTerm.Text = txtTerm.Text = command;
            }));

            workRead.ReportProgress(50);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            procStartInfo.FileName = "cmd";
            procStartInfo.Arguments = command;
            // This means that it will be redirected to the Process.StandardOutput StreamReader.

            process.StartInfo = procStartInfo;
            //progressBar1.Value = 30;
            workRead.ReportProgress(60);
            process.Start();
            string result = process.StandardOutput.ReadToEnd();

            string result2 = getBetween(result, "\r\nresult=", "\r\n");
            if (result2 != "-1")
            {
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******READ DEVICE: OK*******\r\n" + result + "****************************";
                }));
                btnRead.BackColor = Color.YellowGreen;
            }
            else
            {
                btnRead.BackColor = Color.Red;
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******READ DEVICE: FAIL*******\r\n" + result + "\r\n****************************";
                }));

            }

            workRead.ReportProgress(100);
        }

        private void workRead_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void workWrite_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> Device = e.Argument as List<object>;
            string COM = (string)Device.ElementAt(0);
            string GAL = (string)Device.ElementAt(1);
            string FILE = (string)Device.ElementAt(2);

            string command = "/c afterburner_w64 w -t " + GAL + " -f " + FILE + " -d " + COM + " -v";
            
            txtTerm.Invoke(new Action(() =>
            {
                txtTerm.Text = txtTerm.Text = command;
            }));

            workWrite.ReportProgress(50);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            procStartInfo.FileName = "cmd";
            procStartInfo.Arguments = command;
            // This means that it will be redirected to the Process.StandardOutput StreamReader.

            process.StartInfo = procStartInfo;
            //progressBar1.Value = 30;
            workWrite.ReportProgress(60);
            process.Start();
            string result = process.StandardOutput.ReadToEnd();

            string result2 = getBetween(result, "\r\nresult=", "\r\n");
            if (result2 != "-1")
            {
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******WRITE DEVICE: OK*******\r\n" + result + "****************************";
                }));
                btnWrite.BackColor = Color.YellowGreen;
            }
            else
            {
                btnWrite.BackColor = Color.Red;
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******WRITE DEVICE: FAIL*******\r\n" + result + "\r\n****************************";
                }));

            }

            workWrite.ReportProgress(100);

        }

        private void workWrite_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void workVerify_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> Device = e.Argument as List<object>;
            string COM = (string)Device.ElementAt(0);
            string GAL = (string)Device.ElementAt(1);
            string FILE = (string)Device.ElementAt(2);

            string command = "/c afterburner_w64 v -t " + GAL + " -f " + FILE + " -d " + COM + " -v";

            txtTerm.Invoke(new Action(() =>
            {
                txtTerm.Text = txtTerm.Text = command;
            }));

            workVerify.ReportProgress(50);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            procStartInfo.FileName = "cmd";
            procStartInfo.Arguments = command;
            // This means that it will be redirected to the Process.StandardOutput StreamReader.

            process.StartInfo = procStartInfo;
            //progressBar1.Value = 30;
            workVerify.ReportProgress(60);
            process.Start();
            string result = process.StandardOutput.ReadToEnd();

            string result2 = getBetween(result, "\r\nresult=", "\r\n");
            if (result2 != "-1")
            {
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******VERIFY DEVICE: OK*******\r\n" + result + "****************************";
                }));
                btnVerify.BackColor = Color.YellowGreen;
            }
            else
            {
                btnVerify.BackColor = Color.Red;
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******VERIFY DEVICE: FAIL*******\r\n" + result + "\r\n****************************";
                }));

            }

            workVerify.ReportProgress(100);


        }

        private void workVerify_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void workErase_DoWork(object sender, DoWorkEventArgs e)
        {
            List<object> Device = e.Argument as List<object>;
            string COM = (string)Device.ElementAt(0);
            string GAL = (string)Device.ElementAt(1);

            string command = "/c afterburner_w64 e -t " + GAL + " -d " + COM + " -v";

            txtTerm.Invoke(new Action(() =>
            {
                txtTerm.Text = txtTerm.Text = command;
            }));

            workErase.ReportProgress(50);
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.RedirectStandardInput = true;
            procStartInfo.UseShellExecute = false;
            // Do not create the black window.
            procStartInfo.CreateNoWindow = true;
            procStartInfo.FileName = "cmd";
            procStartInfo.Arguments = command;
            // This means that it will be redirected to the Process.StandardOutput StreamReader.

            process.StartInfo = procStartInfo;
            //progressBar1.Value = 30;
            workErase.ReportProgress(60);
            process.Start();
            string result = process.StandardOutput.ReadToEnd();

            string result2 = getBetween(result, "\r\nresult=", "\r\n");
            if (result2 != "-1")
            {
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******ERASE DEVICE: OK*******\r\n" + result + "****************************";
                }));
                btnErase.BackColor = Color.YellowGreen;
            }
            else
            {
                btnErase.BackColor = Color.Red;
                txtTerm.Invoke(new Action(() =>
                {
                    txtTerm.Text = "*******ERASE DEVICE: FAIL*******\r\n" + result + "\r\n****************************";
                }));

            }

            workErase.ReportProgress(100);

        }

        private void workErase_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}


