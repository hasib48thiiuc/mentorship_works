namespace AbstractClass
{
    public class Bus : Vehicle, IMovable
    {
        public override void StartEngine()
        {

        }

        public override void StopEngine()
        {

        }

        public void StartHeadLight()
        {

        }

        public void Move()
        {
            Console.WriteLine("Move from bus");
        }

        public void Stop()
        {
            Console.WriteLine("Stop from bus");
        }
    }
}
