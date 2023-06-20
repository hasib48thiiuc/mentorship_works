namespace AbstractClass
{
    public abstract class Vehicle
    {
        HashSet<int> ke = new HashSet<int>();
        Dictionary<int, string> name = new Dictionary<int, string>();
        public int PassengerCount { get; set; }
        public double Speed { get; set; }

        private double fuel;

        public Vehicle()
        {
            fuel = 0;
        }

        public abstract void StartEngine();

        public abstract void StopEngine();

        public void AddFuel(int amount)
        {
            fuel = amount;
        }
    }
}
