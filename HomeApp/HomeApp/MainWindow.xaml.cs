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
using System.Data;

namespace HomeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool loggedIn;
        public static MainWindow instance;

        public MainWindow()
        {
            InitializeComponent();
            instance = this;
            try
            {
                Main.Init();

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void HomeButton(object sender, MouseButtonEventArgs e)
        {
            if (loggedIn)
            {
                HomePage homePage = new HomePage(1);
                homePage.Closed += (s, args) => this.Close();
                homePage.Show();
                this.Hide();
            }else
            {
                LoginWindow login = new LoginWindow();
                this.Closed += (s, args) => login.Close();
                login.Show();
            }
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
            Settings settings = new Settings();
            this.Closed += (s, args) => settings.Close();
            settings.Show();
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
           
        }

        private void UsrEnter(object sender, MouseEventArgs e)
        {

        }

        private void UsrLeave(object sender, MouseEventArgs e)
        {

        }

        private void UsrButton(object sender, MouseButtonEventArgs e)
        {
            if (!loggedIn)
            {
                LoginWindow login = new LoginWindow();
                this.Closed += (s, args) => login.Close();
                login.Show();
            }
            else
            {
                MessageBox.Show("You're already logged in!");
            }
        }
    }
}
