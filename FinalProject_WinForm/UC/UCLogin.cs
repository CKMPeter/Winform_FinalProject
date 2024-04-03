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
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).KeyPress += txtUser_KeyPress;
                }
            }
        }

        public string UserName()
        {
            return Functions.RemoveSpacing(txtUser.Text.Trim());
        }

        public string Password()
        {
            return Functions.RemoveSpacing(txtPassword.Text.Trim());
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
