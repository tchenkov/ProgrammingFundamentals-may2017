using System;

namespace P18_DifferentIntegersSize
{
    class P18_DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            sbyte dummySbyte = 0;
            bool isSbyte = sbyte.TryParse(numberString, out dummySbyte);

            byte dummyByte = 0;
            bool isByte = byte.TryParse(numberString, out dummyByte);

            short dummyShort = 0;
            bool isShort = short.TryParse(numberString, out dummyShort);

            ushort dummyUshort = 0;
            bool isUshort = ushort.TryParse(numberString, out dummyUshort);

            int dummyInt = 0;
            bool isInt = int.TryParse(numberString, out dummyInt);

            uint dummyUint = 0;
            bool isUint = uint.TryParse(numberString, out dummyUint);

            long dummyLong = 0;
            bool isLong = long.TryParse(numberString, out dummyLong);

            bool isNotFitting = !(isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong);

            if (isNotFitting)
            {
                Console.WriteLine($"{numberString} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{numberString} can fit in:");
                Console.Write(isSbyte ? "* sbyte\n" : "");
                Console.Write(isByte ? "* byte\n" : "");
                Console.Write(isShort ? "* short\n" : "");
                Console.Write(isUshort ? "* ushort\n" : "");
                Console.Write(isInt ? "* int\n" : "");
                Console.Write(isUint ? "* uint\n" : "");
                Console.Write(isLong ? "* long\n" : "");
            }
        }
    }
}
