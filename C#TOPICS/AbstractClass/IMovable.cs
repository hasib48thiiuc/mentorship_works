namespace AbstractClass
{
    public interface IMovable
    {

        void Move();

        public void Stop()
        {
            Console.WriteLine("Stopping.");
        }

    }
}
