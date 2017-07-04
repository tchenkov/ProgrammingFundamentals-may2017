using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P07_QueryMess
{
    class P07_QueryMess
    {
        static void Main(string[] args)
        {
            var inputDataList = GetInputData();
            var outputList = GetKeysAndValues(inputDataList);
            foreach (var str in outputList)
            {
                Console.WriteLine(str);
            }
        }

        static List<MatchCollection> GetInputData()
        {
            var inputData = Console.ReadLine();
            var inputDataList = new List<MatchCollection>();
            var pattern =
                @"(?<key>[^&\?]+?)=(?<value>[^\?&]+)";
            var regex = new Regex(pattern);
            while (inputData != "END")
            {
                var matches = regex.Matches(inputData);
                if (matches.Count > 0)
                {
                    inputDataList.Add(matches);
                }

                inputData = Console.ReadLine();
            }

            return inputDataList;
        }

        static List<string> GetKeysAndValues(List<MatchCollection> inputDataList)
        {
            var outputList = new List<string>();

            foreach (MatchCollection matches in inputDataList)
            {
                var lineOfKeysAndValues = GetKeysAndValues(matches);
                var outputLine = string.Empty;
                foreach (var key in lineOfKeysAndValues)
                {
                    var values = string.Join(", ", key.Value);
                    outputLine += $"{key.Key}=[{values}]";
                }
                outputList.Add(outputLine);

            }


            return outputList;
        }

        private static Dictionary<string, List<string>> GetKeysAndValues(MatchCollection matches)
        {
            var keysAndValues = new Dictionary<string, List<string>>();

            foreach (Match match in matches)
            {
                var key = match.Groups["key"].Value;
                key = ReplaceWithSpacesAndTrim(key);
                var value = match.Groups["value"].Value;
                value = ReplaceWithSpacesAndTrim(value);
                if (!keysAndValues.ContainsKey(key))
                {
                    keysAndValues[key] = new List<string>();
                }
                keysAndValues[key].Add(value);
            }
            return keysAndValues;
        }
        
        static string ReplaceWithSpacesAndTrim(string inputData)
        {
            var pattern = @"(?:[+]+)|(?:%20)+";
            inputData = Regex.Replace(inputData, pattern, " ");
            var spaces = @"[ ]{2,}";
            inputData = Regex.Replace(inputData, spaces, " ");
            return inputData.Trim();
        }
    }
}
