﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamagochi.entities
{
    public class Stat
    {
        public int id { get; set; }
        public double hunger { get; set; }
        public double thirst { get; set; }
        public double mood { get; set; }
        public double sleepiness { get; set; }
        public double beauty { get; set; }
        public double health { get; set; }

        public double Act(double x, double add)
        {
            return x + add;
        }
    }
}
