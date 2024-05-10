namespace FinalProject_WinForm
{
    partial class PaymentSelect
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
            panel2 = new Panel();
            panel1 = new Panel();
            lbInfo = new Label();
            lbTotal = new Label();
            lbMethod = new Label();
            label3 = new Label();
            label2 = new Label();
            pbCASH = new PictureBox();
            pbPAYPAL = new PictureBox();
            pbVISA = new PictureBox();
            label1 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            btVoucher = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCASH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPAYPAL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVISA).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 100, 159);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(pbCASH);
            panel2.Controls.Add(pbPAYPAL);
            panel2.Controls.Add(pbVISA);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(btnCancel);
            panel2.Location = new Point(76, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 455);
            panel2.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btVoucher);
            panel1.Controls.Add(lbInfo);
            panel1.Controls.Add(lbTotal);
            panel1.Controls.Add(lbMethod);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(276, 107);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 235);
            panel1.TabIndex = 9;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.BackColor = Color.Transparent;
            lbInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbInfo.ForeColor = Color.Black;
            lbInfo.Location = new Point(132, 114);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(24, 28);
            lbInfo.TabIndex = 14;
            lbInfo.Text = "0";
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.BackColor = Color.Transparent;
            lbTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbTotal.ForeColor = Color.Black;
            lbTotal.Location = new Point(132, 76);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(24, 28);
            lbTotal.TabIndex = 13;
            lbTotal.Text = "0";
            // 
            // lbMethod
            // 
            lbMethod.AutoSize = true;
            lbMethod.BackColor = Color.Transparent;
            lbMethod.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbMethod.ForeColor = Color.FromArgb(60, 100, 159);
            lbMethod.Location = new Point(13, 114);
            lbMethod.Name = "lbMethod";
            lbMethod.Size = new Size(94, 28);
            lbMethod.TabIndex = 12;
            lbMethod.Text = "Card No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(60, 100, 159);
            label3.Location = new Point(13, 76);
            label3.Name = "label3";
            label3.Size = new Size(64, 28);
            label3.TabIndex = 11;
            label3.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(60, 100, 159);
            label2.Location = new Point(54, 24);
            label2.Name = "label2";
            label2.Size = new Size(222, 38);
            label2.TabIndex = 10;
            label2.Text = "PAYMENT INFO";
            // 
            // pbCASH
            // 
            pbCASH.BackColor = Color.White;
            pbCASH.Image = Properties.Resources.cash_on_delivery;
            pbCASH.Location = new Point(97, 280);
            pbCASH.Name = "pbCASH";
            pbCASH.Size = new Size(125, 62);
            pbCASH.SizeMode = PictureBoxSizeMode.Zoom;
            pbCASH.TabIndex = 8;
            pbCASH.TabStop = false;
            pbCASH.Click += pbCASH_Click;
            // 
            // pbPAYPAL
            // 
            pbPAYPAL.BackColor = Color.White;
            pbPAYPAL.Image = Properties.Resources.logo;
            pbPAYPAL.Location = new Point(97, 194);
            pbPAYPAL.Name = "pbPAYPAL";
            pbPAYPAL.Size = new Size(125, 62);
            pbPAYPAL.SizeMode = PictureBoxSizeMode.Zoom;
            pbPAYPAL.TabIndex = 7;
            pbPAYPAL.TabStop = false;
            pbPAYPAL.Click += pbPAYPAL_Click;
            // 
            // pbVISA
            // 
            pbVISA.BackColor = Color.White;
            pbVISA.Image = Properties.Resources.card;
            pbVISA.Location = new Point(97, 107);
            pbVISA.Name = "pbVISA";
            pbVISA.Size = new Size(125, 62);
            pbVISA.SizeMode = PictureBoxSizeMode.Zoom;
            pbVISA.TabIndex = 6;
            pbVISA.TabStop = false;
            pbVISA.Click += pbVISA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 233, 255);
            label1.Location = new Point(146, 28);
            label1.Name = "label1";
            label1.Size = new Size(364, 50);
            label1.TabIndex = 5;
            label1.Text = "PAYMENT METHOD";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 0, 64);
            btnConfirm.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.FromArgb(204, 233, 255);
            btnConfirm.Location = new Point(456, 377);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(141, 56);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 0, 64);
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(204, 233, 255);
            btnCancel.Location = new Point(97, 377);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 56);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCLE";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btVoucher
            // 
            btVoucher.BackColor = Color.FromArgb(0, 0, 64);
            btVoucher.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btVoucher.ForeColor = Color.FromArgb(204, 233, 255);
            btVoucher.Location = new Point(15, 156);
            btVoucher.Name = "btVoucher";
            btVoucher.Size = new Size(141, 56);
            btVoucher.TabIndex = 15;
            btVoucher.Text = "Voucher";
            btVoucher.UseVisualStyleBackColor = false;
            btVoucher.Click += this.btVoucher_Click;
            // 
            // PaymentSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            ControlBox = false;
            Controls.Add(panel2);
            Name = "PaymentSelect";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment Select";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCASH).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPAYPAL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVISA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button btnConfirm;
        private Button btnCancel;
        private PictureBox pbCASH;
        private PictureBox pbPAYPAL;
        private PictureBox pbVISA;
        private Panel panel1;
        private Label lbMethod;
        private Label label3;
        private Label label2;
        private Label lbTotal;
        private Label lbInfo;
        private Button btVoucher;
    }
}