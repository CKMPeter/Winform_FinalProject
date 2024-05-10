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
    public partial class HomePage : Form
    {
        public UserMoreInfo userMoreInfo;
        public User user;
        public AddItems addItems;
        public MyProduct product;
        public MyProduct myProduct;
        private ItemsDAO itemsDAO = new ItemsDAO();
        private CartDAO cartDAO = new CartDAO();
        public List<Items> detailItems = new List<Items>();
        public List<UCMyProduct> list1 = new List<UCMyProduct>();
        public List<UCItems> list = new List<UCItems>();

        FormEntry logIn = Program.logIn; 

        public HomePage(User user)
        {
            this.user = user;
            this.user.Cart = new Cart(cartDAO.LoadCartInfo());
            infoSet();
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            userMoreInfo.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            ListCreate();
        }

        public void ListCreate()
        {

            if (flpList.Controls.Count < 0)
            {
                this.flpList.Controls.Clear();
            }
            else
            {
                foreach (UCItems item in list)
                {
                    this.flpList.Controls.Add(item);
                }
            }
        }


        private void pbCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void pbInfo_Click(object sender, EventArgs e) //for User Info
        {

        }

        private void pbViewCart_Click(object sender, EventArgs e) //for ViewCart 
        {

        }

        private void pbLogOut_Click(object sender, EventArgs e) //for logout function
        {
            this.Hide();
            var login = new FormEntry();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void pbSearch_Click(object sender, EventArgs e) //for search items
        {
            if (flpList.Controls.Count >= 0)
            {
                this.flpList.Controls.Clear();
                foreach (UCItems item in list)
                {
                    if (this.cbCatagory.GetItemText(this.cbCatagory.SelectedItem) == "" && tbSearch.Text == "") //handle error
                        break;
                    else // for 2 type of search
                    {
                        if (this.cbCatagory.GetItemText(this.cbCatagory.SelectedItem) == "" && Functions.CompareStrings(item.ProductName, tbSearch.Text) >= 60)
                            this.flpList.Controls.Add(item);
                        else if (this.cbCatagory.GetItemText(this.cbCatagory.SelectedItem) == item.ProductCatagory && tbSearch.Text == "")
                            this.flpList.Controls.Add(item);
                        else if ((this.cbCatagory.GetItemText(this.cbCatagory.SelectedItem) == item.ProductCatagory && Functions.CompareStrings(item.ProductName, tbSearch.Text) >= 60))
                            this.flpList.Controls.Add(item);
                    }
                }
            }
            else
            {

            }
        }
        private void pbSearch_MouseEnter(object sender, EventArgs e)
        {
            this.pbSearch.Height += 5;
            this.pbSearch.Width += 5;
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            this.pbSearch.Height -= 5;
            this.pbSearch.Width -= 5;
        }
        private void infoSet()
        {
            detailItems = itemsDAO.LoadItemsInfo();
            userMoreInfo = new UserMoreInfo(user);
            addItems = new AddItems(user, "add");
            product = new MyProduct(user);


            foreach (Items items in detailItems)
            {
                UCItems tmp = new UCItems(items);
                UCMyProduct tmp1 = new UCMyProduct(items);

                byte[] imageData = File.ReadAllBytes(items.ItemImage[0]); ;
                Image image = Functions.ByteArrayToImage(imageData);
                tmp1.ProductImage = tmp.ProductImage = image;
                tmp1.ProductName = tmp.ProductName = items.ItemName;
                tmp.ProductOldPrice = Convert.ToString(items.ItemOldPrice);
                tmp.ProductPrice = Convert.ToString(items.ItemPrice);
                tmp1.ProductQuantity = Convert.ToString(items.ItemQuantity);
                tmp1.Price = Convert.ToString(items.ItemPrice);
                list.Add(tmp);
                list1.Add(tmp1);
            }
        }

        private void pbMyCart_Click(object sender, EventArgs e)
        {
            Form newForm = new MyCart(this.user);
            newForm.Closed += (s, args) => this.Close();
            newForm.Show();
            this.Hide();
        }
    }
}
