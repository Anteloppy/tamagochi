using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi.entities
{
    internal class Pet
    {
        public int id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public bool gender { get; set; }
        public decimal age { get; set; }
    }
}
