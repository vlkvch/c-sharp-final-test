using System;

namespace ConsoleApp1
{
    abstract class Plane : IComparable<Plane>
    {
        private string type;
        private int fuelConsumption;

        public string Type
        {
            get { return type; }
            set
            {
                if (value != "")
                {
                    type = value;
                }
                else
                {
                    throw new ArgumentException("Значение не должно быть пустым");
                }
            }
        }
        public int FuelConsumption
        {
            get { return fuelConsumption; }
            set
            {
                if (value > 0)
                {
                    fuelConsumption = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение должно быть больше нуля.");
                }
            }
        }

        public int CompareTo(Plane other)
        {
            return this.FuelConsumption.CompareTo(other.FuelConsumption);
        }

        public override string ToString()
        {
            return $"Тип: {Type}, расход топлива: {FuelConsumption}";
        }

        public Plane(string type, int fuelConsumption)
        {
            Type = type;
            FuelConsumption = fuelConsumption;
        }
    }
}
