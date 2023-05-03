using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceP2
{
    public class BoxEnumerator : IEnumerator<object>
    {
        private object[] _items;
        private int _index;
        public object Current
        {  
            get
            {
                return _items[_index];
            }            
        }

        public BoxEnumerator(object[] items)
        {
            _items = items;
            _index = -1;
        }





        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {      
            _index++;
            return _index < _items.Length; 
        }

        public void Reset()
        {

            _index = -1;
             
        }
    }
}
