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
using System.Reflection;


namespace V4mvc.Commands.Classes
{
    public struct DependencyResult
    {
        public bool OK { get; set; }
        public List<KeyValuePair<string, string>> dependencies { get; set; }
    }

    public class SpSaveCommand
    {
        string[] m_blacklisted = null;
        string m_regex_exec = null;
        string m_dbo_regex = null;
        public SpSaveCommand(string output_folder, Utils.FilterSpObject mfilter = null)
        {
            this.output_folder = output_folder;
            this.provider = new DbDataProvider();
            this.filter = mfilter;
            this.m_blacklisted = ConfigurationManager.AppSettings["SQL_EXEC_REF_EXCLUDED_FUNCTIONS"].Split(',');
            this.m_regex_exec = ConfigurationManager.AppSettings["SQL_REGEX_PRIMARY_SP_CAPTURE"];
            this.m_dbo_regex = ConfigurationManager.AppSettings["SQL_REGEX_SECONDARY_SP_CAPTURE"];
        }

        private DbDataProvider provider { get; set; }

        private string output_folder { get; set; }

        private Utils.FilterSpObject filter { get; set; }

        private HashSet<string> filtered_names { get; set; }

        private string[] blacklisted_procs
        {
            get
            {
                return m_blacklisted;
            }
        }

        private string regex_exec
        {
            get
            {
                return m_regex_exec;
            }
        }
        private string dbo_regex
        {
            get
            {
                return m_dbo_regex;
            }
        }

        private bool CreateDependencyFile(List<string> sorted_dependencies)
        {
            bool ok = true;
            try
            {
                var sb = new StringBuilder();
                sb.Append("/* Este Archivo contiene los stored procedures y funciones que son usadas por los stored procedures de la solucion */");
                sb.Append("\n");
                sb.Append(string.Join("\n", sorted_dependencies.ToArray()));

                ok = Utils.CreateFileAt(this.output_folder, "SpSaveCommand", "Single_Files", "dependencies.txt", sb.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("error@CreateDependencyFile: {0}", exc.Message));
                ok = false;
            }
            return ok;
        }

        private bool CreateNotFoundFile(List<string> not_found)
        {
            bool ok = true;
            try
            {
                var sb = new StringBuilder();
                sb.Append("/* Este Archivo contiene los stored procedures que no existen en la BD pero estan presentes en la solucion */");
                sb.Append("\n");
                sb.Append(string.Join("\n", not_found.ToArray()));

                ok = Utils.CreateFileAt(this.output_folder, "SpSaveCommand", "Single_Files", "not_found.txt", sb.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("error@CreateNotFoundFile: {0}", exc.Message));
                ok = false;
            }
            return ok;
        }

        private bool CreateFoundFile(List<string> found)
        {
            bool ok = true;
            try
            {
                var sb = new StringBuilder();
                sb.Append("/* Este Archivo contiene los stored procedures que estan presentes en la solucion */");
                sb.Append("\n");
                sb.Append(string.Join("\n", found.ToArray()));

                ok = Utils.CreateFileAt(this.output_folder, "SpSaveCommand", "Single_Files", "found.txt", sb.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("error@CreateFoundFile: {0}", exc.Message));
                ok = false;
            }
            return ok;
        }

        private bool GenerateMergedFile(
            List<string> sorted_sources,
            ref Dictionary<string, KeyValuePair<string, int>> cache
        )
        {
            string SqlBlockMask = ConfigurationManager.AppSettings["SQL_QUERY_MASK_DROP_IF_EXISTS"]; ;
            StringBuilder sb = new StringBuilder();
            string contents = string.Empty;
            string sp_block = string.Empty;
            int db_type = -1;
            bool ok = false;
            bool retrieval_ok = false;
            try
            {
                foreach (var source in sorted_sources)
                {
                    retrieval_ok = false;
                    if (cache.ContainsKey(source))
                    {
                        var entry = cache[source];
                        db_type = entry.Value;
                        contents = entry.Key;
                        retrieval_ok = true;
                    }
                    else
                    {
                        var content_result = provider.GetObjectContent(source);
                        if (content_result.OK)
                        {
                            db_type = content_result.type;
                            contents = content_result.contents;
                            retrieval_ok = true;
                        }
                    }
                    if (retrieval_ok)
                    {
                        sp_block = string.Format(SqlBlockMask, source, Utils.reverseContentTypes[db_type].ToUpper(), contents);
                        sb.Append(sp_block);
                    }
                }
                ok = Utils.CreateFileAt(this.output_folder, "SpSaveCommand", "Single_Files", "merged.sql", sb.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("error@GenerateMergedFile: {0}", exc.Message));
                ok = false;
            }
            return ok;
        }

