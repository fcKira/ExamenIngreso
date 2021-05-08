
namespace ExamenDeIngreso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.shirtCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shortSleevesCheckBox = new System.Windows.Forms.CheckBox();
            this.mandarinCollarCheckBox = new System.Windows.Forms.CheckBox();
            this.trousersCheckBox = new System.Windows.Forms.CheckBox();
            this.skinnyCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stockLabel = new System.Windows.Forms.Label();
            this.garmentQuality = new System.Windows.Forms.Label();
            this.standardQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.premiumQualityCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.priceButton = new System.Windows.Forms.Button();
            this.pricesTextBox = new System.Windows.Forms.TextBox();
            this.showPricesButton = new System.Windows.Forms.Button();
            this.storeNameLabel = new System.Windows.Forms.Label();
            this.storeAddressLabel = new System.Windows.Forms.Label();
            this.nameSellerLabel = new System.Windows.Forms.Label();
            this.idSellerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shirtCheckBox
            // 
            this.shirtCheckBox.AutoSize = true;
            this.shirtCheckBox.Location = new System.Drawing.Point(27, 91);
            this.shirtCheckBox.Name = "shirtCheckBox";
            this.shirtCheckBox.Size = new System.Drawing.Size(60, 17);
            this.shirtCheckBox.TabIndex = 0;
            this.shirtCheckBox.Text = "Camisa";
            this.shirtCheckBox.UseVisualStyleBackColor = true;
            this.shirtCheckBox.CheckedChanged += new System.EventHandler(this.shirtCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prenda";
            // 
            // shortSleevesCheckBox
            // 
            this.shortSleevesCheckBox.AutoSize = true;
            this.shortSleevesCheckBox.Enabled = false;
            this.shortSleevesCheckBox.Location = new System.Drawing.Point(109, 91);
            this.shortSleevesCheckBox.Name = "shortSleevesCheckBox";
            this.shortSleevesCheckBox.Size = new System.Drawing.Size(96, 17);
            this.shortSleevesCheckBox.TabIndex = 2;
            this.shortSleevesCheckBox.Text = "Mangas cortas";
            this.shortSleevesCheckBox.UseVisualStyleBackColor = true;
            this.shortSleevesCheckBox.CheckedChanged += new System.EventHandler(this.shortSleevesCheckBox_CheckedChanged);
            // 
            // mandarinCollarCheckBox
            // 
            this.mandarinCollarCheckBox.AutoSize = true;
            this.mandarinCollarCheckBox.Enabled = false;
            this.mandarinCollarCheckBox.Location = new System.Drawing.Point(211, 91);
            this.mandarinCollarCheckBox.Name = "mandarinCollarCheckBox";
            this.mandarinCollarCheckBox.Size = new System.Drawing.Size(79, 17);
            this.mandarinCollarCheckBox.TabIndex = 3;
            this.mandarinCollarCheckBox.Text = "Cuello Mao";
            this.mandarinCollarCheckBox.UseVisualStyleBackColor = true;
            this.mandarinCollarCheckBox.CheckedChanged += new System.EventHandler(this.mandarinCollarCheckBox_CheckedChanged);
            // 
            // trousersCheckBox
            // 
            this.trousersCheckBox.AutoSize = true;
            this.trousersCheckBox.Location = new System.Drawing.Point(27, 131);
            this.trousersCheckBox.Name = "trousersCheckBox";
            this.trousersCheckBox.Size = new System.Drawing.Size(68, 17);
            this.trousersCheckBox.TabIndex = 4;
            this.trousersCheckBox.Text = "Pantalon";
            this.trousersCheckBox.UseVisualStyleBackColor = true;
            this.trousersCheckBox.CheckedChanged += new System.EventHandler(this.trousersCheckBox_CheckedChanged);
            // 
            // skinnyCheckBox
            // 
            this.skinnyCheckBox.AutoSize = true;
            this.skinnyCheckBox.Enabled = false;
            this.skinnyCheckBox.Location = new System.Drawing.Point(109, 131);
            this.skinnyCheckBox.Name = "skinnyCheckBox";
            this.skinnyCheckBox.Size = new System.Drawing.Size(70, 17);
            this.skinnyCheckBox.TabIndex = 5;
            this.skinnyCheckBox.Text = "Chupines";
            this.skinnyCheckBox.UseVisualStyleBackColor = true;
            this.skinnyCheckBox.CheckedChanged += new System.EventHandler(this.skinnyCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Unidades de stock disponibles:";
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(176, 181);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(13, 13);
            this.stockLabel.TabIndex = 7;
            this.stockLabel.Text = "0";
            // 
            // garmentQuality
            // 
            this.garmentQuality.AutoSize = true;
            this.garmentQuality.Location = new System.Drawing.Point(24, 222);
            this.garmentQuality.Name = "garmentQuality";
            this.garmentQuality.Size = new System.Drawing.Size(94, 13);
            this.garmentQuality.TabIndex = 8;
            this.garmentQuality.Text = "Calidad de Prenda";
            // 
            // standardQualityCheckBox
            // 
            this.standardQualityCheckBox.AutoSize = true;
            this.standardQualityCheckBox.Location = new System.Drawing.Point(27, 261);
            this.standardQualityCheckBox.Name = "standardQualityCheckBox";
            this.standardQualityCheckBox.Size = new System.Drawing.Size(69, 17);
            this.standardQualityCheckBox.TabIndex = 9;
            this.standardQualityCheckBox.Text = "Standard";
            this.standardQualityCheckBox.UseVisualStyleBackColor = true;
            this.standardQualityCheckBox.CheckedChanged += new System.EventHandler(this.standardQualityCheckBox_CheckedChanged);
            // 
            // premiumQualityCheckBox
            // 
            this.premiumQualityCheckBox.AutoSize = true;
            this.premiumQualityCheckBox.Location = new System.Drawing.Point(134, 261);
            this.premiumQualityCheckBox.Name = "premiumQualityCheckBox";
            this.premiumQualityCheckBox.Size = new System.Drawing.Size(66, 17);
            this.premiumQualityCheckBox.TabIndex = 10;
            this.premiumQualityCheckBox.Text = "Premium";
            this.premiumQualityCheckBox.UseVisualStyleBackColor = true;
            this.premiumQualityCheckBox.CheckedChanged += new System.EventHandler(this.premiumQualityCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Precio unitario y cantidad";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(40, 340);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(66, 20);
            this.priceTextBox.TabIndex = 12;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(134, 340);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(66, 20);
            this.quantityTextBox.TabIndex = 13;
            this.quantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "u.";
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(85, 387);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(75, 23);
            this.priceButton.TabIndex = 17;
            this.priceButton.Text = "Cotizar";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // pricesTextBox
            // 
            this.pricesTextBox.Location = new System.Drawing.Point(296, 30);
            this.pricesTextBox.Multiline = true;
            this.pricesTextBox.Name = "pricesTextBox";
            this.pricesTextBox.ReadOnly = true;
            this.pricesTextBox.Size = new System.Drawing.Size(292, 395);
            this.pricesTextBox.TabIndex = 18;
            // 
            // showPricesButton
            // 
            this.showPricesButton.Location = new System.Drawing.Point(214, 30);
            this.showPricesButton.Name = "showPricesButton";
            this.showPricesButton.Size = new System.Drawing.Size(75, 42);
            this.showPricesButton.TabIndex = 19;
            this.showPricesButton.Text = "Show/Hide prices";
            this.showPricesButton.UseVisualStyleBackColor = true;
            this.showPricesButton.Click += new System.EventHandler(this.showPricesButton_Click);
            // 
            // storeNameLabel
            // 
            this.storeNameLabel.AutoSize = true;
            this.storeNameLabel.Location = new System.Drawing.Point(21, 9);
            this.storeNameLabel.Name = "storeNameLabel";
            this.storeNameLabel.Size = new System.Drawing.Size(22, 13);
            this.storeNameLabel.TabIndex = 20;
            this.storeNameLabel.Text = "Bla";
            // 
            // storeAddressLabel
            // 
            this.storeAddressLabel.AutoSize = true;
            this.storeAddressLabel.Location = new System.Drawing.Point(115, 9);
            this.storeAddressLabel.Name = "storeAddressLabel";
            this.storeAddressLabel.Size = new System.Drawing.Size(22, 13);
            this.storeAddressLabel.TabIndex = 21;
            this.storeAddressLabel.Text = "Ble";
            // 
            // nameSellerLabel
            // 
            this.nameSellerLabel.AutoSize = true;
            this.nameSellerLabel.Location = new System.Drawing.Point(21, 30);
            this.nameSellerLabel.Name = "nameSellerLabel";
            this.nameSellerLabel.Size = new System.Drawing.Size(13, 13);
            this.nameSellerLabel.TabIndex = 22;
            this.nameSellerLabel.Text = "b";
            // 
            // idSellerLabel
            // 
            this.idSellerLabel.AutoSize = true;
            this.idSellerLabel.Location = new System.Drawing.Point(115, 30);
            this.idSellerLabel.Name = "idSellerLabel";
            this.idSellerLabel.Size = new System.Drawing.Size(41, 13);
            this.idSellerLabel.TabIndex = 23;
            this.idSellerLabel.Text = "label10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.idSellerLabel);
            this.Controls.Add(this.nameSellerLabel);
            this.Controls.Add(this.storeAddressLabel);
            this.Controls.Add(this.storeNameLabel);
            this.Controls.Add(this.showPricesButton);
            this.Controls.Add(this.pricesTextBox);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.premiumQualityCheckBox);
            this.Controls.Add(this.standardQualityCheckBox);
            this.Controls.Add(this.garmentQuality);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skinnyCheckBox);
            this.Controls.Add(this.trousersCheckBox);
            this.Controls.Add(this.mandarinCollarCheckBox);
            this.Controls.Add(this.shortSleevesCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shirtCheckBox);
            this.Name = "Form1";
            this.Text = "Cotizador Express";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox shirtCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox shortSleevesCheckBox;
        private System.Windows.Forms.CheckBox mandarinCollarCheckBox;
        private System.Windows.Forms.CheckBox trousersCheckBox;
        private System.Windows.Forms.CheckBox skinnyCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label garmentQuality;
        private System.Windows.Forms.CheckBox standardQualityCheckBox;
        private System.Windows.Forms.CheckBox premiumQualityCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.TextBox pricesTextBox;
        private System.Windows.Forms.Button showPricesButton;
        private System.Windows.Forms.Label storeNameLabel;
        private System.Windows.Forms.Label storeAddressLabel;
        private System.Windows.Forms.Label nameSellerLabel;
        private System.Windows.Forms.Label idSellerLabel;
    }
}

