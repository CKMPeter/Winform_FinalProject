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
    public partial class AddItems : Form
    {
        public User user;
        public Items item;
        public ItemsDAO itemsDAO = new ItemsDAO();
        FormEntry logIn = Program.logIn;
        private string[] filePath = new string[3];
        private string mode;
        public AddItems(User A, string mode)
        {
            this.user = A;
            this.mode = mode;
            InitializeComponent();
        }

        public AddItems(Items B, string mode)
        {
            this.item = B;
            this.mode = mode;
            InitializeComponent();
            SetInfo();
        }

        private void pbAddCart_Click(object sender, EventArgs e)
        {
            ///
            if (mode == "add" && Functions.checkValidYear(txtYear.Text) && Functions.checkValidQuantity(txtProductQuantity.Text))
            {
                Items items = new Items(txtProductName.Text, txtProductDiscription.Text, Convert.ToInt32(txtProductQuantity.Text), Convert.ToInt32(txtProductPrice.Text), user.Name, this.filePath, Convert.ToInt32(txtQuality.Text), Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtOriginPrice.Text), 0);
                Console.WriteLine(items.ItemImage);
                itemsDAO.AddItems(items);
                UCItems uCItems = new UCItems(items);
                UCMyProduct myProduct = new UCMyProduct(items);
                byte[] imageData = File.ReadAllBytes(items.ItemImage[0]); ;
                Image image = Functions.ByteArrayToImage(imageData);
                myProduct.ProductImage = uCItems.ProductImage = image;
                myProduct.ProductName = uCItems.ProductName = items.ItemName;
                uCItems.ProductDiscription = items.ItemDescription;
                uCItems.ProductPrice = Convert.ToString(items.ItemPrice);
                myProduct.ProductQuantity = Convert.ToString(items.ItemQuantity);
                logIn.homePage.list.Add(uCItems);
                logIn.homePage.list1.Add(myProduct);
            }
            else if (mode == "update" && Functions.checkValidYear(txtYear.Text) && Functions.checkValidQuantity(txtProductQuantity.Text))
            {
                this.item.ItemName = txtProductName.Text;
                this.item.ItemDescription = txtProductDiscription.Text;
                this.item.ItemQuality = Convert.ToInt32(txtQuality.Text);
                this.item.ItemQuantity = Convert.ToInt32(txtProductQuantity.Text);
                this.item.ItemPrice = Convert.ToInt32(txtProductPrice.Text);
                this.item.ItemOldPrice = Convert.ToInt32(txtOriginPrice.Text);
                itemsDAO.UpdateItem(this.item);

            }

        }

        private void pbPictureUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image (*.jpg, *.png, *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbItemsPicture.Image = new Bitmap(openFileDialog.FileName);
                this.filePath[0] = openFileDialog.FileName.ToString();
            }
        }
        private void pbPictureUpload1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image (*.jpg, *.png, *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbItemsPicture1.Image = new Bitmap(openFileDialog.FileName);
                this.filePath[1] = openFileDialog.FileName.ToString();
            }
        }

        private void pbPictureUpload2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Choose Image (*.jpg, *.png, *.gif)|*.jpg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbItemsPicture2.Image = new Bitmap(openFileDialog.FileName);
                this.filePath[2] = openFileDialog.FileName.ToString();
            }
        }
        private void SetInfo()
        {
            if (this.item.ItemName == null) { return; }
            txtProductName.Text = this.item.ItemName;
            txtProductDiscription.Text = this.item.ItemDescription;
            txtProductQuantity.Text= Convert.ToString(this.item.ItemQuantity);
            txtProductPrice.Text = Convert.ToString(this.item.ItemPrice);
            txtQuality.Text = Convert.ToString(this.item.ItemQuality);
            txtYear.Text = Convert.ToString(this.item.ItemYear);
            txtOriginPrice.Text = Convert.ToString(this.item.ItemOldPrice);

            Image[] images = new Image[3];
            for (int i = 0; i < 3; i++)
            {
                if (item.ItemImage[i] != "")
                { byte[] imageData = File.ReadAllBytes(this.item.ItemImage[i]); images[i] = Functions.ByteArrayToImage(imageData); ; }
                else
                    images[i] = Resources.product_placeholder;
            }
            pbItemsPicture.Image = images[0];
            pbItemsPicture2.Image = images[1];
            pbItemsPicture2.Image = images[2];

        }
        private void AddItems_Load(object sender, EventArgs e)
        {
            lbMode.Text = mode.ToUpper();
        }

        private void lbOriginPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
