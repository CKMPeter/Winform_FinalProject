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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProduct));
            flpList = new FlowLayoutPanel();
            ucMenu1 = new UCMenu();
            lbSellerName = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lbNumberProducts = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flpList
            // 
            resources.ApplyResources(flpList, "flpList");
            flpList.BackColor = Color.White;
            flpList.Name = "flpList";
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            resources.ApplyResources(ucMenu1, "ucMenu1");
            ucMenu1.Name = "ucMenu1";
            // 
            // lbSellerName
            // 
            resources.ApplyResources(lbSellerName, "lbSellerName");
            lbSellerName.ForeColor = Color.FromArgb(204, 233, 255);
            lbSellerName.Name = "lbSellerName";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(204, 233, 255);
            label1.Name = "label1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 100, 159);
            panel1.Controls.Add(lbNumberProducts);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbSellerName);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // lbNumberProducts
            // 
            resources.ApplyResources(lbNumberProducts, "lbNumberProducts");
            lbNumberProducts.ForeColor = Color.FromArgb(204, 233, 255);
            lbNumberProducts.Name = "lbNumberProducts";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31958787_v915_techi_006_k;
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // MyProduct
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(flpList);
            Controls.Add(pictureBox2);
            Controls.Add(ucMenu1);
            Name = "MyProduct";
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