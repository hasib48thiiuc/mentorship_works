namespace GenericsExample
{
    public class Container<T> where T : IItem, new()
    {
        private T[] _items;
        private int _index;

        public Container()
        {
            _items = new T[100];
            _index = 0;
        }
        public void AddItem(T item)
        {
            if (_index < _items.Length)
                _items[_index++] = item;
        }

        public T GetItem(int index)
        {
            if (index < _index)
                return _items[index];
            else
                return default(T);
        }

    }

}
