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
    public partial class UCMenu : UserControl
    {
        FormEntry logIn = Program.logIn;
        public UCMenu()
        {
            InitializeComponent();
        }

        private void pbInfo_MouseEnter(object sender, EventArgs e)
        {
            this.pbInfo.Height += 10;
            this.pbInfo.Width += 10;
        }

        private void pbInfo_MouseLeave(object sender, EventArgs e)
        {
            this.pbInfo.Height -= 10;
            this.pbInfo.Width -= 10;
        }

        private void pbCheckOut_MouseEnter(object sender, EventArgs e)
        {
            this.pbCheckOut.Height += 10;
            this.pbCheckOut.Width += 10;
        }

        private void pbCheckOut_MouseLeave(object sender, EventArgs e)
        {
            this.pbCheckOut.Height -= 10;
            this.pbCheckOut.Width -= 10;
        }

        private void pbViewCart_MouseEnter(object sender, EventArgs e)
        {
            this.pbViewCart.Height += 10;
            this.pbViewCart.Width += 10;
        }

        private void pbViewCart_MouseLeave(object sender, EventArgs e)
        {
            this.pbViewCart.Height -= 10;
            this.pbViewCart.Width -= 10;
        }


        private void pbLogOut_MouseEnter(object sender, EventArgs e)
        {
            this.pbLogOut.Height += 10;
            this.pbLogOut.Width += 10;
        }

        private void pbLogOut_MouseLeave(object sender, EventArgs e)
        {
            this.pbLogOut.Height -= 10;
            this.pbLogOut.Width -= 10;
        }

        private void pbMenu_MouseEnter(object sender, EventArgs e)
        {
            this.pbMenu.Height += 10;
            this.pbMenu.Width += 10;
        }

        private void pbMenu_MouseLeave(object sender, EventArgs e)
        {
            this.pbMenu.Height -= 10;
            this.pbMenu.Width -= 10;
        }
        private void pbAddItems_MouseEnter(object sender, EventArgs e)
        {
            this.pbAddItems.Height += 10;
            this.pbAddItems.Width += 10;
        }

        private void pbAddItems_MouseLeave(object sender, EventArgs e)
        {
            this.pbAddItems.Height -= 10;
            this.pbAddItems.Width -= 10;
        }
        private void pbCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void pbViewCart_Click(object sender, EventArgs e)
        {
            if (((Form)this.TopLevelControl).GetType().Name == "MyProduct") return;
            ((Form)this.TopLevelControl).Hide();
            logIn.homePage.product.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            logIn.homePage.product.Show();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (((Form)this.TopLevelControl).GetType().Name == "HomePage") return;
            ((Form)this.TopLevelControl).Hide();
            logIn.homePage.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            logIn.homePage.Show();
            logIn.homePage.ListCreate();
        }

        private void pbLogOut_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            logIn.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            logIn.Show();
        }
        private void pbInfo_Click(object sender, EventArgs e)
        {
            if (((Form)this.TopLevelControl).GetType().Name == "UserMoreInfo") return;
            ((Form)this.TopLevelControl).Hide();
            logIn.homePage.userMoreInfo.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            logIn.homePage.userMoreInfo.Show();
        }

        private void pbAddItems_Click(object sender, EventArgs e)
        {
            if (((Form)this.TopLevelControl).GetType().Name == "AddItems") return;
            ((Form)this.TopLevelControl).Hide();
            logIn.homePage.addItems.Closed += (s, args) => ((Form)this.TopLevelControl).Close();
            logIn.homePage.addItems.Show();
        }
    }
}
