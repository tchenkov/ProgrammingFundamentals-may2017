using System;


namespace P05_WeatherForecast
{
    class P05_WeatherForecast
    {
        static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            try
            {
                sbyte.Parse(numberString);
                Console.WriteLine("Sunny");
            }
            catch (Exception)
            {
                try
                {
                    int.Parse(numberString);
                    Console.WriteLine("Cloudy");
                }
                catch (Exception)
                {
                    try
                    {
                        long.Parse(numberString);
                        Console.WriteLine("Windy");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            decimal.Parse(numberString);
                            Console.WriteLine("Rainy");
                        }
                        catch(Exception)
                        {
                            
                        }
                    }
                }
            }
        }
    }
}
