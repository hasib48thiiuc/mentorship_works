using GenericsExample;

namespace GenericsExamples
{
    public class Apple : IItem
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Apple()
        {
            Width = 0;
        }

        public Apple(double weight)
        {
            Width = weight;
        }
    }
}
