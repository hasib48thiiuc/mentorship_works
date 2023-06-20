namespace StaticClass1
{
    public class Class1
    {
        public string Name;
        public int roll;
        public static int count = 0;

        public Class1()
        {
            count++;
        }
        public static void print()
        {
            Console.WriteLine(count);
        }
    }
}
