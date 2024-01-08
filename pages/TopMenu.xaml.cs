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
        public Stat stat;
        private DispatcherTimer needTimer;

        public TopMenu(Stat statInstance)
        {
            InitializeComponent();
            stat = statInstance;

            var bottomMenu = new BottomMenu(stat);
            bottomMenu.HungerIncreasedEvent += (sender, value) => IncreaseHunger(value);

            stat = new Stat { hunger = 100, thirst = 100, mood = 100, sleepiness = 100, beauty = 0, health = 100};

            needTimer = new DispatcherTimer();
            needTimer.Interval = TimeSpan.FromSeconds(1);
            needTimer.Tick += DeclineNeeds;
            needTimer.Start();

            

            //var metod = new StatUpdate();
            //metod.Update();
            //StatView();
        }

        public void DeclineNeeds(object sender, EventArgs e)
        {
            StatHunger.Value = stat.hunger -= 1;
            StatThirst.Value = stat.thirst -= 2;
            StatMood.Value = stat.mood -= 0.5;
            StatSleepnes.Value = stat.sleepiness -= 0.2;
            if (stat.hunger <= 0 || stat.thirst <= 0 || stat.mood <= 0 || stat.sleepiness <= 0) StatHealth.Value -= 10;
            else if (stat.hunger <= 20 || stat.thirst <= 20 || stat.mood <= 20 || stat.sleepiness <= 20) stat.health -= 1;
        }

        public void IncreaseHunger(int value)
        {
            stat.hunger += value;
            StatHunger.Value = stat.hunger;
        }
    }
}
