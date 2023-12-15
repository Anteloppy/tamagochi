using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi.entities
{
    internal class Stat
    {
        public int id { get; set; }
        public decimal hunger { get; set; }
        public decimal thirst { get; set; }
        public decimal mood { get; set; }
        public decimal sleepiness { get; set; }
        public decimal beauty { get; set; }
        public decimal health { get; set; }
    }
}
