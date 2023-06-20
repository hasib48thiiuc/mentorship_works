namespace GenericsExample
{
    public class Coordinate<B, A>
    {
        public B Name { get; set; }

        public A Roll { get; set; }

        public void Dosomething<Q, R>(B Name1, Q Money, R penny)
        {


        }
    }
}
