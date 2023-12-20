using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
using System.Windows.Threading;
using tamagochi.methods;

namespace tamagochi.pages
{
    /// <summary>
    /// Логика взаимодействия для TopMenu.xaml
    /// </summary>
    public partial class TopMenu : Page
    {
        private DispatcherTimer timer;
        public TopMenu()
        {
            InitializeComponent();
            var metod = new StatUpdate();
            metod.Update();
            StatView();
        }
        Stat stat = new Stat
        {
            id = 1,
            hunger = 100,
            thirst = 100,
            mood = 100,
            sleepiness = 100,
            beauty = 0,
            health = 100
        };
        public void StatView()
        {
            StatHunger.Value = stat.hunger;
            StatThirst.Value = stat.thirst;
            StatMood.Value = stat.mood;
            StatSleepnes.Value = stat.sleepiness;
            StatBeauty.Value = stat.beauty;
            StatHealth.Value = stat.health;
        }
    }
}
