using System;


namespace P07_GreaterOfTwoValues
{
    class P07_GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType == "string")
            {
                var value1 = Console.ReadLine();
                var value2 = Console.ReadLine();
                GetMaxValue(value1, value2);
            }
            if (dataType == "char")
            {
                var value1 = char.Parse(Console.ReadLine());
                var value2 = char.Parse(Console.ReadLine());
                GetMaxValue(value1, value2);
            }
            if (dataType == "int")
            {
                var value1 = int.Parse(Console.ReadLine());
                var value2 = int.Parse(Console.ReadLine());
                GetMaxValue(value1, value2);
            }
        }
        
        static void GetMaxValue(string value1, string value2)
        {
            Console.WriteLine(value1.CompareTo(value2) > 0 ?
                value1 :
                value2
                );
        }

        static void GetMaxValue(char value1, char value2)
        {
            Console.WriteLine(value1 > value2 ?
                value1 :
                value2
                );
        }

        static void GetMaxValue(int value1, int value2)
        {
            Console.WriteLine(value1 > value2 ?
                value1 :
                value2
                );
        }
    }
}
