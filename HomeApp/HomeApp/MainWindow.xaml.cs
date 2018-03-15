using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MySqlConnection connection;
        string connectionString = "SERVER=153.92.210.52;PORT=3306;DATABASE=alexdesign;UID=alex;PASSWORD=abbore16;";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomeButton(object sender, MouseButtonEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Closed += (s, args) => this.Close();
            homePage.Show();
            this.Hide();
        }

        private void HomeEnter(object sender, MouseEventArgs e)
        {
            StartButton.Effect = new System.Windows.Media.Effects.DropShadowEffect()
            {
                BlurRadius = 5,
                ShadowDepth = 3
            };
        }

        private void HomeLeave(object sender, MouseEventArgs e)
        {
            StartButton.Effect = new System.Windows.Media.Effects.DropShadowEffect()
            {
                BlurRadius = 20,
                ShadowDepth = 7
            };
        }

        private void SettingsButton(object sender, MouseButtonEventArgs e)
        {
            //Settings settings = new Settings();
            //this.Closed += (s, args) => settings.Close();
            //settings.Show();
        }

        private void SettingEnter(object sender, MouseEventArgs e)
        {
            SettingsBtn.Effect = new System.Windows.Media.Effects.DropShadowEffect()
            {
                BlurRadius = 5,
                ShadowDepth = 3
            };
        }

        private void SettingLeave(object sender, MouseEventArgs e)
        {
            SettingsBtn.Effect = new System.Windows.Media.Effects.DropShadowEffect()
            {
                BlurRadius = 20,
                ShadowDepth = 7
            };
        }

        private void LicenceEnter(object sender, MouseButtonEventArgs e)
        {
            Licence licence = new Licence();
            licence.Show();
        }

        private void usr1Enter(object sender, MouseButtonEventArgs e)
        {
            try
            {
                connection = new MySqlConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM users", connection);
                MySqlDataReader result = cmd.ExecuteReader();
                if (result.Read())
                {
                    MessageBox.Show(result.GetString(1));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
