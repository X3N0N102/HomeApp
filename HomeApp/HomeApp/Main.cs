using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace HomeApp
{
    public static class Main
    {
        public static Database db;
        public static User user;


        public static void Init()
        {
            new Thread(() =>
            {
                try
                {
                    db = new Database("153.92.210.52", "alexdesign", "alex", "abbore16");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }).Start();
        }

    }
}
