namespace FinalProject_WinForm.Forms
{
    partial class Voucher
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
            dgvVoucher = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).BeginInit();
            SuspendLayout();
            // 
            // dgvVoucher
            // 
            dgvVoucher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVoucher.Location = new Point(52, 39);
            dgvVoucher.Name = "dgvVoucher";
            dgvVoucher.RowHeadersWidth = 51;
            dgvVoucher.RowTemplate.Height = 29;
            dgvVoucher.Size = new Size(688, 367);
            dgvVoucher.TabIndex = 0;
            // 
            // Voucher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVoucher);
            Name = "Voucher";
            Text = "Vouher";
            Load += this.Voucher_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVoucher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVoucher;
    }
}