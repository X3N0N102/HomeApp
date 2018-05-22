﻿using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace HomeApp
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        
        public HomePage(int userId)
        {
            InitializeComponent();
            GetCabinets(userId);

        }

        private void GetCabinets(int userId)
        {

            try
            {

                foreach (DataRow row in Main.db.Query("SELECT * FROM cabinet WHERE ID='" + Main.user.ID + "' ").Rows)
                {
                    string cabinetType = row["type"].ToString();
                }
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }

        }

        private void cabinetEnter(object sender, MouseButtonEventArgs e)
        {
            CabinetWindow cabinet = new CabinetWindow();
            cabinet.Closed += (s, args) => this.Close();
            cabinet.Show();
            this.Hide();
        }
    }
}
