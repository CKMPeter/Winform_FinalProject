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
    public partial class UCQuanlity : UserControl
    {
        int tmp, tmpP;
        Items item;
        public UCQuanlity()
        {
            InitializeComponent();
        }
        public int Price { get { return tmpP; } set { tmpP = value; } }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            tmp = Convert.ToInt32(this.txtQuanlity.Text) + 1;
            this.txtQuanlity.Text = Convert.ToString(tmp);
        }

        private void pbSubtract_Click(object sender, EventArgs e)
        {
            if (tmp == 1) return;
            tmp = Convert.ToInt32(this.txtQuanlity.Text) - 1;
            this.txtQuanlity.Text = Convert.ToString(tmp);
        }

        private void UCQuanlity_Load(object sender, EventArgs e)
        {

            //this.txtQuanlity.Text = Convert.ToString(this.tmp);
        }

    }
}
