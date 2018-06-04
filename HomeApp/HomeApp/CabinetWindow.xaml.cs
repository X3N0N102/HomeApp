using System;
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
    /// Interaction logic for CabinetWindow.xaml
    /// </summary>
    public partial class CabinetWindow : Window
    {
        
        public CabinetWindow()
        {
            InitializeComponent();

            UpdateStuffs();

        }
        //Gör att man lägger till sakerna som skrivs i name och sust textbaren i databasen
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Main.db.Query($"INSERT INTO stuff (Name, Sustainability, cabinetID) VALUES ('{addStuffName.Text}', '{addSustDate.Text}', {Main.user.ID})");

            await UpdateStuffs();
        }

        //Uppdaterar listan som finns i cabinet när nya saker tillkommer
        private async Task<string> UpdateStuffs()
        {
            Main.user.UpdateInformation();
            stuffList.Items.Clear();
            foreach (var t in Main.user.GetStuff("cabinet"))
            {
                await Task<string>.Run(() =>
                {
                    stuffList.Dispatcher.Invoke(() =>
                    {
                        stuffList.Items.Add(t.Key);
                    });
                    return t.Key;
                });
            }
            return null;
        }
    }
}
