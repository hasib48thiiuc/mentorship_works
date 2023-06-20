namespace C_OOP
{
    public class Dice
    {
        public int[] Sides { get; protected set; }
        public int FaceValue { get; protected set; }

        public Dice()
        {
            Sides = new int[6];
            Sides[0] = 1;
            Sides[1] = 2;
            Sides[2] = 3;
            Sides[3] = 4;
            Sides[4] = 5;
            Sides[5] = 6;
        }

        public virtual void Roll()
        {
            Console.WriteLine("Rolling logic for 6 sided dice");
        }
    }
}
