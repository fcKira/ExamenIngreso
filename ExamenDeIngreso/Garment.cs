using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    abstract class Garment
    {
        public enum GarmentQuality
        {
            Standard,
            Premium
        }


        protected GarmentQuality _quality;
        protected string _name;
        protected string _details;
        protected double _price;
        protected int _stock;

        public GarmentQuality Quality { get => _quality; set => _quality = value; }
        public double Price { get => _price; set => _price = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public string Name { get => _name; }
        public string Details { get => _details; }

        public Garment(int stock)
        {
            _stock = stock;
        }
    }
}
