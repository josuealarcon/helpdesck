using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace V4mvc.Commands.Classes
{
    public class DbDataProvider
    {
        string[] m_blacklisted = null;
        string m_regex_exec = null;
        string m_dbo_regex = null;
        string m_create_regex = null;
        string m_sp_content_mask = null;

        public DbDataProvider()
        {
            var cs_values = ConfigurationManager.ConnectionStrings["MAIN_CONNECTION_STRING"];
            var provider = cs_values.ProviderName;
            var connectionString = cs_values.ConnectionString;
            DbProviderFactory factoria = DbProviderFactories.GetFactory(provider);

            connection = factoria.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            m_blacklisted = ConfigurationManager.AppSettings["SQL_EXEC_REF_EXCLUDED_FUNCTIONS"].Split(',');
            m_regex_exec = ConfigurationManager.AppSettings["SQL_REGEX_PRIMARY_SP_CAPTURE"];
            m_dbo_regex = ConfigurationManager.AppSettings["SQL_REGEX_SECONDARY_SP_CAPTURE"];
            m_create_regex = ConfigurationManager.AppSettings["SQL_REGEX_CREATE_TYPE_CAPTURE"];
            m_sp_content_mask = ConfigurationManager.AppSettings["SQL_QUERY_MASK_GET_SP_CONTENT"];
        }

        private DbConnection connection { get; set; }

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

        private string create_regex
        {
            get
            {
                return m_create_regex;
            }
        }

        private string sp_content_mask
        {
            get
            {
                return m_sp_content_mask;
            }
        }

        public dynamic GetSpDependencies(string source_sp, string parent = null)
        {
            var dependencies = new HashSet<string>();
            var content_result = GetSpFuncContent(source_sp, parent);
            bool ok = false;
            try
            {
                if (content_result.OK)
                {
                    string contents = Regex.Replace(content_result.contents, @"(/\*.*\*/)|(--.*--)|(--[^\s\r\n\t$]*[^\s\r\n\t$])", "");


                    foreach (Match ItemMatch in Regex.Matches(contents, regex_exec, RegexOptions.IgnoreCase))
                    {
                        var dependency = ItemMatch.Groups[1].Value;
                        var InnerMatch = Regex.Match(dependency, dbo_regex, RegexOptions.IgnoreCase);
                        if (InnerMatch.Success)
                        {
                            dependency = InnerMatch.Groups[1].Value;
                        }
                        dependency = dependency.Replace("[", "").Replace("]", "").Replace("dbo.", "").Trim();
                        
                        if (blacklisted_procs != null && blacklisted_procs.Length > 0 && !Array.Exists(blacklisted_procs, elem => elem == dependency))
                        {
                            dependencies.Add(dependency);
                        }
                        else if(blacklisted_procs == null || blacklisted_procs.Length < 1)
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
            return new { OK = ok, dependencies = dependencies.Select(x => new KeyValuePair<string, string>(x, source_sp)).ToList() };
        }

        public dynamic GetSpFuncContent(string source_sp, string parent = null)
        {
            string contents = null;
            int type = -1;
            bool ok = false;
            try
            {
                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = string.Format(sp_content_mask, source_sp);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        contents = result.ToString();
                        var m = Regex.Match(contents, create_regex, RegexOptions.IgnoreCase);
                        if (m.Success)
                        {
                            var key = m.Groups[1].Value.ToLower();
                            if (Utils.contentTypes.ContainsKey(key))
                            {
                                type = Utils.contentTypes[key];
                                ok = true;
                            }
                        }
                    }
                }
            }
            catch(Exception exc)
            {
                if (parent == null)
                {
                    Console.WriteLine(string.Format("error@GetSpFuncContent: {0}\n{1}", source_sp, exc.Message));
                }
                else
                {
                    Console.WriteLine(string.Format("error@GetSpFuncContent Parent: {0} ---> {1}\n{2}", parent, source_sp, exc.Message));
                }
                ok = false;
            }
            return new { OK = ok, contents = contents, type = type };
        }

        ~DbDataProvider()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();

            }
        }
    }
}
