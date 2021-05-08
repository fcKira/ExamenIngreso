using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    class Seller
    {
        int _id;
        string _name, _surname;

        List<Price> _salesList;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public List<Price> SalesList { get => _salesList; }

        public Seller(int id, string name, string surname)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _salesList = new List<Price>();
        }

        public void AddNewPrice(Price newPrice)
        {
            newPrice.SetID(_salesList.Count).SetSellerID(_id);
            _salesList.Add(newPrice);
        }
    }
}
