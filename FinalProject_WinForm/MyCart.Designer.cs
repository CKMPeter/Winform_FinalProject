namespace FinalProject_WinForm
{
    partial class MyCart
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
            pictureBox2 = new PictureBox();
            ucMenu1 = new UCMenu();
            label1 = new Label();
            lbSellerName = new Label();
            panel1 = new Panel();
            lbNumberProducts = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flpList
            // 
            flpList.AutoScroll = true;
            flpList.BackColor = Color.White;
            flpList.FlowDirection = FlowDirection.TopDown;
            flpList.Location = new Point(359, 146);
            flpList.Name = "flpList";
            flpList.Size = new Size(779, 501);
            flpList.TabIndex = 17;
            flpList.WrapContents = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox2.Location = new Point(-5, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1200, 710);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-5, -4);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1500, 114);
            ucMenu1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 233, 255);
            label1.Location = new Point(62, 12);
            label1.Name = "label1";
            label1.Size = new Size(161, 45);
            label1.TabIndex = 2;
            label1.Text = "MY CART";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 100, 159);
            panel1.Controls.Add(lbNumberProducts);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbSellerName);
            panel1.Location = new Point(31, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 143);
            panel1.TabIndex = 20;
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
            // MyCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(flpList);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(ucMenu1);
            Name = "MyCart";
            Text = "MyCart";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpList;
        private PictureBox pictureBox2;
        private UCMenu ucMenu1;
        private Label label1;
        private Label lbSellerName;
        private Panel panel1;
        private Label lbNumberProducts;
    }
}