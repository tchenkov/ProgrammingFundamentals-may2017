using System.IO;
using System.Linq;

namespace P01_OddLines
{
    class P01_OddLines
    {
        static void Main(string[] args)
        {
            var textLines = File.ReadAllLines(@"C:\Users\todor\Desktop\input.txt");
            var oddLines = textLines.Where((t, i) => i % 2 == 1).ToArray();
            File.AppendAllLines(@"C:\Users\todor\Desktop\output.txt", oddLines);
        }
    }
}
