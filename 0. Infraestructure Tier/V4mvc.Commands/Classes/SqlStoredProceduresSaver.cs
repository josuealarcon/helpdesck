using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.Common;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;

namespace V4mvc.Commands.Classes
{
    public class SqlStoredProceduresSaver
    {
        public SqlStoredProceduresSaver()
        {
            provider = new DbDataProvider();
        }

        private DbDataProvider provider{ get; set; }


        private void CreateDependencyFile(List<string> sorted_dependencies)
        {
            Utils.CreateOrSetFile(Path.Combine(Utils.SingleFilesFolder, "dependencies.txt"), string.Join("\n", sorted_dependencies.ToArray()));
        }

        private void GenerateMergedFile(List<string> sorted_sources)
        {
            string SqlBlockMask = ConfigurationManager.AppSettings["SQL_QUERY_MASK_DROP_IF_EXISTS"]; ;
            StringBuilder sb = new StringBuilder();
            foreach(var source in sorted_sources)
            {
                var content_result = provider.GetSpFuncContent(source);
                if (content_result.OK)
                {
                    string sp_block = string.Format(SqlBlockMask, source, Utils.reverseContentTypes[content_result.type].ToUpper(), content_result.contents);
                    sb.Append(sp_block);
                }
            }
            Utils.CreateOrSetFile(Path.Combine(Utils.SingleFilesFolder, "merged.sql"), sb.ToString());
        }

        private void SavedStoredProcedures(List<string> stored_procs)
        {
            Utils.EmptyFolder(Utils.StoredProceduresFolder);
            foreach(var proc in stored_procs)
            {
                var content_result = provider.GetSpFuncContent(proc);
                if (content_result.OK)
                {
                    Utils.CreateOrSetFile(Path.Combine(Utils.StoredProceduresFolder, string.Format("{0}.sql", proc)), content_result.contents);
                }
            }
        }

        private void FillWithDependencies(List<KeyValuePair<string, string>> sources, ref HashSet<string> visited)
        {
            var dependencies = new List<KeyValuePair<string, string>>();

            foreach (var sp in sources)
            {
                visited.Add(sp.Key); //Key --> symbol, Value: parent
                var result = provider.GetSpDependencies(sp.Key, sp.Value);
                if (result.OK)
                {
                    if (result.dependencies != null && result.dependencies.Count > 0)
                    {
                        foreach(var dependency in result.dependencies)
                        {
                            if (!visited.Contains(dependency.Key))
                            {
                                dependencies.Add(dependency);
                            }
                        }
                        
                    }
                }
            }

            if (dependencies.Count > 0)
            {
                FillWithDependencies(dependencies, ref visited);
            }
        }

        private void GetDependencies(List<string> raw_sps, ref List<string> dependencies, ref List<string> base_sps)
        {
            var visited = new HashSet<string>();
            var m_base_sps = new List<KeyValuePair<string, string>>();
            foreach(var sp in raw_sps)
            {
                var content_result = provider.GetSpFuncContent(sp);
                if (content_result.OK)
                {
                    m_base_sps.Add(new KeyValuePair<string, string>(sp, null));
                }
            }
            FillWithDependencies(m_base_sps, ref visited);
            var enum_base_sps = m_base_sps.Select(x => x.Key);
            dependencies = visited.Except(enum_base_sps).OrderBy(x => x).ToList();
            base_sps = enum_base_sps.OrderBy(x => x).ToList();
        }

        public bool Run()
        {
            if (!string.IsNullOrEmpty(Utils.SingleFilesFolder) && !string.IsNullOrEmpty(Utils.StoredProceduresFolder))
            {
                try
                {

                    var gparent_dir = Utils.GetNearestFolderNamed(AppDomain.CurrentDomain.BaseDirectory, "0. Infraestructure Tier");
                    if(gparent_dir != null)
                    {
                        var data_layer_dir = new DirectoryInfo(Path.Combine(gparent_dir.FullName, @"..\2. Business Tier\V4mvc.DataAccess"));
                        var raw_sps = Utils.GetStoredProcedures(data_layer_dir.FullName);
                        var dependencies = new List<string>();
                        var base_sps = new List<string>();
                        GetDependencies(raw_sps.ToList(), ref dependencies, ref base_sps);
                        CreateDependencyFile(dependencies);
                        GenerateMergedFile(dependencies.Union(base_sps).ToList());
                        SavedStoredProcedures(base_sps);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return false;
        }
    }
}
