using FinalProject_WinForm.Forms;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_WinForm
{
    public partial class PaymentSelect : Form
    {
        FormEntry logIn = Program.logIn;
        User user;
        int total = 0;
        //125, 62
        int height = 55;
        int width = 125;
        string method = "";
        public PaymentSelect(User A, int total)
        {
            this.user = A;
            InitializeComponent();
            this.total = total; lbTotal.Text = total.ToString();
            pbReset();
            pbVISA.Height += 5;
            pbVISA.Width += 5;
            lbMethod.Text = "Card No: ";
            lbInfo.Text = this.user.Visa;
            method = "VISA";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            ItemsDAO itemDAO = new ItemsDAO();
            CartDAO cartDAO = new CartDAO();
            foreach (OrderedItem item in this.user.Cart.Items)
            {
                foreach (Items item_ in logIn.homePage.detailItems)
                {
                    if (item.ItemName == item_.ItemName && item_.ItemQuantity > 0)
                    { 
                        item_.ItemQuantity -= item.ItemQuantity;
                        itemDAO.UpdateItem(item_);
                    }
                }
                cartDAO.PayForCart(this.user, item.ItemId); 
               
            }
            this.user.Cart.Items.Clear();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbVISA_Click(object sender, EventArgs e)
        {
            pbReset();
            pbVISA.Height += 5;
            pbVISA.Width += 5;
            lbInfo.Text = this.user.Visa;
            lbMethod.Text = "Card No: ";
            method = "VISA";
        }

        private void pbPAYPAL_Click(object sender, EventArgs e)
        {
            pbReset();
            pbPAYPAL.Height += 5;
            pbPAYPAL.Width += 5;
            lbInfo.Text = this.user.Paypal;
            lbMethod.Text = "Card No: ";
            method = "PAYPAL";
        }

        private void pbCASH_Click(object sender, EventArgs e)
        {
            pbReset();
            pbCASH.Height += 5;
            pbCASH.Width += 5;
            lbInfo.Text = this.user.Address;
            lbMethod.Text = "Address: ";
            method = "PAYPAL";
        }

        private void pbReset()
        {
            pbCASH.Height = height;
            pbCASH.Width = width;
            pbVISA.Height = height;
            pbPAYPAL.Height = height;
            pbVISA.Width = width;
            pbPAYPAL.Width = width;
        }

        private void btVoucher_Click(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            voucher.Show();
        }
    }
}
