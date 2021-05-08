using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    class Shirt : Garment
    {
        public bool ShortSleeves { get => _shortSleeves; set =>  _shortSleeves = value; }
        public bool MandarinCollar { get => _mandarinCollar; set => _mandarinCollar = value; }

        bool _shortSleeves, _mandarinCollar;

        public Shirt(int stock, bool shortSleeves = false, bool mandarinCollar = false) : base(stock)
        {
            _shortSleeves = shortSleeves;
            _mandarinCollar = mandarinCollar;
            _name = "Camisa";
            _details = _details + ((_shortSleeves) ? ", mangas cortas" : ", mangas largas") 
                                + ((_mandarinCollar) ? ", cuello mao" : ", cuello comun");

        }

    }
}
