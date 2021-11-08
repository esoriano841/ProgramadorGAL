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
    }
}
