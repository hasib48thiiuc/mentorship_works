using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public interface IMovable
    {

        void Move();

        public void Stop()
        {
            Console.WriteLine("Stopping.");
        }

    }
}
