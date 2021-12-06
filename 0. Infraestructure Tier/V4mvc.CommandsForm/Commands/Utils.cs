using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace V4mvc.Commands.Classes
{
    public class Utils
    {
        private static Dictionary<string, int> m_contentTypes = new Dictionary<string, int> { { "procedure", 0 }, { "function", 1 } };

        private static Dictionary<string, string> m_mappingsDotNetGenericDb = new Dictionary<string, string> {
            { "string", "SqlDbType.NVarChar" },
            { "Int32", "SqlDbType.Int" },
            { "Int16", "SqlDbType.SmallInt" },
            { "Guid", "SqlDbType.UniqueIdentifier" },
            { "Int64", "SqlDbType.BigInt" },
            { "DateTime", "SqlDbType.DateTime" },
            { "decimal", "SqlDbType.Decimal" },
            { "byte[]", "SqlDbType.Image" },
            { "double", "SqlDbType.Float" },
            { "bool", "SqlDbType.Bit" },
            { "Single", "SqlDbType.Real" }
        };

        private static Dictionary<string, string> m_mappingsDotNetParsingFuncs = new Dictionary<string, string> {
            { "string", "" },
            { "int", "int.Parse" },
            { "Int32", "Int32.Parse" },
            { "Int16", "Int16.Parse" },
            { "Guid", "Guid.Parse" },
            { "Int64", "Int64.Parse" },
            { "DateTime", "DateTime.Parse" },
            { "decimal", "decimal.Parse" },
            { "byte[]", "" },
            { "double", "double.Parse" },
            { "bool", "bool.Parse" },
            { "Single", "Single.Parse" }
        };

        private static Dictionary<int, string> m_reverseContentTypes = new Dictionary<int, string> { { 0, "procedure" }, { 1, "function" } };

        public static Dictionary<string, int> contentTypes { get { return m_contentTypes; } }

        public static Dictionary<int, string> reverseContentTypes { get { return m_reverseContentTypes; } }



        private static string folder_entity_fragment = null;
        private static string folder_entity = null;
        private static string folder_dataaccess = null;
        private static string folder_dataaccess_fragment = null;
        private static string folder_businesslogic = null;
        private static string folder_service = null;
        private static string folder_storedprocedures = null;

        public class FilterSpObject
        {
            public DateTime start { get; set; }
            public DateTime end { get; set; }
        }

        public class TiersGenOptions
        {
            public bool GenerateEntityTier { get; set; } = false;
            public bool GenerateDataAccessTier { get; set; } = false;

            public bool GenerateBusinessLogicTier { get; set; } = false;

            public bool GenerateServiceTier { get; set; } = false;

            public bool GenerateUpdatedConfig { get; set; } = false;

            public bool GenerateStoredProcedures { get; set; } = false;

            public bool atLeastOne()
            {
                return GenerateEntityTier || GenerateDataAccessTier || GenerateBusinessLogicTier || GenerateServiceTier || GenerateUpdatedConfig || GenerateStoredProcedures;
            }
        }

        public static void EmptyFolder(string folder)
        {
            DirectoryInfo directory = new System.IO.DirectoryInfo(folder);
            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo subDirectory in directory.GetDirectories())
            {
                subDirectory.Delete(true);
            }
        }

        public static bool CreateOrSetFile(string filepath, string contents)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filepath, false))
                {
                    writer.Write(contents);
                }
                return true;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            return false;
        }

        public static Dictionary<string, string> GetMappedTypes()
        {
            const string preffix = "SQL_DATATYPE_MAPPING_";
            return ConfigurationManager.AppSettings.AllKeys
                             .Where(key => key.StartsWith(preffix))
                             .Select(key => new { k = key.Substring(key.IndexOf(preffix) + preffix.Length).ToLower(), v = ConfigurationManager.AppSettings[key] })
                             .ToDictionary(e => e.k, e => e.v);
        }

        public static Dictionary<string, int> GetMappedSqlTypeFieldWidths()
        {
            const string preffix = "SQL_DATATYPE_PRECISION_TYPE_";
            return ConfigurationManager.AppSettings.AllKeys
                             .Where(key => key.StartsWith(preffix))
                             .Select(key => new { k = key.Substring(key.IndexOf(preffix) + preffix.Length).ToLower(), v = ConfigurationManager.AppSettings[key] })
                             .ToDictionary(e => e.k, e => int.Parse(e.v));
        }



        public static string EntityFragmentsFolder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(folder_entity_fragment))
                    {
                        var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");
                        if (infrastructure_dir != null)
                        {
                            var dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @".\V4mvc.CommandsForm\Configurations\SpSaveCommand\1.Entity\Fragments"));
                            folder_entity_fragment = dir.FullName;
                        }
                    }
                    return folder_entity_fragment;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
            }
        }

        public static string EntityFolder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(folder_entity))
                    {
                        var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");
                        if (infrastructure_dir != null)
                        {
                            var dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @".\V4mvc.CommandsForm\Configurations\SpSaveCommand\1.Entity"));
                            folder_entity = dir.FullName;
                        }
                    }
                    return folder_entity;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
            }
        }

        public static string DataAccessFolder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(folder_dataaccess))
                    {
                        var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");
                        if (infrastructure_dir != null)
                        {
                            var dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @".\V4mvc.CommandsForm\Configurations\SpSaveCommand\2.Data_Access"));
                            folder_dataaccess = dir.FullName;
                        }
                    }
                    return folder_dataaccess;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
            }
        }

        public static string DataAccessFragmentsFolder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(folder_dataaccess_fragment))
                    {
                        var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");
                        if (infrastructure_dir != null)
                        {
                            var dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @".\V4mvc.CommandsForm\Configurations\SpSaveCommand\2.Data_Access\Fragments"));
                            folder_dataaccess_fragment = dir.FullName;
                        }
                    }
                    return folder_dataaccess_fragment;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
            }
        }

        public static string BusinessLogicFolder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(folder_businesslogic))
                    {
                        var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");
                        if (infrastructure_dir != null)
                        {
                            var dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @".\V4mvc.CommandsForm\Configurations\SpSaveCommand\3.Business_Logic"));
                            folder_businesslogic = dir.FullName;
                        }
                    }
                    return folder_businesslogic;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
            }
        }

        public static string ServiceFolder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(folder_service))
                    {
                        var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");
                        if (infrastructure_dir != null)
                        {
                            var dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @".\V4mvc.CommandsForm\Configurations\SpSaveCommand\4.Service"));
                            folder_service = dir.FullName;
                        }
                    }
                    return folder_service;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
            }
        }

        public static string StoredProceduresFolder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(folder_storedprocedures))
                    {
                        var curr_path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                        var infrastructure_dir = Utils.GetNearestFolderNamed(curr_path, "0. Infraestructure Tier");
                        if (infrastructure_dir != null)
                        {
                            var dir = new DirectoryInfo(Path.Combine(infrastructure_dir.FullName, @".\V4mvc.CommandsForm\Configurations\SpSaveCommand\6.Stored_Procedures"));
                            folder_storedprocedures = dir.FullName;
                        }
                    }
                    return folder_storedprocedures;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
            }
        }

        public static Dictionary<string, string> GetMappingsNetGenericDb
        {
            get
            {
                return m_mappingsDotNetGenericDb;
            }
        }
        public static Dictionary<string, string> GetMappingsNetParsingFuncs
        {
            get
            {
                return m_mappingsDotNetParsingFuncs;
            }
        }

        public static HashSet<string> GetStoredProcedures(string app_folder)
        {
            HashSet<string> result = null;
            foreach (string file in Directory.EnumerateFiles(app_folder, "*.cs", SearchOption.AllDirectories))
            {
                foreach (Match ItemMatch in Regex.Matches(File.ReadAllText(file), @"Instance\.DAAsignarProcedure\(""([^""]+)"))
                {
                    var dependency = ItemMatch.Groups[1].Value;
                    if (result == null)
                    {
                        result = new HashSet<string>();
                    }
                    result.Add(dependency);
                }
            }
            return result;
        }

        public static DirectoryInfo GetNearestFolderNamed(string startFolder, string searchFolder)
        {
            DirectoryInfo ret = null;
            DirectoryInfo dir = new DirectoryInfo(startFolder);
            while (dir.Exists)
            {
                if (dir.Name == searchFolder)
                {
                    return dir;
                }
                if (dir.Parent == null)
                {
                    return null;
                }
                dir = new DirectoryInfo(Path.Combine(dir.FullName, @"..\"));
            }
            return ret;
        }

        public static bool CreateFileAt(string root_path, string subfolder, string inner_subfolder, string fname, string contents)
        {
            try
            {
                var root = Directory.CreateDirectory(root_path); //create or return info if exists
                subfolder = Path.Combine(root.FullName, subfolder);
                var nested_folder = Directory.CreateDirectory(subfolder); //create or return info if exists
                inner_subfolder = Path.Combine(nested_folder.FullName, inner_subfolder);
                var ssubfolder = Directory.CreateDirectory(inner_subfolder); //create or return info if exists
                return CreateOrSetFile(Path.Combine(ssubfolder.FullName, fname), contents);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public static string PreProcessStr(string str)
        {
            string result = str.Replace("{", "{{").Replace("}", "}}");

            return Regex.Replace(result, @"\$(\d+)", "{$1}");
        }

        public static string GetSuggestedEntityName(string table_name)
        {
            if (string.IsNullOrEmpty(table_name))
            {
                return table_name;
            }
            var sb = new StringBuilder();
            sb.Append(string.Join("", table_name.ToLower().Split(new char[] { '_' }).Select(x => x.Substring(0, 1).ToUpper() + x.Substring(1)).ToArray()));
            return sb.ToString();
        }

        public static string GetSuggestedSingularName(string entity_name)
        {
            return Regex.Replace(entity_name, @"(es|s)$", "");
        }

        public static string GetSuggestedPluralName(string entity_name)
        {
            var singular = GetSuggestedSingularName(entity_name);
            return singular + "s";
        }

    }
}
