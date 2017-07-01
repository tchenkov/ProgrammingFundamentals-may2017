using System;
using System.IO;
using System.Linq;

namespace P04_MergeFiles
{
    class P04_MergeFiles
    {
        static void Main(string[] args)
        {
            var path = Environment.ExpandEnvironmentVariables("%USERPROFILE%\\Desktop\\");
            var text1Lines = File.ReadAllLines(path + "input.txt");
            var text2Lines = File.ReadAllLines(path + "modified input.txt");
            var append2TextLines = text1Lines.Concat(text2Lines);
            File.WriteAllLines(path + "output.txt", append2TextLines);
        }
    }
}
