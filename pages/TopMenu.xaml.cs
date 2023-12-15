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

namespace tamagochi.pages
{
    /// <summary>
    /// Логика взаимодействия для TopMenu.xaml
    /// </summary>
    public partial class TopMenu : Page
    {
        public TopMenu()
        {
            IconThirst.Source = new BitmapImage(new Uri("ThirstIcon.png", UriKind.Relative));
            InitializeComponent();

        }
    }
}
