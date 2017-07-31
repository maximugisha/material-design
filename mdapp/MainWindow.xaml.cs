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
using MahApps.Metro.Controls;
//using System;
//using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace mdapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("server = localhost; user = Maximo; database = login_database; port = 3306; password = 'UPbeat123';");
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT `username`, `password` FROM `login_table` WHERE `username` = '" + email_txt.Text + "' AND `password` = '" + password_txt.Text + "'", connection);

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                NavigationWindow window = new NavigationWindow();
                window.Source = new Uri("welcome.xaml", UriKind.Relative);
                window.Show();
                this.Close();
            }
            else
            {

            }
            connection.Close();
        }
    }
}