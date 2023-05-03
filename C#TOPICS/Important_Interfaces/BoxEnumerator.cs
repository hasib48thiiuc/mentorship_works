using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Important_Interfaces
{
    public class BoxEnumerator : IEnumerator<object> 
    {
        object[] _items;
        public object Current => throw new NotImplementedException();
        public BoxEnumerator(object[] items)
        {
            _items = items;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

