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
        private void btnMainReturn_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserMoreInfo_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
            foreach(User tmp in logIn.usersList)
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
