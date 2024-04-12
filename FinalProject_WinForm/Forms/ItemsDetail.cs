using FinalProject_WinForm.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace FinalProject_WinForm
{
    public partial class ItemsDetail : Form
    {
        int tmp = 1;
        FormEntry logIn = Program.logIn;
        public AddItems updated;
        private bool[] clicked = new bool[5];
        private Items item;
        private ItemsDAO itemsDAO = new ItemsDAO();
        private CartDAO cartDAO = new CartDAO();
        public ItemsDetail(Items A)
        {
            this.item = A;
            InitializeComponent();
            checkOwnership();
            for (int i = 0; i < this.item.ItemRating; i++)
            {
                clicked[i] = false;
            }
        }
        private void ItemsDetail_Load(object sender, EventArgs e)
        {
            setInfo(sender, e);

        }
        private void pbAdd_Click(object sender, EventArgs e)
        {
            tmp = Convert.ToInt32(this.txtQuantity.Text) + 1;
            this.lbTotal.Text = (tmp * this.item.ItemPrice).ToString();
            this.txtQuantity.Text = Convert.ToString(tmp);
        }

        private void pbSubtract_Click(object sender, EventArgs e)
        {
            if (tmp == 1) return;
            tmp = Convert.ToInt32(this.txtQuantity.Text) - 1;
            this.lbTotal.Text = (tmp * this.item.ItemPrice).ToString();
            this.txtQuantity.Text = Convert.ToString(tmp);
        }

        private void pbOneStar_Click(object sender, EventArgs e)
        {
            if (clicked[0] == false)
            {
                clicked[0] = true;
                this.pbOneStar.Image = Resources.star__2_;
                return;
            }
            resetStar();
        }

        private void pbTwoStar_Click(object sender, EventArgs e)
        {
            if (clicked[1] == false)
            {
                this.pbOneStar.Image = Resources.star__2_;
                this.pbTwoStar.Image = Resources.star__2_;
                for (int i = 0; i < 2; i++) { clicked[i] = true; }
                return;
            }
            resetStar();
        }

        private void pbThreeStar_Click(object sender, EventArgs e)
        {
            if (clicked[2] == false)
            {
                this.pbOneStar.Image = Resources.star__2_;
                this.pbTwoStar.Image = Resources.star__2_;
                this.pbThreeStar.Image = Resources.star__2_;
                for (int i = 0; i < 3; i++) { clicked[i] = true; }
                return;
            }
            resetStar();
        }

        private void pbFourStar_Click(object sender, EventArgs e)
        {
            if (clicked[3] == false)
            {
                this.pbOneStar.Image = Resources.star__2_;
                this.pbTwoStar.Image = Resources.star__2_;
                this.pbThreeStar.Image = Resources.star__2_;
                this.pbFourStar.Image = Resources.star__2_;
                for (int i = 0; i < 4; i++) { clicked[i] = true; }
                return;
            }
            resetStar();
        }

        private void pbFiveStar_Click(object sender, EventArgs e)
        {
            if (clicked[4] == false)
            {
                this.pbOneStar.Image = Resources.star__2_;
                this.pbTwoStar.Image = Resources.star__2_;
                this.pbThreeStar.Image = Resources.star__2_;
                this.pbFourStar.Image = Resources.star__2_;
                this.pbFiveStar.Image = Resources.star__2_;
                for (int i = 0; i < 5; i++) { clicked[i] = true; }
                return;
            }
            resetStar();
        }
        private void pbAddCart_Click(object sender, EventArgs e)
        {
            lbTotal.Text = (Convert.ToInt32(txtQuantity.Text) * this.item.ItemPrice).ToString();
            cartDAO.AddToCart(logIn.homePage.user, this.item, Convert.ToInt32(txtQuantity.Text));
            
        }

        private void pbItemImage1_Click(object sender, EventArgs e)
        {
            if (this.pbItemsPicture.Image == pbItemImage1.Image) return;
            this.pbItemsPicture.Image = pbItemImage1.Image;
        }

        private void pbItemImage2_Click(object sender, EventArgs e)
        {
            if (this.pbItemsPicture.Image == pbItemImage2.Image) return;
            this.pbItemsPicture.Image = pbItemImage2.Image;
        }

        private void pbItemImage3_Click(object sender, EventArgs e)
        {
            if (this.pbItemsPicture.Image == pbItemImage3.Image) return;
            this.pbItemsPicture.Image = pbItemImage3.Image;
        }

        private void pbUpdateItem_Click(object sender, EventArgs e)
        {
            updated = new AddItems(this.item, "update");
            this.Hide();
            updated.Closed += (s, args) => this.Close();
            updated.Show();
        }
        private void pbSummit_MouseEnter(object sender, EventArgs e)
        {
            this.pbSummit.Image = Resources.checkbox;
        }
        private void pbSummit_MouseLeave(object sender, EventArgs e)
        {
            this.pbSummit.Image = Resources.blank_check_box;
        }

        private void pbSummit_Click(object sender, EventArgs e)
        {
            this.item.ItemRating = (this.item.ItemRating + starCount()) / 2;
            itemsDAO.UpdateRating(this.item);
        }

        //Functions
        private int starCount()
        {
            int count = 0;
            for (int i = 0; i < 5; i++)
                if (clicked[i] == true)
                {
                    count++;
                }
            return count;
        }
        private void checkOwnership()
        {
            if (logIn.homePage.user.Name == this.item.UserName)
            {
                this.pbUpdateItem.Show();
                this.pbOneStar.Hide();
                this.pbTwoStar.Hide();
                this.pbThreeStar.Hide();
                this.pbFourStar.Hide();
                this.pbFiveStar.Hide();
                this.pbSummit.Hide();
                this.pbAddCart.Hide();
            }
            else
            { 
                this.pbUpdateItem.Hide();
                this.pbOneStar.Show();
                this.pbTwoStar.Show();
                this.pbThreeStar.Show();
                this.pbFourStar.Show();
                this.pbFiveStar.Show();
                this.pbSummit.Show();
                this.pbAddCart.Show();
            }
        }
        private void resetStar()
        {
            this.pbOneStar.Image = Resources.star__3_;
            this.pbTwoStar.Image = Resources.star__3_;
            this.pbThreeStar.Image = Resources.star__3_;
            this.pbFourStar.Image = Resources.star__3_;
            this.pbFiveStar.Image = Resources.star__3_;
            for (int i = 0; i < 5; i++) { clicked[i] = false; }
        }
        private void setInfo(object sender, EventArgs e)
        {
            //Pictures
            byte[] imageData, imageData1, imageData2;
            if (this.item.ItemImage[0] != "")
            {
                imageData = File.ReadAllBytes(this.item.ItemImage[0]);
                pbItemsPicture.Image = Functions.ByteArrayToImage(imageData);
                pbItemImage1.Image = Functions.ByteArrayToImage(imageData);
            }
            else
                pbItemImage1.Image = Resources.product_placeholder;
            if (this.item.ItemImage[1] != "")
            {
                imageData1 = File.ReadAllBytes(this.item.ItemImage[1]);
                pbItemImage2.Image = Functions.ByteArrayToImage(imageData1);
            }
            else
                pbItemImage2.Image = Resources.product_placeholder;
            if (this.item.ItemImage[2] != "")
            {
                imageData2 = File.ReadAllBytes(this.item.ItemImage[2]);
                pbItemImage3.Image = Functions.ByteArrayToImage(imageData2);
            }
            else
                pbItemImage3.Image = Resources.product_placeholder;

            //Item Infomation
            lbTotal.Text = (Convert.ToInt32(txtQuantity.Text) * this.item.ItemPrice).ToString();
            lbItemsName.Text = item.ItemName;
            lbItemsDisciption.Text = item.ItemDescription;
            lbPrice.Text = Convert.ToString(item.ItemPrice);
            lbOriginPrice.Text = Convert.ToString(item.ItemOldPrice);
            lbYear.Text = item.ItemYear.ToString("dd/MM/yyyy");
            lbSellerName.Text = item.UserName;
            lbQuantity.Text = Convert.ToString(item.ItemQuantity);
            if (item.ItemQuality < 10) lbQuantity.ForeColor = Color.Red;
            else lbQuantity.ForeColor = Color.Green;

            //Item Rating
            switch (this.item.ItemRating)
            {
                case 1:
                    pbOneStar_Click(sender, e);
                    break;
                case 2:
                    pbTwoStar_Click(sender, e);
                    break;
                case 3:
                    pbThreeStar_Click(sender, e);
                    break;
                case 4:
                    pbFourStar_Click(sender, e);
                    break;
                case 5:
                    pbFiveStar_Click(sender, e);
                    break;
                default: break;
            }
        }
       
    }
}
