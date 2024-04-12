namespace FinalProject_WinForm
{
    partial class AddItems
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
            ucMenu1 = new UCMenu();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtProductDiscription = new TextBox();
            pbAddCart = new PictureBox();
            panel2 = new Panel();
            pbPictureUpload2 = new PictureBox();
            pbPictureUpload1 = new PictureBox();
            pbItemsPicture2 = new PictureBox();
            pbItemsPicture1 = new PictureBox();
            pbPictureUpload = new PictureBox();
            pbItemsPicture = new PictureBox();
            panel4 = new Panel();
            label8 = new Label();
            txtProductPrice = new TextBox();
            txtQuality = new TextBox();
            label3 = new Label();
            label6 = new Label();
            txtOriginPrice = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            txtProductQuantity = new TextBox();
            lbMode = new Label();
            label7 = new Label();
            cbCatagory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddCart).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-9, 0);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1500, 114);
            ucMenu1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox1.Location = new Point(-9, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1200, 700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(txtProductDiscription);
            panel3.Location = new Point(27, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 83);
            panel3.TabIndex = 4;
            // 
            // txtProductDiscription
            // 
            txtProductDiscription.BackColor = SystemColors.ControlLight;
            txtProductDiscription.BorderStyle = BorderStyle.None;
            txtProductDiscription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductDiscription.Location = new Point(3, 3);
            txtProductDiscription.Name = "txtProductDiscription";
            txtProductDiscription.PlaceholderText = "Write some discription about ypur product";
            txtProductDiscription.Size = new Size(454, 20);
            txtProductDiscription.TabIndex = 4;
            // 
            // pbAddCart
            // 
            pbAddCart.Image = Properties.Resources.up_loading;
            pbAddCart.Location = new Point(710, 499);
            pbAddCart.Name = "pbAddCart";
            pbAddCart.Size = new Size(50, 50);
            pbAddCart.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAddCart.TabIndex = 3;
            pbAddCart.TabStop = false;
            pbAddCart.Click += pbAddCart_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pbPictureUpload2);
            panel2.Controls.Add(pbPictureUpload1);
            panel2.Controls.Add(pbItemsPicture2);
            panel2.Controls.Add(pbItemsPicture1);
            panel2.Controls.Add(pbPictureUpload);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pbAddCart);
            panel2.Controls.Add(pbItemsPicture);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtProductName);
            panel2.Location = new Point(345, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 565);
            panel2.TabIndex = 2;
            // 
            // pbPictureUpload2
            // 
            pbPictureUpload2.Image = Properties.Resources.add;
            pbPictureUpload2.Location = new Point(700, 364);
            pbPictureUpload2.Name = "pbPictureUpload2";
            pbPictureUpload2.Size = new Size(60, 60);
            pbPictureUpload2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPictureUpload2.TabIndex = 19;
            pbPictureUpload2.TabStop = false;
            pbPictureUpload2.Click += pbPictureUpload2_Click;
            // 
            // pbPictureUpload1
            // 
            pbPictureUpload1.Image = Properties.Resources.add;
            pbPictureUpload1.Location = new Point(570, 364);
            pbPictureUpload1.Name = "pbPictureUpload1";
            pbPictureUpload1.Size = new Size(60, 60);
            pbPictureUpload1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPictureUpload1.TabIndex = 18;
            pbPictureUpload1.TabStop = false;
            pbPictureUpload1.Click += pbPictureUpload1_Click;
            // 
            // pbItemsPicture2
            // 
            pbItemsPicture2.Image = Properties.Resources.product_placeholder;
            pbItemsPicture2.Location = new Point(640, 304);
            pbItemsPicture2.Name = "pbItemsPicture2";
            pbItemsPicture2.Size = new Size(120, 120);
            pbItemsPicture2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemsPicture2.TabIndex = 15;
            pbItemsPicture2.TabStop = false;
            // 
            // pbItemsPicture1
            // 
            pbItemsPicture1.Image = Properties.Resources.product_placeholder;
            pbItemsPicture1.Location = new Point(510, 304);
            pbItemsPicture1.Name = "pbItemsPicture1";
            pbItemsPicture1.Size = new Size(120, 120);
            pbItemsPicture1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemsPicture1.TabIndex = 14;
            pbItemsPicture1.TabStop = false;
            // 
            // pbPictureUpload
            // 
            pbPictureUpload.Image = Properties.Resources.add;
            pbPictureUpload.Location = new Point(700, 232);
            pbPictureUpload.Name = "pbPictureUpload";
            pbPictureUpload.Size = new Size(60, 60);
            pbPictureUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPictureUpload.TabIndex = 9;
            pbPictureUpload.TabStop = false;
            pbPictureUpload.Click += pbPictureUpload_Click;
            // 
            // pbItemsPicture
            // 
            pbItemsPicture.Image = Properties.Resources.product_placeholder;
            pbItemsPicture.Location = new Point(510, 42);
            pbItemsPicture.Name = "pbItemsPicture";
            pbItemsPicture.Size = new Size(250, 250);
            pbItemsPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemsPicture.TabIndex = 0;
            pbItemsPicture.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(cbCatagory);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(txtProductPrice);
            panel4.Controls.Add(txtQuality);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(txtOriginPrice);
            panel4.Controls.Add(label4);
            panel4.ForeColor = SystemColors.ActiveCaptionText;
            panel4.Location = new Point(27, 232);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 317);
            panel4.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 12);
            label8.Margin = new Padding(3, 5, 3, 10);
            label8.Name = "label8";
            label8.Size = new Size(103, 32);
            label8.TabIndex = 16;
            label8.Text = "Quality:";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(41, 267);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(379, 27);
            txtProductPrice.TabIndex = 6;
            // 
            // txtQuality
            // 
            txtQuality.Location = new Point(40, 47);
            txtQuality.Margin = new Padding(40, 3, 40, 3);
            txtQuality.Name = "txtQuality";
            txtQuality.Size = new Size(380, 27);
            txtQuality.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 160);
            label3.Margin = new Padding(3, 5, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(78, 32);
            label3.TabIndex = 6;
            label3.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 85);
            label6.Margin = new Padding(3, 5, 3, 10);
            label6.Name = "label6";
            label6.Size = new Size(125, 32);
            label6.TabIndex = 12;
            label6.Text = "Catagory:";
            // 
            // txtOriginPrice
            // 
            txtOriginPrice.Location = new Point(41, 195);
            txtOriginPrice.Name = "txtOriginPrice";
            txtOriginPrice.Size = new Size(379, 27);
            txtOriginPrice.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 230);
            label4.Margin = new Padding(3, 5, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(177, 32);
            label4.TabIndex = 10;
            label4.Text = "Original Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(20, 184);
            label1.Name = "label1";
            label1.Size = new Size(139, 45);
            label1.TabIndex = 2;
            label1.Text = "ABOUT:";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = SystemColors.Control;
            txtProductName.BorderStyle = BorderStyle.None;
            txtProductName.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(27, 16);
            txtProductName.Name = "txtProductName";
            txtProductName.PlaceholderText = "Product Name";
            txtProductName.Size = new Size(457, 67);
            txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(204, 233, 255);
            label2.Location = new Point(15, 10);
            label2.Margin = new Padding(3, 5, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(120, 32);
            label2.TabIndex = 5;
            label2.Text = "Quantity:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 100, 159);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(lbMode);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(32, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 276);
            panel1.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(42, 85, 111);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(txtProductQuantity);
            panel5.Location = new Point(18, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(262, 115);
            panel5.TabIndex = 21;
            // 
            // txtProductQuantity
            // 
            txtProductQuantity.Location = new Point(15, 55);
            txtProductQuantity.Margin = new Padding(15, 3, 15, 3);
            txtProductQuantity.Name = "txtProductQuantity";
            txtProductQuantity.Size = new Size(232, 27);
            txtProductQuantity.TabIndex = 5;
            // 
            // lbMode
            // 
            lbMode.AutoSize = true;
            lbMode.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMode.ForeColor = Color.FromArgb(204, 233, 255);
            lbMode.Location = new Point(85, 195);
            lbMode.Name = "lbMode";
            lbMode.Size = new Size(117, 45);
            lbMode.TabIndex = 17;
            lbMode.Text = "Mode:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(204, 233, 255);
            label7.Location = new Point(33, 12);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(214, 46);
            label7.TabIndex = 11;
            label7.Text = "INVENTORY";
            // 
            // cbCatagory
            // 
            cbCatagory.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Items.AddRange(new object[] { "Decoratives", "Electronics", "Furnitures", "Favorites" });
            cbCatagory.Location = new Point(40, 124);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(380, 28);
            cbCatagory.TabIndex = 17;
            // 
            // AddItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Controls.Add(ucMenu1);
            Name = "AddItems";
            Text = "Form1";
            Load += AddItems_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAddCart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPictureUpload).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbItemsPicture).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private UCMenu ucMenu1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pbAddCart;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pbItemsPicture;
        private Label label1;
        private Label label2;
        private TextBox txtProductQuantity;
        private TextBox txtProductDiscription;
        private TextBox txtProductName;
        private Label label3;
        private TextBox txtProductPrice;
        private PictureBox pbPictureUpload;
        private Label label4;
        private TextBox txtOriginPrice;
        private Label label6;
        private Label label8;
        private PictureBox pbItemsPicture2;
        private PictureBox pbItemsPicture1;
        private TextBox txtQuality;
        private PictureBox pbPictureUpload2;
        private PictureBox pbPictureUpload1;
        private Label label7;
        private Label lbMode;
        private Panel panel4;
        private Panel panel5;
        private ComboBox cbCatagory;
    }
}