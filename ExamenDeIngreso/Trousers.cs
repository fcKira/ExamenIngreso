using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    class Trousers : Garment
    {
        public bool Common { get => _common; set => _common = value; }
        bool _common;

        public Trousers(int stock, bool common = false) : base(stock)
        {
            _common = common;
            _name = "Pantalon";
            _details = _details + ((Common) ? ", comun" : ", chupin");
        }

    }
}
