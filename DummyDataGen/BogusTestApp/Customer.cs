using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace BogusTestApp
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ContactName { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
