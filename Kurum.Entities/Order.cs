using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime OrderTime { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }

    }
}
