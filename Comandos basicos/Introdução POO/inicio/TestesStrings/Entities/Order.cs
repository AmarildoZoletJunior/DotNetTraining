using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Entities.Enums;

namespace ConsoleApp3.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public OrderStatus Status { get; set; }



        public override string ToString()
        {
            return $"Id:{Id}\nData: {Momento}\nStatus:{Status}";
        }
    }

}
