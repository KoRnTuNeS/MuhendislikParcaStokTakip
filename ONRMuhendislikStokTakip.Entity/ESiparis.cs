using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.Entity
{
    public class ESiparis
    {
        public int ID { get; set; }
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public bool Status { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingCode { get; set; }
    }
}
