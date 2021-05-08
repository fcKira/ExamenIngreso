using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDeIngreso
{
    class CalculationsController
    {
        public double CheckShirtStock(List<Garment> clothesList, bool shortSleeves, bool mandarinCollar)
        {
            return clothesList.OfType<Shirt>().Where(x => x.ShortSleeves == shortSleeves && x.MandarinCollar == mandarinCollar)
                                              .Select(x => x.Stock)
                                              .FirstOrDefault();
        }

        public double CheckTrousersStock(List<Garment> clothesList, bool skinny)
        {
            return clothesList.OfType<Trousers>().Where(x => x.Common == !skinny)
                                              .Select(x => x.Stock)
                                              .FirstOrDefault();
        }

        public void MakePrice(Seller seller, List<Garment> clothesList, bool premium, double garmentPrice, int units, params object[] garmentSelected)
        {

            double finalGarmentPrice;

            Garment garment;

            if ((bool)garmentSelected[0])
            {
                finalGarmentPrice = garmentPrice - ((bool)garmentSelected[1] ? garmentPrice * 0.1f : 0) + ((bool)garmentSelected[2] ? garmentPrice * 0.03f : 0);
                garment = clothesList.OfType<Shirt>().Where(x => x.ShortSleeves == (bool)garmentSelected[1] && x.MandarinCollar == (bool)garmentSelected[2]).First();
            }
            else
            {
                finalGarmentPrice = garmentPrice - ((bool)garmentSelected[3] ? garmentPrice * 0.12f : 0);
                garment = clothesList.OfType<Trousers>().Where(x => x.Common == !(bool)garmentSelected[3]).First();
            }

            finalGarmentPrice += (premium ? garmentPrice * 0.3f : 0);

            finalGarmentPrice = finalGarmentPrice * units;

            garment.Price = garmentPrice;

            Price price = new Price(finalGarmentPrice, units, garment);

            seller.AddNewPrice(price);
        }

        public string ShowPrices(Seller seller)
        {
            string toReturn = "";

            foreach (Price pr in seller.SalesList)
            {
                toReturn +=
                    $@"ID de Cotizacion: {pr.Id}
Fecha: {pr.DateTime.ToString()}
ID del vendedor: {pr.SellerId}
Prenda cotizada: {pr.Garment.Name + pr.Garment.Details }
Cantidad de unidades: {pr.Units}
Precio final: {pr.FinalPrice}
-
";
            }

            return toReturn;
        }
    }
}
