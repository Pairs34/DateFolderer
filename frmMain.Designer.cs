namespace DateFolderer
{
    partial class frmMain
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
            this.lblFilesDir = new System.Windows.Forms.Label();
            this.txtFileDir = new System.Windows.Forms.TextBox();
            this.btnSelectFileDir = new System.Windows.Forms.Button();
            this.lblCountOfFile = new System.Windows.Forms.Label();
            this.btnSaveDir = new System.Windows.Forms.Button();
            this.txtSaveDir = new System.Windows.Forms.TextBox();
            this.lblSaveDir = new System.Windows.Forms.Label();
            this.folderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFilesDir
            // 
            this.lblFilesDir.AutoSize = true;
            this.lblFilesDir.Location = new System.Drawing.Point(12, 9);
            this.lblFilesDir.Name = "lblFilesDir";
            this.lblFilesDir.Size = new System.Drawing.Size(65, 13);
            this.lblFilesDir.TabIndex = 0;
            this.lblFilesDir.Text = "Dosya Dizini";
            // 
            // txtFileDir
            // 
            this.txtFileDir.Location = new System.Drawing.Point(83, 6);
            this.txtFileDir.Name = "txtFileDir";
            this.txtFileDir.Size = new System.Drawing.Size(310, 20);
            this.txtFileDir.TabIndex = 1;
            // 
            // btnSelectFileDir
            // 
            this.btnSelectFileDir.Location = new System.Drawing.Point(399, 4);
            this.btnSelectFileDir.Name = "btnSelectFileDir";
            this.btnSelectFileDir.Size = new System.Drawing.Size(61, 23);
            this.btnSelectFileDir.TabIndex = 2;
            this.btnSelectFileDir.Text = "Seç";
            this.btnSelectFileDir.UseVisualStyleBackColor = true;
            this.btnSelectFileDir.Click += new System.EventHandler(this.btnSelectFileDir_Click);
            // 
            // lblCountOfFile
            // 
            this.lblCountOfFile.AutoSize = true;
            this.lblCountOfFile.Location = new System.Drawing.Point(83, 29);
            this.lblCountOfFile.Name = "lblCountOfFile";
            this.lblCountOfFile.Size = new System.Drawing.Size(13, 13);
            this.lblCountOfFile.TabIndex = 3;
            this.lblCountOfFile.Text = "0";
            this.lblCountOfFile.Visible = false;
            // 
            // btnSaveDir
            // 
            this.btnSaveDir.Location = new System.Drawing.Point(399, 44);
            this.btnSaveDir.Name = "btnSaveDir";
            this.btnSaveDir.Size = new System.Drawing.Size(61, 23);
            this.btnSaveDir.TabIndex = 6;
            this.btnSaveDir.Text = "Seç";
            this.btnSaveDir.UseVisualStyleBackColor = true;
            this.btnSaveDir.Click += new System.EventHandler(this.btnSaveDir_Click);
            // 
            // txtSaveDir
            // 
            this.txtSaveDir.Location = new System.Drawing.Point(83, 46);
            this.txtSaveDir.Name = "txtSaveDir";
            this.txtSaveDir.Size = new System.Drawing.Size(310, 20);
            this.txtSaveDir.TabIndex = 5;
            // 
            // lblSaveDir
            // 
            this.lblSaveDir.AutoSize = true;
            this.lblSaveDir.Location = new System.Drawing.Point(12, 49);
            this.lblSaveDir.Name = "lblSaveDir";
            this.lblSaveDir.Size = new System.Drawing.Size(58, 13);
            this.lblSaveDir.TabIndex = 4;
            this.lblSaveDir.Text = "Kayıt Dizini";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(83, 72);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 100);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSaveDir);
            this.Controls.Add(this.txtSaveDir);
            this.Controls.Add(this.lblSaveDir);
            this.Controls.Add(this.lblCountOfFile);
            this.Controls.Add(this.btnSelectFileDir);
            this.Controls.Add(this.txtFileDir);
            this.Controls.Add(this.lblFilesDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Date Folderer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilesDir;
        private System.Windows.Forms.TextBox txtFileDir;
        private System.Windows.Forms.Button btnSelectFileDir;
        private System.Windows.Forms.Label lblCountOfFile;
        private System.Windows.Forms.Button btnSaveDir;
        private System.Windows.Forms.TextBox txtSaveDir;
        private System.Windows.Forms.Label lblSaveDir;
        private System.Windows.Forms.FolderBrowserDialog folderSelector;
        private System.Windows.Forms.Button btnStart;
    }
}

