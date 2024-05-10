using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_WinForm.C_
{
    public partial class ConfirmBox : Form
    {
        FormEntry logIn = Program.logIn;
        Items items;
        User user;
        public ConfirmBox(User A,Items items)
        {
            this.items = items;
            this.user = A;
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            CartDAO cartDAO = new CartDAO();
            cartDAO.DeleteFromCart(this.user, this.items, txtReason.Text);
            foreach(OrderedItem item in this.user.Cart.Items)
            {
                if(this.user.Cart.Items.Count > 0)
                    if(item.ItemName == Functions.convertItemToOrderItem(this.items).ItemName)
                        this.user.Cart.Items.Remove(item);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