        private bool SavedStoredProcedures(
            List<string> stored_procs,
            ref Dictionary<string, KeyValuePair<string, int>> cache
        )
        {
            string contents = string.Empty;
            bool ok = true;
            bool retrieval_ok = false;
            try
            {
                foreach (var proc in stored_procs)
                {
                    retrieval_ok = false;
                    if (cache.ContainsKey(proc))
                    {
                        var entry = cache[proc];
                        contents = entry.Key;
                        retrieval_ok = true;
                    }
                    else
                    {
                        var content_result = provider.GetObjectContent(proc);
                        if (content_result.OK)
                        {
                            contents = content_result.contents;
                            retrieval_ok = true;
                        }
                    }
                    if (retrieval_ok)
                    {
                        ok = ok && Utils.CreateFileAt(this.output_folder, "SpSaveCommand", "Stored_Procedures", string.Format("{0}.sql", proc), contents);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(string.Format("error@SavedStoredProcedures: {0}", exc.Message));
                ok = false;
            }
            return ok;
        }

        public DependencyResult GetSpDependencies(
            string source_sp,
            string parent,
            ref Dictionary<string, KeyValuePair<string, int>> cache
        )
        {
            var dependencies = new HashSet<string>();
            bool ok = false;
            bool retrieval_ok = false;
            string contents = string.Empty;
            
            try
            {
                if (cache.ContainsKey(source_sp))
                {
                    contents = cache[source_sp].Key;
                    retrieval_ok = true;
                }
                else
                {
                    var content_result = provider.GetObjectContent(source_sp, parent);
                    if (content_result.OK)
                    {
                        cache[source_sp] = new KeyValuePair<string, int>(content_result.contents, content_result.type);
                        contents = content_result.contents;
                        retrieval_ok = true;
                    }
                }

                if (retrieval_ok)
                {
                    contents = Regex.Replace(contents, @"(/\*.*\*/)|(--.*--)|(--[^\s\r\n\t$]*[^\s\r\n\t$])", "");

                    foreach (Match ItemMatch in Regex.Matches(contents, regex_exec, RegexOptions.IgnoreCase))
                    {
                        var dependency = ItemMatch.Groups[1].Value;
                        var InnerMatch = Regex.Match(dependency, dbo_regex, RegexOptions.IgnoreCase);
                        if (InnerMatch.Success)
                        {
                            dependency = InnerMatch.Groups[1].Value;
                        }
                        dependency = dependency.Replace("[dbo].", "").Replace("[DBO].", "").Replace("[", "").Replace("]", "").Replace("dbo.", "").Replace("DBO.", "").Trim();

                        if (blacklisted_procs != null && blacklisted_procs.Length > 0 && !Array.Exists(blacklisted_procs, elem => elem == dependency))
                        {
                            dependencies.Add(dependency);
                        }
                        else if (blacklisted_procs == null || blacklisted_procs.Length < 1)
                        {
                            dependencies.Add(dependency);
                        }
                    }
                    ok = true;
                }
            }
            catch (Exception exc)
            {
                if (parent == null)
                {
                    Console.WriteLine(string.Format("error@GetSpDependencies: {0}\n{1}", source_sp, exc.Message));
                }
                else
                {
                    Console.WriteLine(string.Format("error@GetSpDependencies Parent: {0} ---> {1}\n{2}", parent, source_sp, exc.Message));
                }
                ok = false;
            }
            return new DependencyResult { OK = ok, dependencies = dependencies.Select(x => new KeyValuePair<string, string>(x, source_sp)).ToList() };
        }


        private void FillWithDependencies(
            List<KeyValuePair<string, string>> sources,
            ref Dictionary<string, KeyValuePair<string, int>> cache,
            ref HashSet<string> visited
        )
        {
            var dependencies = new List<KeyValuePair<string, string>>();
            try
            {
                string sp, parent;
                foreach (var entry in sources)
                {
                    sp = entry.Key;
                    parent = entry.Value;

                    visited.Add(sp);
                    var result = GetSpDependencies(sp, parent, ref cache);
                    if (result.OK)
                    {
                        if (result.dependencies != null && result.dependencies.Count > 0)
                        {
                            foreach (var dependency in result.dependencies)
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
                    FillWithDependencies(dependencies, ref cache, ref visited);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool evalObjectFilter(string sp_name)
        {
            if (this.filter == null) return true;
            return this.filtered_names.Contains(sp_name);
        }

        private void GetDependencies(
            List<string> raw_sps,
            ref Dictionary<string, KeyValuePair<string, int>> cache,
            ref List<string> dependencies,
            ref List<string> base_sps,
            ref List<string> not_found
        )
        {
            var visited = new HashSet<string>();
            var nfound_set = new HashSet<string>();
            var m_base_sps = new List<KeyValuePair<string, string>>();
            try
            {
                foreach (var sp in raw_sps)
                {
                    if (this.evalObjectFilter(sp))
                    {
                        var content_result = provider.GetObjectContent(sp);
                        if (content_result.OK)
                        {
                            m_base_sps.Add(new KeyValuePair<string, string>(sp, null));
                            if (!cache.ContainsKey(sp))
                            {
                                cache[sp] = new KeyValuePair<string, int>(content_result.contents, content_result.type);
                            }
                        }
                        else
                        {
                            if (content_result.ERR_TYPE == 1) /*DB Exception*/
                            {
                                nfound_set.Add(sp);
                            }
                        }
                    }
                }
                FillWithDependencies(m_base_sps, ref cache, ref visited);
                var enum_base_sps = m_base_sps.Select(x => x.Key);
                dependencies = visited.Except(enum_base_sps).OrderBy(x => x).ToList();
                base_sps = enum_base_sps.OrderBy(x => x).ToList();
                not_found = nfound_set.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool Run()
        {
            bool op_result = true;
            bool ok = true;
            try
            {
                var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");

                if (infrastructure_dir != null)
                {
                    var data_layer_dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @"..\2. Business Tier\V4mvc.DataAccess"));
                    var raw_sps = Utils.GetStoredProcedures(data_layer_dir.FullName);
                    var dependencies = new List<string>(); //objetos utilizados por nuestros sps del proyecto
                    var base_sps = new List<string>();  //sps directamente usados en el proyecto
                    var not_found = new List<string>(); //sps declarados en el proyecto pero no hallados en la BD
                    var cache_sp = new Dictionary<string, KeyValuePair<string, int>>();

                    this.filtered_names = provider.GetSpNamesUsingFilter(this.filter);
                    
                    GetDependencies(raw_sps.ToList(), ref cache_sp, ref dependencies, ref base_sps, ref not_found);

                    op_result = CreateDependencyFile(dependencies);
                    if (!op_result)
                    {
                        Console.WriteLine("CreateDependencyFile failed");
                    }
                    ok = ok && op_result;

                    op_result = CreateNotFoundFile(not_found);
                    if (!op_result)
                    {
                        Console.WriteLine("CreateNotFoundFile failed");
                    }
                    ok = ok && op_result;

                    op_result = CreateFoundFile(base_sps);
                    if (!op_result)
                    {
                        Console.WriteLine("CreateFoundFile failed");
                    }
                    ok = ok && op_result;

                    op_result = GenerateMergedFile(dependencies.Union(base_sps).ToList(), ref cache_sp);
                    if (!op_result)
                    {
                        Console.WriteLine("GenerateMergedFile failed");
                    }
                    ok = ok && op_result;

                    op_result = SavedStoredProcedures(base_sps, ref cache_sp);
                    if (!op_result)
                    {
                        Console.WriteLine("SavedStoredProcedures failed");
                    }
                    ok = ok && op_result;
                }
                else
                {
                    ok = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ok = false;
            }
            return ok;
        }
    }
}
