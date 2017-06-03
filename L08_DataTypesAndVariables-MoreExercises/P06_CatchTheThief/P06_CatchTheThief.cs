using System;

namespace P06_CatchTheThief
{
    class P06_CatchTheThief
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
                    catch(Exception)
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

            Console.WriteLine(thiefID);
        }
    }
}
