namespace ICollectionInterface
{
    public class WaterBottlecs : ICloneable
    {
        public int capacity { get; private set; }

        public string color { get; private set; }

        public int amount { get; private set; }

        public WaterBottlecs(int capacity, string color, int amount)
        {
            this.capacity = capacity;
            this.color = color;
            this.amount = amount;
        }
        public void AddAmount(int amoun)
        {
            amount += amoun;
        }
        public void Release(int amoun)
        {
            amount -= amoun;
        }

        public object Clone()
        {
            return new WaterBottlecs((int)capacity, color, amount);
        }
    }
}
