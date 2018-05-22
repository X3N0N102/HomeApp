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
            GetStuff("fridge");

        }

        private void GetStuff(string cabinetName)
        {

            try
            {
                MessageBox.Show(Main.user.Cabinets[cabinetName].stuffs.Count.ToString());
                foreach (var c in Main.user.Cabinets[cabinetName].stuffs)
                {
                    string stuffname = c.Key;
                    string sustainability = c.Value;
                    MessageBox.Show(stuffname + " - " + sustainability);

                    stuffList.Items.Add(stuffname);

                }
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
            }

        }

    }
}
