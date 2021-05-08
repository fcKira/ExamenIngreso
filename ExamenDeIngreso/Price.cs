using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    class Price
    {
        int _id;
        DateTime _dateTime;
        int _sellerId;
        Garment _garment;
        int _units;
        double _finalPrice;
        public int Id { get => _id; }
        public DateTime DateTime { get => _dateTime; }
        public int SellerId { get => _sellerId; }
        public int Units { get => _units;}
        public double FinalPrice { get => _finalPrice; }
        internal Garment Garment { get => _garment;}

        public Price(double finalPrice, int units, Garment garment)
        {
            _dateTime = DateTime.Now;
            _garment = garment;
            _units = units;
            _finalPrice = finalPrice;
        }


        public Price SetID(int id)
        {
            _id = id;
            return this;
        }

        public Price SetSellerID(int sellerID)
        {
            _sellerId = sellerID;
            return this;
        }
    }
}
