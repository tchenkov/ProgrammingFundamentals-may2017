using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_Weather
{
    class P04_Weather

    {
        static void Main(string[] args)
        {
            var weatherString = Console.ReadLine();
            var forecasts = new Dictionary<string, List<dynamic>>();

            while (weatherString != "end")
            {
                var weatherPattern =
                    @"(?<city>[A-Z]{2})(?<avTemp>\d{1,2}\.(?:\d{0,2})?)(?<forecast>[^\|\d]\w+)(?=\|)";
                var weather = new Regex(weatherPattern);
                var currentWeather = weather.Match(weatherString);
                if (!currentWeather.Success)
                {
                    weatherString = Console.ReadLine();
                    continue;
                }
                var city = currentWeather.Groups["city"].Value;
                var avTemp = double.Parse(currentWeather.Groups["avTemp"].Value);
                var forecast = currentWeather.Groups["forecast"].Value;
                if (!forecasts.ContainsKey(city))
                {
                    forecasts[city] = new List<dynamic>();
                    forecasts[city].Add(avTemp);
                    forecasts[city].Add(forecast);
                }
                else
                {
                    forecasts[city][0] = avTemp;
                    forecasts[city][1] = forecast;
                }
                
                weatherString = Console.ReadLine();
            }
            forecasts = forecasts.OrderBy(c => c.Value[0]).ToDictionary(k => k.Key, v => v.Value);

            foreach (var city in forecasts)
            {
                Console.WriteLine($"{city.Key} => {city.Value[0]:F2} => {city.Value[1]}");
            }
        }
    }
}
