using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApp
{
    interface IType
    {
        Dictionary<string, string> Stuffs { get; set; }
        void Add(string key, string value);

    }
}
