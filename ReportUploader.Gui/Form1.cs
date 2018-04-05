using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportUploader.ReportService2005;

namespace ReportUploader.Gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DoUpload_Click(object sender, System.EventArgs e)
        {
            var credentials = !string.IsNullOrWhiteSpace(Username.Text)
                ? new NetworkCredential(Username.Text, Password.Text)
                : CredentialCache.DefaultCredentials;
            var rs = new ReportingService2005
            {
                Url = ServiceUrl.Text + "/ReportService2005.asmx",
                Credentials = credentials
            };
            var ru = new ReportUploader(SourceFolder.Text, TargetFolder.Text, DatasourceFolder.Text, rs);
            ru.Upload();
        }

        private void DoLocalBrowse_Click(object sender, System.EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                SourceFolder.Text = fbd.SelectedPath;
            }
        }
    }
}
