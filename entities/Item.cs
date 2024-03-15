using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi.entities
{
    internal class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public string status { get; set; }
        public bool in_inventory { get; set; }
        public string picture { get; set; }
    }
}
