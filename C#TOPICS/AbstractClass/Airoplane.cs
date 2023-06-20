namespace AbstractClass
{
    internal class Airoplane : Vehicle, IMovable
    {
        public override void StartEngine()
        {

        }


        public void TakeOff()
        {

        }

        public void PullWheels()
        {

        }

        public override void StopEngine()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
