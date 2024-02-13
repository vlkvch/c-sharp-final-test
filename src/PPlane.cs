namespace ConsoleApp1
{
    internal class PPlane : Plane
    {
        private int passengers;

        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (value > 0)
                {
                    passengers = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Значение должно быть больше 0.");
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $", количество пассажиров: {Passengers}.";
        }

        public PPlane(string type, int fuelConsumption, int passengers) : base(type, fuelConsumption)
        {
            Passengers = passengers;
        }
    }
}
