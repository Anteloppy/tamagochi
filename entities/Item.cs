using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

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

        public SolidColorBrush status_color
        {
            get
            {
                switch (status) {
                    case "в продаже": return Brushes.Green; break;
                    case "продано": return Brushes.Red; break;
                    default: return Brushes.Blue; break;
                }
            }
        }
    }
}
