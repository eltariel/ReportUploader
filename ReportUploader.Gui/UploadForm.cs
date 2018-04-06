using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportUploader.ReportService2005;

namespace ReportUploader.Gui
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();
        }

        private void DoLocalBrowse_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog {SelectedPath = SourceFolder.Text};
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                SourceFolder.Text = fbd.SelectedPath;
            }
        }

        private void DoUpload_Click(object sender, EventArgs e)
        {
            var credentials = !string.IsNullOrWhiteSpace(Username.Text)
                ? new NetworkCredential(Username.Text, Password.Text)
                : CredentialCache.DefaultCredentials;
            var url = ServiceUrl.Text + "/ReportService2005.asmx";

            ThreadPool.QueueUserWorkItem(o =>
            {
                var rs = new ReportingService2005
                {
                    Url = url,
                    Credentials = credentials
                };

                var ru = new ReportUploader(SourceFolder.Text, TargetFolder.Text, DatasourceFolder.Text, rs);

                SetIsUploading(true);
                ru.Upload();
                SetIsUploading(false);
            });
        }

        private void SetIsUploading(bool uploading)
        {
            LocalParams.InvokeIfRequired(c => c.Enabled = !uploading);
            RemoteParams.InvokeIfRequired(c => c.Enabled = !uploading);
            DoUpload.InvokeIfRequired(c => c.Enabled = !uploading);
            UploadProgress.InvokeIfRequired(c => c.Visible = uploading);
        }

        private void SourceFolder_TextChanged(object sender, EventArgs e)
        {
            DoUpload.Enabled = !string.IsNullOrWhiteSpace(SourceFolder.Text);
        }

        private void ServiceUrl_TextChanged(object sender, EventArgs e)
        {
            DoUpload.Enabled = !string.IsNullOrWhiteSpace(ServiceUrl.Text);
        }
    }
}
