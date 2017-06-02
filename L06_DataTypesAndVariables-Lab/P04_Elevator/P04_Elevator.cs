using System;

namespace P04_Elevator
{
    class P04_Elevator
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
                        
            int elevatorCourses = (int)Math.Ceiling((double)peopleCount / elevatorCapacity);
            Console.WriteLine(elevatorCourses);
        }
    }
}
