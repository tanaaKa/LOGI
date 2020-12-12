using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LOGI.FileIO
{
    class DirectoryChecker
    {
        string directoriesPATH = Environment.GetEnvironmentVariable("LocalAppData") + @"\LOGI\directories.json";
        public Dictionary<string,string> directories = new Dictionary<string, string>();

        public DirectoryChecker()
        {
            
        }

        public Dictionary<string, string> getDirectories()
        {
            using (StreamReader sr = new StreamReader(directoriesPATH))
            {
                string content = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
            }
        }

        public void setDirectories()
        {
            using (StreamWriter file = new StreamWriter(directoriesPATH, false))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file,directories);
            }
        }

        public string[] getSubDirectories(string path)
        {
            string[] subDirectoryEntries = Directory.GetDirectories(path);
            return subDirectoryEntries;
        }
    }
}
