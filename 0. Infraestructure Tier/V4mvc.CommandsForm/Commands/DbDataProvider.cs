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
    public class DbColumnInfo
    {
        public string name { get; set; }
        public string type { get; set; }
        public int max_len { get; set; }
        public int precision { get; set; }
        public int scale { get; set; }
        public bool nullable { get; set; }

        public bool is_pk { get; set; }

        public bool is_identity { get; set; }

    }

    public struct ObjectContentResult
    {
        public bool OK { get; set; }

        public int ERR_TYPE { get; set; }

        public string contents { get; set; }

        public int type { get; set; }
    }


    public class DbDataProvider
    {
        string m_create_regex = null;
        string m_sp_content_mask = null;
        string m_table_exist_mask = null;
        string m_table_fields_mask = null;
        string m_db_name = null;
        string m_db_objects_list_mask = null;
        public DbDataProvider()
        {
            var cs_values = ConfigurationManager.ConnectionStrings["MAIN_CONNECTION_STRING"];
            var provider = cs_values.ProviderName;
            var connectionString = cs_values.ConnectionString;
            DbProviderFactory factoria = DbProviderFactories.GetFactory(provider);

            connection = factoria.CreateConnection();
            connection.ConnectionString = connectionString;
            connection.Open();

            
            m_create_regex = ConfigurationManager.AppSettings["SQL_REGEX_CREATE_TYPE_CAPTURE"];
            m_sp_content_mask = ConfigurationManager.AppSettings["SQL_QUERY_MASK_GET_SP_CONTENT"];

            m_table_exist_mask = ConfigurationManager.AppSettings["SQL_QUERY_MASK_EXISTS_TABLE"];
            m_table_fields_mask = ConfigurationManager.AppSettings["SQL_QUERY_MASK_GET_TABLE_COLS"];

            m_db_objects_list_mask = ConfigurationManager.AppSettings["SQL_QUERY_MASK_GET_FILTERED_SP_LIST"];

            string db_param_name = "Database=";
            int istart = connectionString.IndexOf(db_param_name) + db_param_name.Length;
            int ss_count = connectionString.IndexOf(";", istart) - istart;
            m_db_name = connectionString.Substring(istart, ss_count);
        }

        private DbConnection connection { get; set; }

        public string DataBaseName
        {
            get
            {
                return m_db_name;
            }
        }
        private string db_objects_list_mask
        {
            get
            {
                return m_db_objects_list_mask;
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

        private string table_exist_mask
        {
            get
            {
                return m_table_exist_mask;
            }
        }

        private string table_fields_mask
        {
            get
            {
                return m_table_fields_mask;
            }
        }

        public ObjectContentResult GetObjectContent(string source_sp, string parent = null)
        {
            string contents = null;
            int type = -1;
            bool ok = false;
            int exc_type = 0;

            try
            {
                string normalized_oname = source_sp.ToLower();

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
                            var object_name = m.Groups[2].Value;
                            var cleaned_fetch_oname = object_name.ToLower().Replace("[dbo].", "").Replace("[", "").Replace("]", "").Replace("dbo.", "").Trim();
                            if (Utils.contentTypes.ContainsKey(key))
                            {
                                if (normalized_oname == cleaned_fetch_oname)
                                {
                                    type = Utils.contentTypes[key];
                                    ok = true;
                                }
                                else
                                {
                                    exc_type = 1;
                                }
                            }
                        }
                    }
                }
            }
            catch(System.Data.Common.DbException exc)
            {
                if (parent == null)
                {
                    Console.WriteLine(string.Format("errorDbException@GetObjectContent: {0}\n{1}", source_sp, exc.Message));
                }
                else
                {
                    Console.WriteLine(string.Format("errorDbException@GetObjectContent Parent: {0} ---> {1}\n{2}", parent, source_sp, exc.Message));
                }
                exc_type = 1;
                ok = false;
            }
            catch (Exception exc)
            {
                if (parent == null)
                {
                    Console.WriteLine(string.Format("error@GetObjectContent: {0}\n{1}", source_sp, exc.Message));
                }
                else
                {
                    Console.WriteLine(string.Format("error@GetObjectContent Parent: {0} ---> {1}\n{2}", parent, source_sp, exc.Message));
                }
                ok = false;
            }
            return new ObjectContentResult { OK = ok, contents = contents, type = type, ERR_TYPE = exc_type };
        }

        public bool DataTableExists(string table_name, out int err_type)
        {
            bool ok = false;
            err_type = -1;
            try
            {
                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = string.Format(table_exist_mask, table_name, table_name);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        var parsed = Int32.Parse(result.ToString());
                        if(parsed == 2)
                        {
                            err_type = 0; // view not table given
                        }
                        return parsed == 1;

                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                ok = false;
            }
            return ok;
        }

        public List<DbColumnInfo> GetTableColumnsInfo(string table_name)
        {
            List<DbColumnInfo> result = null;
            string name, type;
            int max_len, precision, scale;
            bool nullable, is_pk, is_identity;
            try
            {
                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = string.Format(table_fields_mask, table_name);
                    var reader = cmd.ExecuteReader();
                    result = new List<DbColumnInfo>();
                    while (reader.Read())
                    {
                        name = reader.GetString(0);
                        type = reader.GetString(1);
                        max_len = reader.GetValue(2) == null ? -1 : int.Parse(reader.GetInt16(2).ToString());
                        precision = reader.GetValue(3) == null ? -1 : int.Parse(reader.GetByte(3).ToString());
                        scale = reader.GetValue(4) == null ? -1 : int.Parse(reader.GetByte(4).ToString());
                        nullable = reader.GetBoolean(5);
                        is_pk = reader.GetBoolean(6);
                        is_identity = reader.GetBoolean(7);

                        result.Add(new DbColumnInfo
                        {
                            name = name,
                            type = type,
                            max_len = max_len,
                            precision = precision,
                            scale = scale,
                            nullable = nullable,
                            is_pk = is_pk,
                            is_identity = is_identity
                        });
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                result = null;
            }
            return result;

        }

        public HashSet<string> GetSpNamesUsingFilter(Utils.FilterSpObject filter)
        {
            HashSet<string> result = null;
            try
            {
                string name;
                using (DbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = string.Format(db_objects_list_mask, filter.start.ToString("yyyyMMdd HH:mm:ss"), filter.end.ToString("yyyyMMdd HH:mm:ss"));
                    var reader = cmd.ExecuteReader();
                    result = new HashSet<string>();
                    while (reader.Read())
                    {
                        name = reader.GetString(0);
                        result.Add(name);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                result = null;
            }
            return result;
        }
    }
}
