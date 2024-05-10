namespace FinalProject_WinForm
{
    partial class UCMyProduct
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
            pbItemPicture = new PictureBox();
            lbItemName = new Label();
            lbItemQuantity = new Label();
            pbMoreInfo = new PictureBox();
            pbDelete = new PictureBox();
            lbPrice = new Label();
            ((System.ComponentModel.ISupportInitialize)pbItemPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMoreInfo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).BeginInit();
            SuspendLayout();
            // 
            // pbItemPicture
            // 
            pbItemPicture.Location = new Point(20, 8);
            pbItemPicture.Name = "pbItemPicture";
            pbItemPicture.Size = new Size(130, 130);
            pbItemPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbItemPicture.TabIndex = 0;
            pbItemPicture.TabStop = false;
            // 
            // lbItemName
            // 
            lbItemName.AutoSize = true;
            lbItemName.Font = new Font("Segoe UI", 24.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbItemName.ForeColor = Color.FromArgb(204, 233, 255);
            lbItemName.Location = new Point(156, 8);
            lbItemName.Name = "lbItemName";
            lbItemName.Size = new Size(232, 57);
            lbItemName.TabIndex = 1;
            lbItemName.Text = "ItemName";
            // 
            // lbItemQuantity
            // 
            lbItemQuantity.AutoSize = true;
            lbItemQuantity.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbItemQuantity.ForeColor = Color.FromArgb(204, 233, 255);
            lbItemQuantity.Location = new Point(169, 88);
            lbItemQuantity.Name = "lbItemQuantity";
            lbItemQuantity.Size = new Size(103, 31);
            lbItemQuantity.TabIndex = 2;
            lbItemQuantity.Text = "Quantity";
            // 
            // pbMoreInfo
            // 
            pbMoreInfo.Image = Properties.Resources.information;
            pbMoreInfo.Location = new Point(599, 8);
            pbMoreInfo.Name = "pbMoreInfo";
            pbMoreInfo.Size = new Size(50, 50);
            pbMoreInfo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMoreInfo.TabIndex = 3;
            pbMoreInfo.TabStop = false;
            pbMoreInfo.Click += pbMoreInfo_Click;
            // 
            // pbDelete
            // 
            pbDelete.Image = Properties.Resources.trash_can;
            pbDelete.Location = new Point(599, 88);
            pbDelete.Name = "pbDelete";
            pbDelete.Size = new Size(50, 50);
            pbDelete.SizeMode = PictureBoxSizeMode.StretchImage;
            pbDelete.TabIndex = 4;
            pbDelete.TabStop = false;
            pbDelete.Click += pbDelete_Click;
            // 
            // txtPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lbPrice.ForeColor = Color.FromArgb(204, 233, 255);
            lbPrice.Location = new Point(394, 23);
            lbPrice.Name = "txtPrice";
            lbPrice.Size = new Size(74, 35);
            lbPrice.TabIndex = 5;
            lbPrice.Text = "Price";
            // 
            // UCMyProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 100, 159);
            Controls.Add(lbPrice);
            Controls.Add(pbDelete);
            Controls.Add(pbMoreInfo);
            Controls.Add(lbItemQuantity);
            Controls.Add(lbItemName);
            Controls.Add(pbItemPicture);
            Name = "UCMyProduct";
            Size = new Size(661, 148);
            Load += UCMyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pbItemPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMoreInfo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDelete).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbItemPicture;
        private Label lbItemName;
        private Label lbItemQuantity;
        private PictureBox pbMoreInfo;
        private PictureBox pbDelete;
        private Label lbPrice;
    }
}
