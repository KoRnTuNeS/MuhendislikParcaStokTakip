using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ONRMuhendislikStokTakip.Entity
{
    public class EMusteri
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public DateTime RegisteredDate { get; set; }
    }
}
