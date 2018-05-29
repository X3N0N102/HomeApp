using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeApp
{
    public class _
    {
        protected int id;

        public _(int id)
        {
            this.id = id;
        }
    }

    public class CabinetStuffs : _
    {
        public Dictionary<string, string> stuffs;

        public CabinetStuffs(int id) : base(id)
        {
            this.stuffs = new Dictionary<string, string>();
        }

        public void Add(string key, string value)
        {
            if (!this.stuffs.ContainsKey(key))
            {
                this.stuffs[key] = value;
            }
        }
    }

    public class User: _
    {

        string name;
        Dictionary<string, CabinetStuffs> cabinets;

        public Dictionary<string, CabinetStuffs> Cabinets { get => cabinets; set => cabinets = value; }
        public int ID { get => id; set => id = value; }

        public User(string name, int id) : base(id)
        {
            this.name = name;
            this.Cabinets = new Dictionary<string, CabinetStuffs>();
            UpdateInformation();
        }

        public void UpdateInformation()
        {
            foreach (DataRow cab_row in Main.db.Query($"SELECT * FROM cabinet WHERE usrID='{this.id}'").Rows)
            {
                int cab_id = int.Parse(cab_row["ID"].ToString());
                CabinetStuffs stuff = new CabinetStuffs(cab_id);
                this.Cabinets[cab_row["type"].ToString()] = stuff;
                foreach (DataRow stuff_row in Main.db.Query($"SELECT * FROM stuff WHERE cabinetID='{cab_row["ID"]}'").Rows)
                {
                    string stuff_name = stuff_row["Name"].ToString();
                    string stuff_sust = stuff_row["Sustainability"].ToString();
                    stuff.Add(stuff_name, stuff_sust);
                }
            }

        }

        public Dictionary<string, string> GetStuff(string cabinetName)
        {
            try
            {
                Dictionary<string, string> retList = new Dictionary<string, string>();

                foreach (var c in this.Cabinets[cabinetName].stuffs)
                {
                    string stuffname = c.Key;
                    string sustainability = c.Value;
                    retList.Add(stuffname, sustainability);

                }
                return retList;
            }
            catch (Exception _e)
            {
                MessageBox.Show(_e.Message);
                return null;
            }
        }
    }
}
