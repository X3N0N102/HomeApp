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
using System.Threading;

namespace HomeApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Sätter variabler name och pass som sparar inloggningsuppgifterna
                string name = usrName.Text.Trim().ToLower();
                string pass = psw.Text.Trim();
                //kollar igenom users i databasen och kollar om användernamnet och lösenordet matchar med något av dem
                foreach (DataRow row in Main.db.Query($"SELECT * FROM users WHERE name='{name}'").Rows)
                {
                    //om lösenordet är rätt loggas du in
                    if (pass == row["password"].ToString())
                    {
                        MainWindow.instance.loggedIn = true;
                        this.Close();
                        MessageBox.Show("Correct");
                        foreach (DataRow id_rows in Main.db.Query("SELECT id FROM users WHERE name='" + name + "'").Rows)
                        {
                            Main.user = new User(name, int.Parse(id_rows["id"].ToString()));
                        }

                        return;
                    }
                    else
                    {
                        //annars får du ett felmedelande som säger incorrect
                        MessageBox.Show("Incorrect");
                        return;
                    }
                }
                //om användernamnet är fel så berättar den det
                MessageBox.Show("Username not found!");
            }
            catch(Exception _e)
            {
                MessageBox.Show(_e.Message);
            }
        }

        private void WindowClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pswKeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
