using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsExample
{
    public interface ICoOrdiate<P,R,S>
    {
        P X { get; set; }
        R Y { get; set; }
    }
}
