using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Important_Interfaces
{
    public class Box : ICollection<object>
    {
        private object[] _items;
        private int _index;
        private int _size;

        public Box(int size)
        {
            _size = size;
            _items = new object[size];
        }

        public int Count { get { return _items.Length; } }

        public bool IsReadOnly => false;

        public void Add(object item)
        {
            _items[_index++] = item;
        }

        public void Clear()
        {
            _index = 0;
            _items = new object[_size];
        }

        public bool Contains(object item)
        {
            foreach (var i in _items)
                if (i.Equals(item))
                    return true;

            return false;
        }

        public void CopyTo(object[] array, int arrayIndex)
        {
            if (array != null && array.Length > arrayIndex + _items.Length)
            {
                for (int i = 0; i < _items.Length; i++)
                {
                    array[arrayIndex++] = _items[i];
                }
            }
        }

        public IEnumerator<object> GetEnumerator()
        {
            return new BoxEnumerator(_items);
        }

        public bool Remove(object item)
        {
            if (Contains(item))
            {
                int c = 0;
                var newArray = new object[_size - 1];
                for (int i = 0; i < _items.Length; i++)
                {
                    if (!_items[i].Equals(item))
                        newArray[c++] = _items[i];
                }

                _items = newArray;

                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
}
