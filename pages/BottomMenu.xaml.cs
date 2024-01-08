using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using tamagochi.entities;

namespace tamagochi.pages
{
    /// <summary>
    /// Логика взаимодействия для BottomMenu.xaml
    /// </summary>
    public partial class BottomMenu : Page
    {
        public Stat stat;
        public event EventHandler<int> HungerIncreasedEvent;
        public BottomMenu(Stat statInstance)
        {
            InitializeComponent();
            stat = statInstance;
        }

        private void Feed_Click(object sender, RoutedEventArgs e)
        {
            HungerIncreasedEvent?.Invoke(this, 25);
        }

        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            stat.thirst += 25;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            stat.mood += 25;
        }

        private void Put_Click(object sender, RoutedEventArgs e)
        {
            stat.sleepiness += 25;
        }

        private void Heal_Click(object sender, RoutedEventArgs e)
        {
            stat.health += 25;
        }
    }
}
