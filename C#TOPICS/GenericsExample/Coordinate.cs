using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public class Coordinate<B,A>
    {
      public  B Name { get; set; }

       public  A Roll { get; set; } 
        
        public void Dosomething<Q,R>(B Name1,Q Money,R penny)
        {


        }
    }
}
