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
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace mdapp
{
    /// <summary>
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : Page
    {
        MySqlConnection connection = new MySqlConnection("server=localhost; user = Maximo; database = login_database; port = 3306; password = 'UPbeat123'; ");
        public signup()
        {
            InitializeComponent();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `user`", connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable("user");
            da.Fill(dt);
            dbtable.ItemsSource = dt.DefaultView;
            connection.Close();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        private void dbtable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
