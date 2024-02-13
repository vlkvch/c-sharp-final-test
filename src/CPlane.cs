namespace ConsoleApp1
{
    internal class CPlane : Plane
    {
        private int capacity;

        public override string ToString()
        {
            return base.ToString() + $", грузоподъемность: {capacity}.";
        }

        public CPlane(string type, int fuelConsumption, int capacity) : base(type, fuelConsumption)
        {
            this.capacity = capacity;
        }
    }
}
