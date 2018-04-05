using System.Net;

namespace ReportUploader
{
    class Program
    {
        static void Main(string[] args)
        {
            var rs = new ReportService2005.ReportingService2005 {Credentials = CredentialCache.DefaultCredentials};
            
            var sourceFolder = @"C:\Banlaw\Code\_FT\FuelTrack\FMS.Reports\bin\Debug";
            var targetFolder = "/These/Are/Mine";
            var dataSourcesFolder = "/Data Sources";

            var ru = new ReportUploader(sourceFolder, targetFolder, dataSourcesFolder, rs);
            ru.Upload();
        }
    }
}
