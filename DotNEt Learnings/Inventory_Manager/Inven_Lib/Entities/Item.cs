using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inven_Lib.Entities
{
    public  class Item: IEntity<int>
    {
        public int Id { get; set; } 
        public decimal Price { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }
    }
}
