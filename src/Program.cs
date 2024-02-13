using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var airline = new Airline();

            var plane1 = new PPlane("Passenger", 456, 45);
            var plane2 = new CPlane("Carry", 123, 34);

            airline.Add(plane1);
            airline.Add(plane2);

            Console.WriteLine(airline.ToString());

            airline.Planes.Sort();

            Console.WriteLine(airline.ToString());

            Console.Write("Введите число a\n> ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b\n> ");
            int b = int.Parse(Console.ReadLine());

            foreach (Plane p in airline.Planes)
            {
                if (a < p.FuelConsumption && p.FuelConsumption < b)
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }
    }
}