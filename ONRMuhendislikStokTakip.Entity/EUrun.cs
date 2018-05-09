using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.Entity
{
    public class EUrun
    {
        public int ID { get; set; }
        public int SubCategoryID { get; set; }
        public int BrandID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public string MasterPhotoPath { get; set; }

    }
}
