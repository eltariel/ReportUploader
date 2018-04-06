namespace ReportUploader.Gui
{
    partial class UploadForm
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
            this.LocalParams = new System.Windows.Forms.GroupBox();
            this.DoLocalBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SourceFolder = new System.Windows.Forms.TextBox();
            this.RemoteParams = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.ServiceUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DatasourceFolder = new System.Windows.Forms.TextBox();
            this.TargetFolder = new System.Windows.Forms.TextBox();
            this.DoUpload = new System.Windows.Forms.Button();
            this.UploadProgress = new System.Windows.Forms.ProgressBar();
            this.LocalParams.SuspendLayout();
            this.RemoteParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // LocalParams
            // 
            this.LocalParams.Controls.Add(this.DoLocalBrowse);
            this.LocalParams.Controls.Add(this.label1);
            this.LocalParams.Controls.Add(this.SourceFolder);
            this.LocalParams.Location = new System.Drawing.Point(12, 12);
            this.LocalParams.Name = "LocalParams";
            this.LocalParams.Size = new System.Drawing.Size(472, 55);
            this.LocalParams.TabIndex = 0;
            this.LocalParams.TabStop = false;
            this.LocalParams.Text = "Local";
            // 
            // DoLocalBrowse
            // 
            this.DoLocalBrowse.Location = new System.Drawing.Point(362, 17);
            this.DoLocalBrowse.Name = "DoLocalBrowse";
            this.DoLocalBrowse.Size = new System.Drawing.Size(75, 23);
            this.DoLocalBrowse.TabIndex = 2;
            this.DoLocalBrowse.Text = "&Browse...";
            this.DoLocalBrowse.UseVisualStyleBackColor = true;
            this.DoLocalBrowse.Click += new System.EventHandler(this.DoLocalBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source &folder";
            // 
            // SourceFolder
            // 
            this.SourceFolder.Location = new System.Drawing.Point(114, 19);
            this.SourceFolder.Name = "SourceFolder";
            this.SourceFolder.Size = new System.Drawing.Size(242, 20);
            this.SourceFolder.TabIndex = 1;
            this.SourceFolder.TextChanged += new System.EventHandler(this.SourceFolder_TextChanged);
            // 
            // RemoteParams
            // 
            this.RemoteParams.Controls.Add(this.textBox1);
            this.RemoteParams.Controls.Add(this.Password);
            this.RemoteParams.Controls.Add(this.label5);
            this.RemoteParams.Controls.Add(this.label4);
            this.RemoteParams.Controls.Add(this.Username);
            this.RemoteParams.Controls.Add(this.ServiceUrl);
            this.RemoteParams.Controls.Add(this.label3);
            this.RemoteParams.Controls.Add(this.label2);
            this.RemoteParams.Controls.Add(this.DatasourceFolder);
            this.RemoteParams.Controls.Add(this.TargetFolder);
            this.RemoteParams.Location = new System.Drawing.Point(12, 73);
            this.RemoteParams.Name = "RemoteParams";
            this.RemoteParams.Size = new System.Drawing.Size(472, 164);
            this.RemoteParams.TabIndex = 1;
            this.RemoteParams.TabStop = false;
            this.RemoteParams.Text = "Remote";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(14, 126);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(85, 13);
            this.Password.TabIndex = 8;
            this.Password.Text = "SSRS &Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "SSRS &User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SSRS &Service URL";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(114, 97);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(324, 20);
            this.Username.TabIndex = 7;
            // 
            // ServiceUrl
            // 
            this.ServiceUrl.Location = new System.Drawing.Point(114, 71);
            this.ServiceUrl.Name = "ServiceUrl";
            this.ServiceUrl.Size = new System.Drawing.Size(324, 20);
            this.ServiceUrl.TabIndex = 5;
            this.ServiceUrl.Text = "http://localhost/ReportServer";
            this.ServiceUrl.TextChanged += new System.EventHandler(this.ServiceUrl_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Datasource Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Target Folder";
            // 
            // DatasourceFolder
            // 
            this.DatasourceFolder.Location = new System.Drawing.Point(114, 45);
            this.DatasourceFolder.Name = "DatasourceFolder";
            this.DatasourceFolder.Size = new System.Drawing.Size(324, 20);
            this.DatasourceFolder.TabIndex = 3;
            this.DatasourceFolder.Text = "/Data Sources";
            // 
            // TargetFolder
            // 
            this.TargetFolder.Location = new System.Drawing.Point(114, 19);
            this.TargetFolder.Name = "TargetFolder";
            this.TargetFolder.Size = new System.Drawing.Size(324, 20);
            this.TargetFolder.TabIndex = 1;
            this.TargetFolder.Text = "/FMS";
            // 
            // DoUpload
            // 
            this.DoUpload.Enabled = false;
            this.DoUpload.Location = new System.Drawing.Point(409, 243);
            this.DoUpload.Name = "DoUpload";
            this.DoUpload.Size = new System.Drawing.Size(75, 23);
            this.DoUpload.TabIndex = 3;
            this.DoUpload.Text = "Upload";
            this.DoUpload.UseVisualStyleBackColor = true;
            this.DoUpload.Click += new System.EventHandler(this.DoUpload_Click);
            // 
            // UploadProgress
            // 
            this.UploadProgress.Location = new System.Drawing.Point(12, 243);
            this.UploadProgress.MarqueeAnimationSpeed = 50;
            this.UploadProgress.Name = "UploadProgress";
            this.UploadProgress.Size = new System.Drawing.Size(391, 22);
            this.UploadProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.UploadProgress.TabIndex = 2;
            this.UploadProgress.Visible = false;
            // 
            // UploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 277);
            this.Controls.Add(this.UploadProgress);
            this.Controls.Add(this.DoUpload);
            this.Controls.Add(this.RemoteParams);
            this.Controls.Add(this.LocalParams);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UploadForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Report Uploader";
            this.LocalParams.ResumeLayout(false);
            this.LocalParams.PerformLayout();
            this.RemoteParams.ResumeLayout(false);
            this.RemoteParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LocalParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SourceFolder;
        private System.Windows.Forms.GroupBox RemoteParams;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DatasourceFolder;
        private System.Windows.Forms.TextBox TargetFolder;
        private System.Windows.Forms.Button DoUpload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox ServiceUrl;
        private System.Windows.Forms.Button DoLocalBrowse;
        private System.Windows.Forms.ProgressBar UploadProgress;
    }
}

