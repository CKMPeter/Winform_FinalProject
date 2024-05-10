using FinalProject_WinForm.C_;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_WinForm
{
    public partial class UCMyProduct : UserControl
    {
        FormEntry logIn = Program.logIn;
        private string productName;
        private string productQuantity;
        private Image productImage;
        private Items items;
        private string price;
        public string ProductName { get { return productName; } set { productName = value; lbItemName.Text = value; } }
        public string ProductQuantity { get { return productQuantity; } set { productQuantity = value; lbItemQuantity.Text = value; } }
        public Image ProductImage { get { return productImage; } set { productImage = value; pbItemPicture.Image = value; } }
        public Items items_ { get { return items; } set { items = value; } }
        public string Price { get { return price; } set { price = value; lbPrice.Text = price; } }
        public UCMyProduct(Items A)
        {
            this.items = A;
            InitializeComponent();
        }

        private void pbMoreInfo_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            var item = new ItemsDetail(this.items);
            item.Closed += (s, args) => ((Form)this.TopLevelControl).Close(); ;
            item.Show();
        }

        private void pbDelete_Click(object sender, EventArgs e)
        {
            if (((Form)this.TopLevelControl).GetType().Name == "MyCart")
            {
                ConfirmBox newForm = new ConfirmBox(logIn.homePage.user, this.items);
                newForm.Show();
            }
            else
            {
                //((Form)this.TopLevelControl).Hide();
                logIn.homePage.myProduct.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
                logIn.homePage.myProduct.Show();
            }
        }

        private void UCMyProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
