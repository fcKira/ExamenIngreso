using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    class Store
    {
        string _name;
        string _address;

        List<Garment> _clothesList;
        internal List<Garment> ClothesList { get => _clothesList; }

        public Store(string name, string address, List<Garment> clothesList)
        {
            _name = name;
            _address = address;
            _clothesList = clothesList;
        }

    }
}
