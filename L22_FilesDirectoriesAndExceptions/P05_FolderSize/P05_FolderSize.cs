using System;
using System.IO;
using System.Linq;

namespace P05_FolderSize
{
    class P05_FolderSize
    {
        static void Main(string[] args)
        {
            var userDesctopPath = 
                Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Desktop\");
            var filesInPath = Directory.EnumerateFiles(userDesctopPath).ToList();
            decimal size = 0m;
            foreach (var file in filesInPath)
            {
                var fileLenth = new FileInfo(file);
                size += fileLenth.Length;
            }

            size = size / 1024 / 1024 / 1024;
            var  sizeString = string.Format("{0} GB",Math.Floor(size*100) / 100);

            File.WriteAllText(userDesctopPath + "dir size.txt", sizeString);
        }
    }
}
