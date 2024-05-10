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
    public partial class MyCart : Form
    {
        FormEntry logIn = Program.logIn;
        User user;
        int count = 0;
        int numberOfProdcuts = 0;
        int total = 0;
        public MyCart(User A)
        {
            this.user = A;
            InitializeComponent();
        }
        private void createList()
        {
            if (flpList.Controls.Count < 0)
            {
                flpList.Controls.Clear();
            }
            else
            {
                foreach (UCMyProduct item in logIn.homePage.list1)
                {
                    foreach (OrderedItem item_ in this.user.Cart.Items)
                    {
                        if (item.ProductName == item_.ItemName)
                        {
                            item.ProductQuantity = item_.ItemQuantity.ToString();
                            flpList.Controls.Add(item);
                            total += (item_.ItemPrice * Convert.ToInt32(item_.ItemQuantity));
                            count++;
                        }
                    }
                }
                lbNumberProducts.Text = numberOfProdcuts.ToString();
            }
        }
        private void MyCart_Load(object sender, EventArgs e)
        {
            createList();
            lbNumberProducts.Text = count.ToString();
        }

        private void pbRefesh_Click(object sender, EventArgs e)
        {
            flpList.Controls.Clear();
            createList();
        }

        private void pbCheckOut_Click(object sender, EventArgs e)
        {
            PaymentSelect payment = new PaymentSelect(this.user, total);
            payment.Show();
        }
    }
}
