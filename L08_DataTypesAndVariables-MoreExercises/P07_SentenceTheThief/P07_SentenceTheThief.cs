using System;

namespace P07_SentenceTheThief
{
    class P07_SentenceTheThief
    {
        static void Main(string[] args)
        {
            string dataTypeThiefID = Console.ReadLine();
            byte countOfIDs = byte.Parse(Console.ReadLine());
            long thiefID = long.MinValue;
            while (countOfIDs > 0)
            {
                string currentID = Console.ReadLine();
                if (dataTypeThiefID == "sbyte")
                {
                    try
                    {
                        long currentIDNum = sbyte.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (dataTypeThiefID == "int")
                {
                    try
                    {
                        long currentIDNum = int.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }
                if (dataTypeThiefID == "long")
                {
                    try
                    {
                        long currentIDNum = long.Parse(currentID);
                        thiefID = Math.Max(currentIDNum, thiefID);
                    }
                    catch (Exception)
                    {

                    }
                }

                countOfIDs--;
            }

            if (thiefID > 0)
            {
                long sentence = (long) Math.Ceiling((decimal)thiefID / sbyte.MaxValue);
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
            else
            {
                long sentence = (long)Math.Ceiling((decimal)thiefID / sbyte.MinValue);
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} " + (sentence > 1 ? "years" : $"year"));
            }
        }
    }
}
