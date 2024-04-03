using Azure.Core;
using FinalProject_WinForm.Properties;
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
    public partial class UCCheckBox : UserControl
    {
        bool[] list = new bool[3];
        private Image cbOtherImage;
        private Image cbMaleImage;
        private Image cbFemaleImage;
        public UCCheckBox()
        {
            InitializeComponent();
        }
        public Image Otherimage { get { return cbOtherImage; } set { cbOtherImage = value; pbOther.Image = value; } }
        public Image Maleimage { get { return cbMaleImage; } set { cbMaleImage = value; pbMale.Image = value; } }
        public Image Femaleimage { get { return cbFemaleImage; } set { cbFemaleImage = value; pbFemale.Image = value; } }
        private void pbOther_Click(object sender, EventArgs e)
        {
            if (list[2] == true) return;
            clickedReset();
            list[2] = true;
            this.pbOther.Image = Resources.checkbox;
            this.pbFemale.Image = Resources.blank_check_box;
            this.pbMale.Image = Resources.blank_check_box;
        }

        private void pbFemale_Click(object sender, EventArgs e)
        {
            if (list[1] == true) return;
            clickedReset();
            list[1] = true;
            this.pbFemale.Image = Resources.checkbox;
            this.pbOther.Image = Resources.blank_check_box;
            this.pbMale.Image = Resources.blank_check_box;
        }
        private void pbMale_Click(object sender, EventArgs e)
        {
            if (list[0] == true) return;
            clickedReset();
            list[0] = true;
            this.pbMale.Image = Resources.checkbox;
            this.pbOther.Image = Resources.blank_check_box;
            this.pbFemale.Image = Resources.blank_check_box;
        }
        public void clickedReset()
        {
            for (int i = 0; i < list.Length; i++) { list[i] = false; };
        }

        public int returnGender()
        {
            for (int i = 0; i < list.Length; i++)
                if (list[i] == true)
                    return i;
            return 0;
        }
    }
}
