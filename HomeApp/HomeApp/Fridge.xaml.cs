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
using System.Windows.Shapes;

namespace HomeApp
{
    /// <summary>
    /// Interaction logic for Fridge.xaml
    /// </summary>
    public partial class Fridge : Window
    {
        public Fridge()
        {
            InitializeComponent();
            //lägger till alla saker från databasen som tillhör användaren och fidge i listan
            foreach (var t in Main.user.GetStuff("fridge"))
            {
                stuffList.Items.Add(t.Key);
            }
        }
    }
}
