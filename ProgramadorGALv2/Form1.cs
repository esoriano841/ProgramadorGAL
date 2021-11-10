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
            cBoxCOM.Items.AddRange(ports);
        }

        private void cBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCone_Click(object sender, EventArgs e)
        {
                txtTerm.Text = cBoxCOM.Text;
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
                    string command = "/c afterburner_w64 r -t " + GAL + " -d " + COM + " -v";
                    txtTerm.Text = "Read: " + command;
                    System.Diagnostics.Process.Start("CMD.exe", command);
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
                    string command = "/c afterburner_w64 i -t " + GAL + " -d " + COM + " -v";
                    txtTerm.Text = command;
                    System.Diagnostics.Process.Start("CMD.exe", command);
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
                    string command = "/c afterburner_w64 w -t " + GAL + " -f " + FILE + " -d " + COM + " -v";
                    txtTerm.Text = command;
                    System.Diagnostics.Process.Start("CMD.exe", command);
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
                    string command = "/c afterburner_w64 v -t " + GAL + " -f " + FILE + " -d " + COM + " -v";
                    txtTerm.Text = command;
                    System.Diagnostics.Process.Start("CMD.exe", command);
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
                else if (FILE == "")
                {
                    txtTerm.Text = "Seleccionar Archivo JEDEC";
                }
                else
                {
                    string command = "/c afterburner_w64 e -t " + GAL + " -d " + COM + " -v";
                    txtTerm.Text = command;
                    System.Diagnostics.Process.Start("CMD.exe", command);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVPP_Click(object sender, EventArgs e)
        {
            

            //try
            //{
                //string GAL = cBoxGAL.Text;
                string COM = cBoxCOM.Text;

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
                    string command = "/c afterburner_w64 s -d " + COM + " -v";
                    txtTerm.Text = command;
                    
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
                    progressBar1.Value = 30;
                    
                    process.Start();
                    string result = process.StandardOutput.ReadToEnd();
                    result = getBetween(result, "\r\n\r\nresult=", "\r\n");
                    if (result == "0")
                    {
                        txtTerm.Text = "Test VPP: OK";
                        btnVPP.BackColor = Color.YellowGreen;
                    }
                    else
                    {
                        btnVPP.BackColor = Color.Red;
                        txtTerm.Text = "Revisar Programador y conexion USB";
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
                    progressBar1.Value = 50;

                    // Get the output into a string
                    //process.StandardOutput.ReadToEnd();
                   
                    
                    progressBar1.Value = 100;
                }
            //}
            /*catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
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
    }
}


