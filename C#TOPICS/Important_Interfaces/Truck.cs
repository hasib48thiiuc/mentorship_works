using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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