using System.IO;
using System.Linq;

namespace P02_LineNumbers
{
    class P02_LineNumbers
    {
        static void Main(string[] args)
        {
            var textLines = File.ReadAllLines(@"C:\Users\todor\Desktop\input.txt");
            var oddLines = textLines.Select((t, i) => $"{i + 1}. " + t).ToArray();
            File.AppendAllLines(@"C:\Users\todor\Desktop\output.txt", oddLines);
        }
    }
}
