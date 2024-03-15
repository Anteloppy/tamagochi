using MySql.Data.MySqlClient;
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
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public ShopPage()
        {
            InitializeComponent();
            LoadData("select i.id, i.name, i.price, s.name as status,  i.in_inventory, i.picture from items as i join statuses as s on i.status = s.id");
        }
        private static string connectionString = "server=localhost; port=3306; database=tamagochi; user=root; password=Nimda123;";
        public void LoadData(string sql)
        {
            List<Item> items = new List<Item>();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Item record = new Item();
                        record.id = reader.GetInt32("id");
                        record.name = reader.GetString("name");
                        record.price = reader.GetInt32("price");
                        record.status = reader.GetString("status");
                        record.in_inventory = reader.GetBoolean("in_inventory");
                        record.picture = "/ pages /" + reader.GetString("picture");
                        items.Add(record);
                    }
                }
            };
            LBItems.ItemsSource = items;
        }
    }
}
