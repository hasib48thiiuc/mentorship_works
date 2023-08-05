namespace Inven_Lib.Entities
{
    public interface IEntity<T>
    {
        public T Id { get; set; }
    }
}