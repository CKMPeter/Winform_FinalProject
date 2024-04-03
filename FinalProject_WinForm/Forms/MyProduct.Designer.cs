namespace FinalProject_WinForm
{
    partial class MyProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpList = new FlowLayoutPanel();
            ucMenu1 = new UCMenu();
            lbSellerName = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            lbNumberProducts = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flpList
            // 
            flpList.AutoScroll = true;
            flpList.BackColor = Color.White;
            flpList.FlowDirection = FlowDirection.TopDown;
            flpList.Location = new Point(357, 143);
            flpList.Name = "flpList";
            flpList.Size = new Size(779, 501);
            flpList.TabIndex = 11;
            flpList.WrapContents = false;
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-7, -7);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1500, 114);
            ucMenu1.TabIndex = 15;
            // 
            // lbSellerName
            // 
            lbSellerName.AutoSize = true;
            lbSellerName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSellerName.ForeColor = Color.FromArgb(204, 233, 255);
            lbSellerName.Location = new Point(40, 57);
            lbSellerName.Name = "lbSellerName";
            lbSellerName.Size = new Size(203, 28);
            lbSellerName.TabIndex = 3;
            lbSellerName.Text = "Number Of Product:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 233, 255);
            label1.Location = new Point(25, 12);
            label1.Name = "label1";
            label1.Size = new Size(248, 45);
            label1.TabIndex = 2;
            label1.Text = "MY PRODUCTS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 100, 159);
            panel1.Controls.Add(lbNumberProducts);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbSellerName);
            panel1.Location = new Point(29, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 143);
            panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox2.Location = new Point(-7, 64);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1200, 710);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbNumberProducts
            // 
            lbNumberProducts.AutoSize = true;
            lbNumberProducts.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbNumberProducts.ForeColor = Color.FromArgb(204, 233, 255);
            lbNumberProducts.Location = new Point(124, 85);
            lbNumberProducts.Name = "lbNumberProducts";
            lbNumberProducts.Size = new Size(40, 46);
            lbNumberProducts.TabIndex = 4;
            lbNumberProducts.Text = "0";
            // 
            // MyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(flpList);
            Controls.Add(pictureBox2);
            Controls.Add(ucMenu1);
            Name = "MyProduct";
            Text = "MyProduct";
            Load += MyProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpList;
        private UCMenu ucMenu1;
        private Label lbSellerName;
        private Label label1;
        private Panel panel1;
        private Label lbNumberProducts;
        private PictureBox pictureBox2;
    }
}