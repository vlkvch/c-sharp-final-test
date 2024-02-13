using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Airline
    {
        private List<Plane> planes;

        public List<Plane> Planes { get; set; }
        public int Passengers
        {
            get
            {
                int total = 0;

                foreach (PPlane p in planes)
                {
                    total += p.Passengers;
                }

                return total;
            }
        }

        public void Add(Plane plane)
        {
            Planes.Add(plane);
        }

        public override string ToString()
        {
            string str = "";

            foreach (Plane p in Planes)
                str += p.ToString() + "\n";

            return str;
        }

        public Airline()
        {
            Planes = new List<Plane>();
        }
    }
}
