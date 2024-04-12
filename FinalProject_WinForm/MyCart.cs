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
        int numberOfProdcuts = 0;
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
                    foreach( OrderedItem item_ in this.user.cart.Items)
                    {
                        if (item.ProductName == item_.ItemName)
                            flpList.Controls.Add(item);
                    }
                }
                lbNumberProducts.Text = numberOfProdcuts.ToString();
            }
        }
    }
}
