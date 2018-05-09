using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.Entity
{
    public class EAdres
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public string AddressName { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public int PostalCode { get; set; }
        public string Address { get; set; }
    }
}
