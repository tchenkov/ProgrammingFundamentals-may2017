using System;
using System.Numerics;

namespace P10_CenturiesToNanoseconds
{
    class P10_CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            byte centureies = byte.Parse(Console.ReadLine());
            ushort years = (ushort) (centureies * 100);
            int days = (int)Math.Round(years * 365.2422);
            int hours = days * 24;
            long minutes = (long)hours * 60;
            long seconds = minutes * 60;
            ulong milliseconds = (ulong)seconds * 1000;
            BigInteger microseconds = (BigInteger)milliseconds * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centureies} centuries = {years} years = {days} days = {hours} hours = {minutes}"+ 
                $" minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
