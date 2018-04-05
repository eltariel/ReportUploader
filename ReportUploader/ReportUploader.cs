using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Services.Protocols;
using ReportUploader.ReportService2005;

namespace ReportUploader
{
    public class ReportUploader
    {
        private readonly string sourceFolder;
        private readonly string targetFolder;
        private readonly string dataSourcesFolder;
        private readonly ReportingService2005 rs;

        public ReportUploader(string sourceFolder, string targetFolder, string dataSourcesFolder, ReportingService2005 rs)
        {
            this.sourceFolder = sourceFolder;
            this.targetFolder = targetFolder;
            this.dataSourcesFolder = dataSourcesFolder;
            this.rs = rs;
        }

        public void Upload()
        {
            var ds = GetDataSources(rs, dataSourcesFolder);
            CreateFolder();
            foreach (var file in Directory.EnumerateFiles(sourceFolder, "*.rdl"))
            {
                CreateReport(targetFolder, file, ds);
            }
        }

        private void CreateFolder()
        {
            var pathParts = targetFolder.Split(new[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
            CreateFolder(pathParts, string.Empty);
        }

        private void CreateFolder(IEnumerable<string> pathParts, string parent)
        {
            var parts = pathParts.ToList();
            if (parts.Any())
            {
                var thisFolder = parts.First();
                try
                {
                    rs.CreateFolder(thisFolder, string.IsNullOrWhiteSpace(parent) ? "/" : parent, null);
                }
                catch (SoapException e)
                {
                    if (e.Detail["ErrorCode"].InnerText != "rsItemAlreadyExists")
                    {
                        throw;
                    }
                }

                CreateFolder(parts.Skip(1), $"{parent}/{thisFolder}");
            }
        }

        private void CreateReport(string folder, string rdlFile, Dictionary<string, DataSourceDefinitionOrReference> dataSources)
        {
            var name = Path.GetFileNameWithoutExtension(rdlFile);
            var reportContents = File.ReadAllBytes(rdlFile);
            
            //create report
            var warnings = rs.CreateReport(name, folder, true, reportContents, null);

            if (warnings != null)
            {
                Console.WriteLine("Report: '{0}':", name);
                foreach (var warning in warnings)
                {
                    Console.WriteLine(warning.Message);
                }
            }
            else
            {
                Console.WriteLine("Report: '{0}' created successfully with no warnings", name);
            }

            UpdateReportDataSources(folder, name, dataSources);
        }

        private static Dictionary<string, DataSourceDefinitionOrReference> GetDataSources(ReportingService2005 rs, string folder)
        {
            var children = rs.ListChildren(folder, false);
            return children
                .Where(i => i.Type == ItemTypeEnum.DataSource)
                .ToDictionary(
                    i => i.Name,
                    i => (DataSourceDefinitionOrReference)new DataSourceReference {Reference = i.Path});
        }

        private void UpdateReportDataSources(string folder,
            string name,
            Dictionary<string, DataSourceDefinitionOrReference> dataSources)
        {
            var itemPath = $"{folder}/{name}";
            var existingDataSources = rs.GetItemDataSources(itemPath);
            var sources = existingDataSources
                .Where(ds => dataSources.ContainsKey(ds.Name))
                .Select(ds => new DataSource {Name = ds.Name, Item = dataSources[ds.Name]})
                .ToArray();

            if (sources.Any())
            {
                rs.SetItemDataSources(itemPath, sources);
            }
        }
    }
}