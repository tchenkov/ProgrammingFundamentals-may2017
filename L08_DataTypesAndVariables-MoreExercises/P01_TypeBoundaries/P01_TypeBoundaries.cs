using System;
using System.Collections.Generic;

namespace P01_TypeBoundaries
{
    class P01_TypeBoundaries
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            GetDateTypeBoundaries(dataType);
        }

        private static void GetDateTypeBoundaries(string dataType)
        {
            string minStr = "min";
            string maxStr = "max";
            var dataTypesMinMax = new Dictionary<string, Dictionary<string, string>>
            {
                {
                    "sbyte", new Dictionary<string, string>()
                    {
                        {minStr, sbyte.MinValue.ToString()}, { maxStr, sbyte.MaxValue.ToString()}
                    }
                },

                {
                    "byte", new Dictionary<string, string>()
                    {
                        {minStr, byte.MinValue.ToString()}, {maxStr, byte.MaxValue.ToString()}
                    }
                },

                {
                    "int", new Dictionary<string, string>()
                    {
                        {minStr, int.MinValue.ToString()}, {maxStr, int.MaxValue.ToString()}
                    }
                },

                {
                    "uint", new Dictionary<string, string>()
                    {
                        {minStr, uint.MinValue.ToString()}, {maxStr, uint.MaxValue.ToString()}
                    }
                },

                {
                    "long", new Dictionary<string, string>()
                    {
                        {minStr, long.MinValue.ToString()}, {maxStr, long.MaxValue.ToString()}
                    }
                }
            };

            Console.WriteLine(dataTypesMinMax[dataType][maxStr]);
            Console.WriteLine(dataTypesMinMax[dataType][minStr]);
        }
    }
}
