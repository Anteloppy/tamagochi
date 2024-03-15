﻿using System;
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
using System.Windows.Threading;
using tamagochi.entities;

namespace tamagochi.pages
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Stat stat;
        private DispatcherTimer needTimer;
        public bool shop_open = false;
        public Menu()
        {
            InitializeComponent();
            ShopFrame.Navigate(new ShopPage());

            stat = new Stat { hunger = 100, thirst = 100, mood = 100, sleepiness = 100, beauty = 0, health = 100 };

            needTimer = new DispatcherTimer();
            needTimer.Interval = TimeSpan.FromSeconds(1);
            needTimer.Tick += DeclineNeeds;
            needTimer.Start();
        }

        public void DeclineNeeds(object sender, EventArgs e)
        {
            StatHunger.Value = stat.hunger -= 1;
            StatThirst.Value = stat.thirst -= 2;
            StatMood.Value = stat.mood -= 0.5;
            StatSleepnes.Value = stat.sleepiness -= 0.2;
            if (stat.hunger <= 0 || stat.thirst <= 0 || stat.mood <= 0 || stat.sleepiness <= 0) stat.health -= 10;
            else if (stat.hunger <= 20 || stat.thirst <= 20 || stat.mood <= 20 || stat.sleepiness <= 20) stat.health -= 1;
            StatHealth.Value = stat.health;

            if (stat.hunger <= 30) Feed.Background = Brushes.Red;
            else if (stat.hunger <= 50) Feed.Background = Brushes.Yellow;
            else Feed.Background = Brushes.LightGray;
            if (stat.thirst <= 30) Drink.Background = Brushes.Red;
            else if (stat.thirst <= 50) Drink.Background = Brushes.Yellow;
            else Drink.Background = Brushes.LightGray;
            if (stat.mood <= 30) Play.Background = Brushes.Red;
            else if (stat.mood <= 50) Play.Background = Brushes.Yellow;
            else Play.Background = Brushes.LightGray;
            if (stat.sleepiness <= 30) Put.Background = Brushes.Red;
            else if (stat.sleepiness <= 50) Put.Background = Brushes.Yellow;
            else Put.Background = Brushes.LightGray;
            Cutie.Background = Brushes.Gray;
            if (stat.health <= 30) Heal.Background = Brushes.Red;
            else if (stat.health <= 50) Heal.Background = Brushes.Yellow;
            else Heal.Background = Brushes.LightGray;
        }

        private void Feed_Click(object sender, RoutedEventArgs e)
        {
            stat.hunger += 25;
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

        private void Cutie_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ShopButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            switch (shop_open)
            {
                case false:
                    ShopFrame.Visibility = Visibility.Visible;
                    shop_open = true;
                    break;
                case true:
                    ShopFrame.Visibility = Visibility.Hidden;
                    shop_open = false;
                    break;
            }
        }
    }
}
