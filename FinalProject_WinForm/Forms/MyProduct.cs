using Microsoft.VisualBasic.ApplicationServices;
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
using System.Xml.Serialization;

namespace FinalProject_WinForm
{
    public partial class MyProduct : Form
    {
        FormEntry logIn = Program.logIn;
        User user;
        int numberOfProdcuts = 0;
        public MyProduct(User A)
        {
            InitializeComponent();
            this.user = A;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MyProduct_Load(object sender, EventArgs e)
        {
            createList();
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
                    if (item.items_.UserName == user.Name)
                    {
                        numberOfProdcuts++;
                        flpList.Controls.Add(item); 
                    }
                }
                lbNumberProducts.Text = numberOfProdcuts.ToString();
            }
        }
    }
}
