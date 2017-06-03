using System;

namespace P19_TheaThePhotographer
{
    class P19_TheaThePhotographer
    {
        static void Main(string[] args)
        {
            long pircturesCount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            byte filterFactor = byte.Parse(Console.ReadLine());
            long uploadTime = int.Parse(Console.ReadLine());

            long timeToFilterAllPics = pircturesCount * filterTime;
            int filteredPicsCount = (int) Math.Ceiling(pircturesCount * filterFactor / 100.0);
            long timeToUpload = filteredPicsCount * uploadTime;
            long readyTime = timeToFilterAllPics + timeToUpload;
            byte seconds = (byte) (readyTime % 60);
            readyTime = (readyTime - (readyTime % 60)) /60;
            byte minutes = (byte)(readyTime % 60);
            readyTime = (readyTime - (readyTime % 60)) / 60;
            byte hours = (byte)(readyTime % 24);
            readyTime = (readyTime - (readyTime % 24)) / 24;
            //int days = readyTime;

            Console.WriteLine($"{readyTime}:{hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
