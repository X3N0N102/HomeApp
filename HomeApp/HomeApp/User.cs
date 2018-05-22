using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeApp
{
    public struct CabinetStuffs
    {
        public Dictionary<string, string> stuffs;
        public int cabinetID;

        public CabinetStuffs(string name, string sustainability, int cabinetID)
        {
            this.stuffs = new Dictionary<string, string>();
            this.cabinetID = cabinetID;
            this.Add(name, sustainability);

        }

        public void Add(string key, string value)
        {
            if (this.stuffs.ContainsKey(key))
            {
                this.stuffs[key] = value;
            }
        }
    }

    public class User
    {

        string name;
        int id;
        Dictionary<string, CabinetStuffs> cabinets;

        public Dictionary<string, CabinetStuffs> Cabinets { get => cabinets; set => cabinets = value; }
        public int ID { get => id; set => id = value; }


        public User(string name, int id)
        {
            this.name = name;
            this.id = id;
            this.Cabinets = new Dictionary<string, CabinetStuffs>();
            foreach (DataRow cab_row in Main.db.Query("SELECT * FROM cabinet WHERE usrID='" + this.id + "'").Rows)
            {
                foreach (DataRow stuff_row in Main.db.Query("SELECT * FROM stuff WHERE cabinetID='" + cab_row["ID"] + "'").Rows)
                {
                    CabinetStuffs stuff = new CabinetStuffs(stuff_row["Name"].ToString(), stuff_row["Sustainability"].ToString(), int.Parse(cab_row["ID"].ToString()));
                    this.Cabinets[cab_row["type"].ToString()] = stuff;
                    MessageBox.Show("Type: " + cab_row["type"].ToString() + " | " + stuff_row["Name"].ToString());
                }
            }
        }

    }
}
