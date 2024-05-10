using FinalProject_WinForm.Properties;
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
    public partial class UserMoreInfo : Form
    {
        FormEntry logIn = Program.logIn;
        User user;
        public UserMoreInfo(User A)
        {
            InitializeComponent();
            this.user = A;
            InfoSet();
        }

        private void InfoSet()
        {
            Image image;
            if (user.Avatar != "")
            {
                byte[] imageData = File.ReadAllBytes(user.Avatar); ;
                image = Functions.ByteArrayToImage(imageData);
            }
            else image = Resources.user11; // default icon
            pbUserAvatar.Image = image;
            txtName.Text = this.user.Name;
            txtPassword.Text = this.user.Password;
            txtEmail.Text = this.user.Email;
            txtAddress.Text = this.user.Address;
            txtVisa.Text = this.user.Visa;
            txtPaypal.Text = this.user.Paypal;
            switch (this.user.Gender)
            {
                case 1:
                    ucGender.Femaleimage = Resources.checkbox;
                    ucGender.Maleimage = Resources.blank_check_box;
                    ucGender.Otherimage = Resources.blank_check_box;
                    break;

                case 2:
                    ucGender.Otherimage = Resources.checkbox;
                    ucGender.Maleimage = Resources.blank_check_box;
                    ucGender.Femaleimage = Resources.blank_check_box;
                    break;

                default:
                    ucGender.Maleimage = Resources.checkbox;
                    ucGender.Femaleimage = Resources.blank_check_box;
                    ucGender.Otherimage = Resources.blank_check_box;
                    break;
            }
        }
        private void pbUpload_Click(object sender, EventArgs e)
        {
            if (!Functions.CheckFormatEmail(txtEmail.Text) || !checkDupEmail())
            {
                MessageBox.Show("Add fail!\nPlease try Again!");
                return;
            }
            UserUpdate();
            logIn.userDAO.UpdateUser(user);
            logIn.usersList = logIn.userDAO.LoadUInfo();
        }
        public bool checkDupEmail()
        {
            foreach (User tmp in logIn.usersList)
            {
                if (tmp.Email == txtEmail.Text) { return false; }
            }
            return true;
        }

        public void UserUpdate()
        {
            this.user.Name = txtName.Text;
            this.user.Password = txtPassword.Text;
            this.user.Email = txtEmail.Text;
            this.user.Address = txtAddress.Text;
            this.user.Gender = ucGender.returnGender();
            this.user.Visa = txtVisa.Text;
            this.user.Paypal = txtPaypal.Text;
        }

        private void pbUpdateAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image (*.jpg, *.png, *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbUserAvatar.Image = new Bitmap(openFileDialog.FileName);
                this.user.Avatar = openFileDialog.FileName.ToString();
            }
        }
    }
}
