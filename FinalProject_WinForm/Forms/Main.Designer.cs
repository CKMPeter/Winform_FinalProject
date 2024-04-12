namespace FinalProject_WinForm
{
    partial class HomePage
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
            tbSearch = new TextBox();
            pbSearch = new PictureBox();
            pictureBox2 = new PictureBox();
            cbCatagory = new ComboBox();
            ucMenu1 = new UCMenu();
            ((System.ComponentModel.ISupportInitialize)pbSearch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // flpList
            // 
            flpList.AutoScroll = true;
            flpList.BackColor = Color.White;
            flpList.Location = new Point(64, 224);
            flpList.Name = "flpList";
            flpList.Size = new Size(1063, 466);
            flpList.TabIndex = 6;
            // 
            // tbSearch
            // 
            tbSearch.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbSearch.ForeColor = SystemColors.InfoText;
            tbSearch.Location = new Point(336, 128);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search";
            tbSearch.Size = new Size(711, 65);
            tbSearch.TabIndex = 7;
            // 
            // pbSearch
            // 
            pbSearch.BackColor = Color.White;
            pbSearch.Image = Properties.Resources.search2;
            pbSearch.Location = new Point(1062, 128);
            pbSearch.Name = "pbSearch";
            pbSearch.Size = new Size(65, 65);
            pbSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSearch.TabIndex = 8;
            pbSearch.TabStop = false;
            pbSearch.Click += pbSearch_Click;
            pbSearch.MouseEnter += pbSearch_MouseEnter;
            pbSearch.MouseLeave += pbSearch_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox2.Location = new Point(-10, 85);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1200, 688);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // cbCatagory
            // 
            cbCatagory.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            cbCatagory.FormattingEnabled = true;
            cbCatagory.Items.AddRange(new object[] { "Decoratives", "Electronics", "Furnitures", "Favorites" });
            cbCatagory.Location = new Point(64, 128);
            cbCatagory.Name = "cbCatagory";
            cbCatagory.Size = new Size(266, 65);
            cbCatagory.TabIndex = 11;
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-10, -8);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1200, 94);
            ucMenu1.TabIndex = 12;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(ucMenu1);
            Controls.Add(cbCatagory);
            Controls.Add(pbSearch);
            Controls.Add(tbSearch);
            Controls.Add(flpList);
            Controls.Add(pictureBox2);
            ForeColor = Color.FromArgb(204, 233, 255);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)pbSearch).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flpList;
        private TextBox tbSearch;
        private PictureBox pbSearch;
        private PictureBox pictureBox2;
        private ComboBox cbCatagory;
        private UCMenu ucMenu1;
    }
}