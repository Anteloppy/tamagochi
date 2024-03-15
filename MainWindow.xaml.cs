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
using tamagochi.pages;

namespace tamagochi
{
    //https://www.flaticon.com/ru/packs/cat-smiley
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PetPage pp = new PetPage();
            pp.cat1.Visibility = Visibility.Visible;
            pp.cat21.Visibility = Visibility.Hidden;
            PetFrame.Navigate(new PetPage());
            MenuFrame.Navigate(new pages.Menu());
        }
    }
}
