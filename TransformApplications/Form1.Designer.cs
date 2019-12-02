namespace TransformApplications
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblpercentage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSaveLoc = new System.Windows.Forms.Button();
            this.txtFileSave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnStdClear = new System.Windows.Forms.Button();
            this.btnStandardizationSubmit = new System.Windows.Forms.Button();
            this.btnNonStandard = new System.Windows.Forms.Button();
            this.txtNonStandardFile = new System.Windows.Forms.TextBox();
            this.btnStandard = new System.Windows.Forms.Button();
            this.txtStandardFile = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 64);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1043, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Running : ";
            // 
            // lblpercentage
            // 
            this.lblpercentage.AutoSize = true;
            this.lblpercentage.Location = new System.Drawing.Point(75, 127);
            this.lblpercentage.Name = "lblpercentage";
            this.lblpercentage.Size = new System.Drawing.Size(0, 13);
            this.lblpercentage.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse Access DB File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(0, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textFileName
            // 
            this.textFileName.Location = new System.Drawing.Point(18, 43);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(295, 20);
            this.textFileName.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textFileName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(34, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSaveLoc);
            this.groupBox2.Controls.Add(this.txtFileSave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(607, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 128);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Save Location";
            // 
            // btnSaveLoc
            // 
            this.btnSaveLoc.Location = new System.Drawing.Point(364, 44);
            this.btnSaveLoc.Name = "btnSaveLoc";
            this.btnSaveLoc.Size = new System.Drawing.Size(124, 23);
            this.btnSaveLoc.TabIndex = 2;
            this.btnSaveLoc.Text = "Choose Save Location";
            this.btnSaveLoc.UseVisualStyleBackColor = true;
            this.btnSaveLoc.Click += new System.EventHandler(this.btnSaveLoc_Click);
            // 
            // txtFileSave
            // 
            this.txtFileSave.Location = new System.Drawing.Point(99, 47);
            this.txtFileSave.Name = "txtFileSave";
            this.txtFileSave.Size = new System.Drawing.Size(239, 20);
            this.txtFileSave.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "File Location";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lblpercentage);
            this.groupBox3.Location = new System.Drawing.Point(34, 360);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1081, 177);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prcoessing";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel2);
            this.groupBox4.Location = new System.Drawing.Point(34, 573);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1081, 131);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OutPut";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(18, 52);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 13);
            this.linkLabel2.TabIndex = 0;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnStdClear);
            this.groupBox5.Controls.Add(this.btnStandardizationSubmit);
            this.groupBox5.Controls.Add(this.btnNonStandard);
            this.groupBox5.Controls.Add(this.txtNonStandardFile);
            this.groupBox5.Controls.Add(this.btnStandard);
            this.groupBox5.Controls.Add(this.txtStandardFile);
            this.groupBox5.Location = new System.Drawing.Point(34, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1081, 172);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Excel Operations";
            // 
            // btnStdClear
            // 
            this.btnStdClear.Location = new System.Drawing.Point(873, 103);
            this.btnStdClear.Name = "btnStdClear";
            this.btnStdClear.Size = new System.Drawing.Size(120, 32);
            this.btnStdClear.TabIndex = 5;
            this.btnStdClear.Text = "Clear";
            this.btnStdClear.UseVisualStyleBackColor = true;
            this.btnStdClear.Click += new System.EventHandler(this.btnStdClear_Click);
            // 
            // btnStandardizationSubmit
            // 
            this.btnStandardizationSubmit.Location = new System.Drawing.Point(736, 103);
            this.btnStandardizationSubmit.Name = "btnStandardizationSubmit";
            this.btnStandardizationSubmit.Size = new System.Drawing.Size(120, 32);
            this.btnStandardizationSubmit.TabIndex = 4;
            this.btnStandardizationSubmit.Text = "Submit";
            this.btnStandardizationSubmit.UseVisualStyleBackColor = true;
            this.btnStandardizationSubmit.Click += new System.EventHandler(this.btnStandardizationSubmit_Click);
            // 
            // btnNonStandard
            // 
            this.btnNonStandard.Location = new System.Drawing.Point(873, 37);
            this.btnNonStandard.Name = "btnNonStandard";
            this.btnNonStandard.Size = new System.Drawing.Size(188, 23);
            this.btnNonStandard.TabIndex = 3;
            this.btnNonStandard.Text = "Browse Non Standard File";
            this.btnNonStandard.UseVisualStyleBackColor = true;
            this.btnNonStandard.Click += new System.EventHandler(this.btnNonStandard_Click);
            // 
            // txtNonStandardFile
            // 
            this.txtNonStandardFile.Location = new System.Drawing.Point(553, 39);
            this.txtNonStandardFile.Name = "txtNonStandardFile";
            this.txtNonStandardFile.Size = new System.Drawing.Size(295, 20);
            this.txtNonStandardFile.TabIndex = 2;
            // 
            // btnStandard
            // 
            this.btnStandard.Location = new System.Drawing.Point(344, 39);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(188, 23);
            this.btnStandard.TabIndex = 1;
            this.btnStandard.Text = "Browse Standard File";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // txtStandardFile
            // 
            this.txtStandardFile.Location = new System.Drawing.Point(18, 42);
            this.txtStandardFile.Name = "txtStandardFile";
            this.txtStandardFile.Size = new System.Drawing.Size(295, 20);
            this.txtStandardFile.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1176, 146);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(125, 61);
            this.btnQuery.TabIndex = 12;
            this.btnQuery.Text = "Create Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 745);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
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
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblpercentage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveLoc;
        private System.Windows.Forms.TextBox txtFileSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnNonStandard;
        private System.Windows.Forms.TextBox txtNonStandardFile;
        private System.Windows.Forms.Button btnStandard;
        private System.Windows.Forms.TextBox txtStandardFile;
        private System.Windows.Forms.Button btnStdClear;
        private System.Windows.Forms.Button btnStandardizationSubmit;
        private System.Windows.Forms.Button btnQuery;
    }
}

