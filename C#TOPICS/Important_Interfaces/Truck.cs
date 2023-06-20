using System.Collections;

namespace Important_Interfaces
{
    public class Truck : IEnumerable<object>

    {

        private object[] _items;
        public IEnumerator<object> GetEnumerator()
        {
            return new BoxEnumerator(_items);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}