using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace V4mvc.Commands.Classes
{
    public class Utils
    {
        private static Dictionary<string, int> m_contentTypes = new Dictionary<string, int> { { "procedure", 0 }, { "function", 1 } };

        private static Dictionary<int, string> m_reverseContentTypes = new Dictionary<int, string> { { 0, "procedure"}, { 1, "function"} };

        public static Dictionary<string, int> contentTypes { get { return m_contentTypes; } }

        public static Dictionary<int, string> reverseContentTypes { get { return m_reverseContentTypes; } }

        
        public static void EmptyFolder(string folder)
        {
            DirectoryInfo directory = new System.IO.DirectoryInfo(folder);
            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo subDirectory in directory.GetDirectories()) {
                subDirectory.Delete(true);
            }
        }

        public static bool CreateOrSetFile(string filepath, string contents)
        {
            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                writer.Write(contents);
            }
            return false;
        }

        public static string SingleFilesFolder
        {
            get
            {
                try
                {
                    var command_dir = Utils.GetNearestFolderNamed(AppDomain.CurrentDomain.BaseDirectory, "V4mvc.Commands");
                    if (command_dir != null)
                    {
                        var dir = new DirectoryInfo(Path.Combine(command_dir.FullName, @".\Output\Single_Files"));
                        return dir.FullName;
                    }
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
                    var command_dir = Utils.GetNearestFolderNamed(AppDomain.CurrentDomain.BaseDirectory, "V4mvc.Commands");
                    if (command_dir != null)
                    {
                        var dir = new DirectoryInfo(Path.Combine(command_dir.FullName, @".\Output\Stored_Procedures"));
                        return dir.FullName;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return string.Empty;
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
                if(dir.Name == searchFolder)
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

        public static string nearestUnitTime(long ms)
        {
            string ret = string.Empty;
            if (ms >= 60000) {
                ret = string.Format("{0:0.0} minutes", ((float)ms) / 60000.0f);
            }
            else if(ms >= 1000 && ms < 60000)
            {
                ret = string.Format("{0:0.0} seconds", ((float)ms) / 1000.0f);
            }
            else
            {
                ret = string.Format("{0} miliseconds", ms);
            }
            return ret;
        }
    }
}
