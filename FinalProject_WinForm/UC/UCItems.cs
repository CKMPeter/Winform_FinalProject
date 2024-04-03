using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_WinForm
{
    public partial class UCItems : UserControl
    {
        private string productName;
        private string productDescription;
        private string productPrice;
        private Image productImage;
        private Items items;

        public string ProductName { get { return productName; } set { productName = value; lbProductName.Text = value; } }
        public string ProductDiscription { get { return productDescription; } set { productDescription = value; lbProductDiscription.Text = value; } }
        public string ProductPrice { get { return productPrice; } set { productPrice = value; lbProductPrice.Text = value; } }
        public Image ProductImage { get { return productImage; } set { productImage = value; pbProduct.Image = value; } }

        public UCItems(Items A)
        {
            this.items = A;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Items_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void Items_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(60, 100, 159);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            var item = new ItemsDetail(this.items);
            item.Closed += (s, args) => ((Form)this.TopLevelControl).Close(); ;
            item.Show();
        }
    }
}
