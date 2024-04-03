namespace FinalProject_WinForm
{
    partial class UCItems
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
            lbProductPrice = new Label();
            lbProductDiscription = new Label();
            btnDetail = new Button();
            lbProductName = new Label();
            pbProduct = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // lbProductPrice
            // 
            lbProductPrice.AutoSize = true;
            lbProductPrice.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductPrice.ForeColor = Color.FromArgb(204, 233, 255);
            lbProductPrice.Location = new Point(21, 347);
            lbProductPrice.Name = "lbProductPrice";
            lbProductPrice.Size = new Size(100, 39);
            lbProductPrice.TabIndex = 10;
            lbProductPrice.Text = "Price";
            lbProductPrice.MouseEnter += Items_MouseEnter;
            lbProductPrice.MouseLeave += Items_MouseLeave;
            // 
            // lbProductDiscription
            // 
            lbProductDiscription.AutoSize = true;
            lbProductDiscription.BackColor = Color.Transparent;
            lbProductDiscription.FlatStyle = FlatStyle.Flat;
            lbProductDiscription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbProductDiscription.ForeColor = Color.FromArgb(204, 233, 255);
            lbProductDiscription.Location = new Point(21, 303);
            lbProductDiscription.Name = "lbProductDiscription";
            lbProductDiscription.Size = new Size(107, 28);
            lbProductDiscription.TabIndex = 9;
            lbProductDiscription.Text = "Discription";
            lbProductDiscription.MouseEnter += Items_MouseEnter;
            lbProductDiscription.MouseLeave += Items_MouseLeave;
            // 
            // btnDetail
            // 
            btnDetail.BackColor = Color.FromArgb(0, 0, 64);
            btnDetail.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDetail.ForeColor = Color.FromArgb(204, 233, 255);
            btnDetail.Location = new Point(174, 350);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(110, 43);
            btnDetail.TabIndex = 8;
            btnDetail.Text = "Read More";
            btnDetail.UseVisualStyleBackColor = false;
            btnDetail.Click += btnDetail_Click;
            btnDetail.MouseEnter += Items_MouseEnter;
            btnDetail.MouseLeave += Items_MouseLeave;
            // 
            // lbProductName
            // 
            lbProductName.AutoSize = true;
            lbProductName.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbProductName.ForeColor = Color.FromArgb(204, 233, 255);
            lbProductName.Location = new Point(21, 21);
            lbProductName.Name = "lbProductName";
            lbProductName.Size = new Size(83, 46);
            lbProductName.TabIndex = 6;
            lbProductName.Text = "test";
            lbProductName.MouseEnter += Items_MouseEnter;
            lbProductName.MouseLeave += Items_MouseLeave;
            // 
            // pbProduct
            // 
            pbProduct.Location = new Point(21, 70);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(263, 230);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 7;
            pbProduct.TabStop = false;
            pbProduct.MouseEnter += Items_MouseEnter;
            pbProduct.MouseLeave += Items_MouseLeave;
            // 
            // UCItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 100, 159);
            Controls.Add(lbProductPrice);
            Controls.Add(lbProductDiscription);
            Controls.Add(btnDetail);
            Controls.Add(pbProduct);
            Controls.Add(lbProductName);
            Name = "UCItems";
            Size = new Size(312, 436);
            MouseEnter += Items_MouseEnter;
            MouseLeave += Items_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbProductPrice;
        private Label lbProductDiscription;
        private Button btnDetail;
        private Label lbProductName;
        private PictureBox pbProduct;
    }
}
