namespace FinalProject_WinForm
{
    partial class UCMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogOut = new PictureBox();
            pbViewCart = new PictureBox();
            pbCheckOut = new PictureBox();
            pbInfo = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pbMenu = new PictureBox();
            pbAddItems = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbViewCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCheckOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddItems).BeginInit();
            SuspendLayout();
            // 
            // pbLogOut
            // 
            pbLogOut.Image = Properties.Resources.logout1;
            pbLogOut.Location = new Point(1090, 17);
            pbLogOut.Margin = new Padding(20, 3, 20, 3);
            pbLogOut.Name = "pbLogOut";
            pbLogOut.Size = new Size(44, 38);
            pbLogOut.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogOut.TabIndex = 17;
            pbLogOut.TabStop = false;
            pbLogOut.Click += pbLogOut_Click;
            pbLogOut.MouseEnter += pbLogOut_MouseEnter;
            pbLogOut.MouseLeave += pbLogOut_MouseLeave;
            // 
            // pbViewCart
            // 
            pbViewCart.Image = Properties.Resources.shopping_cart_empty_side_view;
            pbViewCart.Location = new Point(923, 17);
            pbViewCart.Margin = new Padding(20, 3, 20, 3);
            pbViewCart.Name = "pbViewCart";
            pbViewCart.Size = new Size(43, 38);
            pbViewCart.SizeMode = PictureBoxSizeMode.StretchImage;
            pbViewCart.TabIndex = 16;
            pbViewCart.TabStop = false;
            pbViewCart.Click += pbViewCart_Click;
            pbViewCart.MouseEnter += pbViewCart_MouseEnter;
            pbViewCart.MouseLeave += pbViewCart_MouseLeave;
            // 
            // pbCheckOut
            // 
            pbCheckOut.BackColor = Color.FromArgb(60, 100, 159);
            pbCheckOut.Image = Properties.Resources.checkout1;
            pbCheckOut.Location = new Point(836, 17);
            pbCheckOut.Margin = new Padding(20, 3, 20, 3);
            pbCheckOut.Name = "pbCheckOut";
            pbCheckOut.Size = new Size(47, 38);
            pbCheckOut.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCheckOut.TabIndex = 15;
            pbCheckOut.TabStop = false;
            pbCheckOut.Click += pbCheckOut_Click;
            pbCheckOut.MouseEnter += pbCheckOut_MouseEnter;
            pbCheckOut.MouseLeave += pbCheckOut_MouseLeave;
            // 
            // pbInfo
            // 
            pbInfo.Image = Properties.Resources.user1;
            pbInfo.Location = new Point(752, 17);
            pbInfo.Margin = new Padding(20, 3, 20, 3);
            pbInfo.Name = "pbInfo";
            pbInfo.Size = new Size(44, 38);
            pbInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInfo.TabIndex = 14;
            pbInfo.TabStop = false;
            pbInfo.Click += pbInfo_Click;
            pbInfo.MouseEnter += pbInfo_MouseEnter;
            pbInfo.MouseLeave += pbInfo_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.shopping_icon_2184065_1280;
            pictureBox1.Location = new Point(271, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 233, 255);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(272, 62);
            label1.TabIndex = 18;
            label1.Text = "CKM.SHOP";
            // 
            // pbMenu
            // 
            pbMenu.Image = Properties.Resources.menu;
            pbMenu.Location = new Point(668, 17);
            pbMenu.Margin = new Padding(20, 3, 20, 3);
            pbMenu.Name = "pbMenu";
            pbMenu.Size = new Size(44, 38);
            pbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMenu.TabIndex = 19;
            pbMenu.TabStop = false;
            pbMenu.Click += pbMenu_Click;
            pbMenu.MouseEnter += pbMenu_MouseEnter;
            pbMenu.MouseLeave += pbMenu_MouseLeave;
            // 
            // pbAddItems
            // 
            pbAddItems.Image = Properties.Resources.package_box;
            pbAddItems.Location = new Point(1006, 17);
            pbAddItems.Margin = new Padding(20, 3, 20, 3);
            pbAddItems.Name = "pbAddItems";
            pbAddItems.Size = new Size(44, 38);
            pbAddItems.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAddItems.TabIndex = 20;
            pbAddItems.TabStop = false;
            pbAddItems.Click += pbAddItems_Click;
            pbAddItems.MouseEnter += pbAddItems_MouseEnter;
            pbAddItems.MouseLeave += pbAddItems_MouseLeave;
            // 
            // UCMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 100, 159);
            Controls.Add(pbAddItems);
            Controls.Add(pbMenu);
            Controls.Add(label1);
            Controls.Add(pbLogOut);
            Controls.Add(pbViewCart);
            Controls.Add(pbCheckOut);
            Controls.Add(pbInfo);
            Controls.Add(pictureBox1);
            Name = "UCMenu";
            Size = new Size(1200, 91);
            ((System.ComponentModel.ISupportInitialize)pbLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbViewCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCheckOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogOut;
        private PictureBox pbViewCart;
        private PictureBox pbCheckOut;
        private PictureBox pbInfo;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pbMenu;
        private PictureBox pbAddItems;
    }
}
