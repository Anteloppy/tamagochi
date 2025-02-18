﻿using MySql.Data.MySqlClient;
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

namespace tamagochi
{
    /// <summary>
    /// Логика взаимодействия для InventoryPage.xaml
    /// </summary>
    public partial class InventoryPage : Page
    {
        public InventoryPage()
        {
            InitializeComponent();
            LoadData(select);
        }
        private static string connectionString = "server=localhost; port=3306; database=tamagochi; user=root; password=Nimda123;";
        string select = "select i.id, i.name, p.name as property, i.count, i.price, s.name as status,  i.in_inventory, i.picture from items as i join statuses as s on i.status = s.id join properties as p on i.property = p.id;";
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
                        record.property = reader.GetString("property");
                        record.count = reader.GetInt32("count");
                        record.price = reader.GetInt32("price");
                        record.status = reader.GetString("status");
                        record.in_inventory = reader.GetBoolean("in_inventory");
                        record.picture = "/res/" + reader.GetString("picture");
                        if (record.in_inventory == true)
                        items.Add(record);
                    }
                }
            };
            LBItems.ItemsSource = items;
        }

        private void LBItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            Item si = (Item)listBox.SelectedItem;
            string status = si.status;
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if (listBox.SelectedItem != null & si.in_inventory == true)
            {
                MessageBoxResult result = MessageBox.Show("Использовать?", "Подтверждение", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    int id = si.id;
                    string use = "update items set in_inventory = false where id = @id; commit;";
                    MySqlConnection conn = new MySqlConnection(connectionString);
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(use, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("предмет использован");
                    mainWindow.UseItem(si.property, si.count);
                    LoadData(select);
                }
            }
        }
    }
}
