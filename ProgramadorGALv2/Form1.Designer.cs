
namespace ProgramadorGALv2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCOM = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxFile = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVPP = new System.Windows.Forms.Button();
            this.btnReadDev = new System.Windows.Forms.Button();
            this.cBoxGAL = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.btnDesc);
            this.groupBox1.Controls.Add(this.btnCone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxCOM);
            this.groupBox1.Location = new System.Drawing.Point(22, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMUNICACIÓN";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 98);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(234, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(143, 66);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(109, 27);
            this.btnDesc.TabIndex = 3;
            this.btnDesc.Text = "Desconcectar";
            this.btnDesc.UseVisualStyleBackColor = true;
            // 
            // btnCone
            // 
            this.btnCone.Location = new System.Drawing.Point(18, 66);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(109, 27);
            this.btnCone.TabIndex = 2;
            this.btnCone.Text = "Conectar";
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puerto COM";
            // 
            // cBoxCOM
            // 
            this.cBoxCOM.FormattingEnabled = true;
            this.cBoxCOM.Location = new System.Drawing.Point(131, 34);
            this.cBoxCOM.Name = "cBoxCOM";
            this.cBoxCOM.Size = new System.Drawing.Size(121, 24);
            this.cBoxCOM.TabIndex = 0;
            this.cBoxCOM.SelectedIndexChanged += new System.EventHandler(this.cBoxCOM_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Archivo JEDEC(*.jed)|*.jed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxFile);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Location = new System.Drawing.Point(304, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(413, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Archivo JEDEC";
            // 
            // txtBoxFile
            // 
            this.txtBoxFile.Location = new System.Drawing.Point(0, 34);
            this.txtBoxFile.Name = "txtBoxFile";
            this.txtBoxFile.Size = new System.Drawing.Size(309, 22);
            this.txtBoxFile.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(315, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Abrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(477, 153);
            this.txtTerm.Multiline = true;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(311, 285);
            this.txtTerm.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVPP);
            this.groupBox3.Controls.Add(this.btnReadDev);
            this.groupBox3.Controls.Add(this.cBoxGAL);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(22, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dispositivo";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnVPP
            // 
            this.btnVPP.Location = new System.Drawing.Point(159, 74);
            this.btnVPP.Name = "btnVPP";
            this.btnVPP.Size = new System.Drawing.Size(93, 23);
            this.btnVPP.TabIndex = 8;
            this.btnVPP.Text = "Test VPP";
            this.btnVPP.UseVisualStyleBackColor = true;
            this.btnVPP.Click += new System.EventHandler(this.btnVPP_Click);
            // 
            // btnReadDev
            // 
            this.btnReadDev.Location = new System.Drawing.Point(18, 74);
            this.btnReadDev.Name = "btnReadDev";
            this.btnReadDev.Size = new System.Drawing.Size(107, 23);
            this.btnReadDev.TabIndex = 7;
            this.btnReadDev.Text = "Read Device";
            this.btnReadDev.UseVisualStyleBackColor = true;
            this.btnReadDev.Click += new System.EventHandler(this.btnReadDev_Click);
            // 
            // cBoxGAL
            // 
            this.cBoxGAL.FormattingEnabled = true;
            this.cBoxGAL.Items.AddRange(new object[] {
            "GAL22V10",
            "GAL16V8",
            "ATF22V10",
            "ATF22V10B",
            "ATF22V10C",
            "ATF16V8B"});
            this.cBoxGAL.Location = new System.Drawing.Point(104, 34);
            this.cBoxGAL.Name = "cBoxGAL";
            this.cBoxGAL.Size = new System.Drawing.Size(121, 24);
            this.cBoxGAL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Device";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnErase);
            this.groupBox4.Controls.Add(this.btnVerify);
            this.groupBox4.Controls.Add(this.btnWrite);
            this.groupBox4.Controls.Add(this.btnRead);
            this.groupBox4.Location = new System.Drawing.Point(318, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(138, 162);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progamación";
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(6, 124);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(75, 23);
            this.btnErase.TabIndex = 9;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.Location = new System.Drawing.Point(6, 92);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(75, 26);
            this.btnVerify.TabIndex = 8;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(6, 63);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(6, 34);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnReadInfo_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnCone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCOM;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBoxFile;
        private System.Windows.Forms.Button btnOpen;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cBoxGAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnReadDev;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnVPP;
    }
}

