namespace TransformApplications
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMergeClear = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnBrowseF2 = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.lblFile2 = new System.Windows.Forms.Label();
            this.btnBrowseF1 = new System.Windows.Forms.Button();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.lblfile1 = new System.Windows.Forms.Label();
            this.lnkMergeFile = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSkuFile = new System.Windows.Forms.TextBox();
            this.btnSkuFile = new System.Windows.Forms.Button();
            this.btnSkuStart = new System.Windows.Forms.Button();
            this.btnSkuClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 86);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayan Defect File";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(584, 34);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(123, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(197, 34);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(335, 20);
            this.txtFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your non standard file";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(440, 143);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(543, 143);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(153, 207);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(86, 13);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "Processing:........";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMergeClear);
            this.groupBox2.Controls.Add(this.btnMerge);
            this.groupBox2.Controls.Add(this.btnBrowseF2);
            this.groupBox2.Controls.Add(this.txtF2);
            this.groupBox2.Controls.Add(this.lblFile2);
            this.groupBox2.Controls.Add(this.btnBrowseF1);
            this.groupBox2.Controls.Add(this.txtF1);
            this.groupBox2.Controls.Add(this.lblfile1);
            this.groupBox2.Location = new System.Drawing.Point(12, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 180);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Merge your Sayan Files";
            // 
            // btnMergeClear
            // 
            this.btnMergeClear.Location = new System.Drawing.Point(531, 139);
            this.btnMergeClear.Name = "btnMergeClear";
            this.btnMergeClear.Size = new System.Drawing.Size(75, 23);
            this.btnMergeClear.TabIndex = 5;
            this.btnMergeClear.Text = "Clear";
            this.btnMergeClear.UseVisualStyleBackColor = true;
            this.btnMergeClear.Click += new System.EventHandler(this.btnMergeClear_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(428, 139);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 6;
            this.btnMerge.Text = "Merge F1F2";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnBrowseF2
            // 
            this.btnBrowseF2.Location = new System.Drawing.Point(584, 77);
            this.btnBrowseF2.Name = "btnBrowseF2";
            this.btnBrowseF2.Size = new System.Drawing.Size(123, 23);
            this.btnBrowseF2.TabIndex = 5;
            this.btnBrowseF2.Text = "Browse F2";
            this.btnBrowseF2.UseVisualStyleBackColor = true;
            this.btnBrowseF2.Click += new System.EventHandler(this.btnBrowseF2_Click);
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(153, 80);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(379, 20);
            this.txtF2.TabIndex = 4;
            // 
            // lblFile2
            // 
            this.lblFile2.AutoSize = true;
            this.lblFile2.Location = new System.Drawing.Point(32, 88);
            this.lblFile2.Name = "lblFile2";
            this.lblFile2.Size = new System.Drawing.Size(91, 13);
            this.lblFile2.TabIndex = 3;
            this.lblFile2.Text = "Place your F2 File";
            // 
            // btnBrowseF1
            // 
            this.btnBrowseF1.Location = new System.Drawing.Point(584, 33);
            this.btnBrowseF1.Name = "btnBrowseF1";
            this.btnBrowseF1.Size = new System.Drawing.Size(123, 23);
            this.btnBrowseF1.TabIndex = 2;
            this.btnBrowseF1.Text = "Browse F1";
            this.btnBrowseF1.UseVisualStyleBackColor = true;
            this.btnBrowseF1.Click += new System.EventHandler(this.btnBrowseF1_Click);
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(153, 36);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(379, 20);
            this.txtF1.TabIndex = 1;
            // 
            // lblfile1
            // 
            this.lblfile1.AutoSize = true;
            this.lblfile1.Location = new System.Drawing.Point(32, 44);
            this.lblfile1.Name = "lblfile1";
            this.lblfile1.Size = new System.Drawing.Size(91, 13);
            this.lblfile1.TabIndex = 0;
            this.lblfile1.Text = "Place your F1 File";
            // 
            // lnkMergeFile
            // 
            this.lnkMergeFile.AutoSize = true;
            this.lnkMergeFile.Location = new System.Drawing.Point(165, 445);
            this.lnkMergeFile.Name = "lnkMergeFile";
            this.lnkMergeFile.Size = new System.Drawing.Size(62, 13);
            this.lnkMergeFile.TabIndex = 5;
            this.lnkMergeFile.TabStop = true;
            this.lnkMergeFile.Text = "Progressing";
            this.lnkMergeFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMergeFile_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSkuClear);
            this.groupBox3.Controls.Add(this.btnSkuStart);
            this.groupBox3.Controls.Add(this.btnSkuFile);
            this.groupBox3.Controls.Add(this.txtSkuFile);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(13, 491);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(731, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Program Sku";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Browse Your Excel FIle";
            // 
            // txtSkuFile
            // 
            this.txtSkuFile.Location = new System.Drawing.Point(169, 29);
            this.txtSkuFile.Name = "txtSkuFile";
            this.txtSkuFile.Size = new System.Drawing.Size(362, 20);
            this.txtSkuFile.TabIndex = 1;
            // 
            // btnSkuFile
            // 
            this.btnSkuFile.Location = new System.Drawing.Point(583, 26);
            this.btnSkuFile.Name = "btnSkuFile";
            this.btnSkuFile.Size = new System.Drawing.Size(123, 23);
            this.btnSkuFile.TabIndex = 2;
            this.btnSkuFile.Text = "Browse";
            this.btnSkuFile.UseVisualStyleBackColor = true;
            this.btnSkuFile.Click += new System.EventHandler(this.btnSkuFile_Click);
            // 
            // btnSkuStart
            // 
            this.btnSkuStart.Location = new System.Drawing.Point(427, 83);
            this.btnSkuStart.Name = "btnSkuStart";
            this.btnSkuStart.Size = new System.Drawing.Size(75, 23);
            this.btnSkuStart.TabIndex = 3;
            this.btnSkuStart.Text = "Start";
            this.btnSkuStart.UseVisualStyleBackColor = true;
            this.btnSkuStart.Click += new System.EventHandler(this.btnSkuStart_Click);
            // 
            // btnSkuClear
            // 
            this.btnSkuClear.Location = new System.Drawing.Point(530, 83);
            this.btnSkuClear.Name = "btnSkuClear";
            this.btnSkuClear.Size = new System.Drawing.Size(75, 23);
            this.btnSkuClear.TabIndex = 4;
            this.btnSkuClear.Text = "Clear";
            this.btnSkuClear.UseVisualStyleBackColor = true;
            this.btnSkuClear.Click += new System.EventHandler(this.btnSkuClear_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lnkMergeFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Excel Utility";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMergeClear;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnBrowseF2;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.Label lblFile2;
        private System.Windows.Forms.Button btnBrowseF1;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.Label lblfile1;
        private System.Windows.Forms.LinkLabel lnkMergeFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSkuClear;
        private System.Windows.Forms.Button btnSkuStart;
        private System.Windows.Forms.Button btnSkuFile;
        private System.Windows.Forms.TextBox txtSkuFile;
        private System.Windows.Forms.Label label2;
    }
}