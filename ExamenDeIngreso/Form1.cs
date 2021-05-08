using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenDeIngreso
{
    public partial class Form1 : Form
    {
        Store _myStore;
        Seller _mySeller;
        double _currentGarmentStock;
        CalculationsController _myCalculator;

        public Form1()
        {
            InitializeComponent();

            pricesTextBox.Hide();

            Random r = new Random();
            string sellerName = "Franco";
            string sellerSurname = "Correia";
            int sellerID = r.Next(0, 100);
            _mySeller = new Seller(sellerID, sellerName, sellerSurname);
            nameSellerLabel.Text = sellerName + " " + sellerSurname;
            idSellerLabel.Text = sellerID.ToString();
            
            List<Garment> stocks = new List<Garment>();
            stocks.Add(new Shirt(stock: 200, shortSleeves: true, mandarinCollar: true));
            stocks.Add(new Shirt(stock: 300, shortSleeves: true, mandarinCollar: false));
            stocks.Add(new Shirt(stock: 150, shortSleeves: false, mandarinCollar: true));
            stocks.Add(new Shirt(stock: 350, shortSleeves: false, mandarinCollar: false));
            stocks.Add(new Trousers(stock: 1500, common: false));
            stocks.Add(new Trousers(stock: 500, common: true));

            string storeName = "Bla Store";
            string storeAddress = "742 Evergreen Terrace";
            _myStore = new Store(storeName, storeAddress, stocks);
            storeNameLabel.Text = storeName;
            storeAddressLabel.Text = storeAddress;

            //var asd = stocks.OfType<Shirt>().Where(x => x.ShortSleeves && x.MandarinCollar).FirstOrDefault();
            //priceTextBox.Text = asd.Stock.ToString();

            _myCalculator = new CalculationsController();
        }

        private void shirtCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            //Prendo las opciones de Camisa
            shortSleevesCheckBox.Enabled = mandarinCollarCheckBox.Enabled = shirtCheckBox.Checked;
            //Apago la opcion de Patanalon
            trousersCheckBox.Enabled = !shirtCheckBox.Checked;

            if (!shirtCheckBox.Checked)
                _currentGarmentStock = 0;
            else
                _currentGarmentStock = _myCalculator.CheckShirtStock(_myStore.ClothesList, shortSleevesCheckBox.Checked, mandarinCollarCheckBox.Checked);

            stockLabel.Text = _currentGarmentStock.ToString();
        }

        private void trousersCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            //Prendo las opciones de Pantalon
            skinnyCheckBox.Enabled = trousersCheckBox.Checked;
            //Apago la opcion de Camisa
            shirtCheckBox.Enabled = !trousersCheckBox.Checked;

            if (!trousersCheckBox.Checked)
                _currentGarmentStock = 0;
            else
                _currentGarmentStock = _myCalculator.CheckTrousersStock(_myStore.ClothesList, skinnyCheckBox.Checked);

            stockLabel.Text = _currentGarmentStock.ToString();
        }
        private void shortSleevesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentGarmentStock = _myCalculator.CheckShirtStock(_myStore.ClothesList, shortSleevesCheckBox.Checked, mandarinCollarCheckBox.Checked);
            stockLabel.Text = _currentGarmentStock.ToString();
        }

        private void mandarinCollarCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _currentGarmentStock = _myCalculator.CheckShirtStock(_myStore.ClothesList, shortSleevesCheckBox.Checked, mandarinCollarCheckBox.Checked);
            stockLabel.Text = _currentGarmentStock.ToString();
        }

        private void skinnyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            stockLabel.Text = _myCalculator.CheckTrousersStock(_myStore.ClothesList, skinnyCheckBox.Checked).ToString();
        }

        private void standardQualityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            premiumQualityCheckBox.Checked = !standardQualityCheckBox.Checked;
        }

        private void premiumQualityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            standardQualityCheckBox.Checked = !premiumQualityCheckBox.Checked;
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (priceTextBox.Text == "")
            {
                priceTextBox.BackColor = Color.White;
            }
            else
            {
                Utilities.CheckPositiveNumbers(() => double.Parse(priceTextBox.Text) < 0,
                                              () =>
                                              {
                                                  priceTextBox.BackColor = Color.White;
                                              },
                                              () =>
                                              {
                                                  priceTextBox.BackColor = Color.Orange;
                                              });

            }
            
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                quantityTextBox.BackColor = Color.White;
            }
            else
            {
                Utilities.CheckPositiveNumbers(() => double.Parse(quantityTextBox.Text) < 0 || double.Parse(quantityTextBox.Text) > _currentGarmentStock,
                                              () =>
                                              {
                                                  quantityTextBox.BackColor = Color.White;
                                                  
                                              },
                                              () =>
                                              {
                                                  quantityTextBox.BackColor = Color.Orange;
                                              });

            }

        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            if ((shirtCheckBox.Checked || trousersCheckBox.Checked) &&
                (standardQualityCheckBox.Checked || premiumQualityCheckBox.Checked) &&
                (priceTextBox.BackColor == Color.White && quantityTextBox.BackColor == Color.White))
            {
                _myCalculator.MakePrice(seller: _mySeller,
                                        clothesList: _myStore.ClothesList, 
                                        premium: premiumQualityCheckBox.Checked, 
                                        garmentPrice: double.Parse(priceTextBox.Text), 
                                        units: int.Parse(quantityTextBox.Text), 
                                        shirtCheckBox.Checked, shortSleevesCheckBox.Checked, mandarinCollarCheckBox.Checked, skinnyCheckBox.Checked);

                pricesTextBox.Show();
                pricesTextBox.Text = _myCalculator.ShowPrices(_mySeller);
            }
            else
            {
                MessageBox.Show("No se puede realizar la cotizacion. Chequee los campos");
            }
        }

        private void showPricesButton_Click(object sender, EventArgs e)
        {
            if (pricesTextBox.Visible)
            {
                pricesTextBox.Text = "";
                pricesTextBox.Hide();
            }
            else
            {
                pricesTextBox.Show();
                pricesTextBox.Text = _myCalculator.ShowPrices(_mySeller);
            }
        }
    }
}
