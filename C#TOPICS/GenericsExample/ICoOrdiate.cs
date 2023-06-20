namespace GenericsExample
{
    public interface ICoOrdiate<P, R, S>
    {
        P X { get; set; }
        R Y { get; set; }
    }
}
