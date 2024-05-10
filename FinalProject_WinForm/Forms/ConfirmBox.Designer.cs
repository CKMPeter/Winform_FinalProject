namespace FinalProject_WinForm.C_
{
    partial class ConfirmBox
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
            txtReason = new TextBox();
            btnCancel = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btnConfirm = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtReason
            // 
            txtReason.BorderStyle = BorderStyle.None;
            txtReason.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtReason.Location = new Point(0, 3);
            txtReason.Name = "txtReason";
            txtReason.PasswordChar = '*';
            txtReason.PlaceholderText = "Please Tell Us Why? :(";
            txtReason.Size = new Size(446, 34);
            txtReason.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(0, 0, 64);
            btnCancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(204, 233, 255);
            btnCancel.Location = new Point(97, 285);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(141, 56);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCLE";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(204, 233, 255);
            label1.Location = new Point(177, 35);
            label1.Name = "label1";
            label1.Size = new Size(289, 50);
            label1.TabIndex = 5;
            label1.Text = "REMOVE ITEM?";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtReason);
            panel1.Location = new Point(97, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(446, 140);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(60, 100, 159);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnConfirm);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnCancel);
            panel2.Location = new Point(69, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 368);
            panel2.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(0, 0, 64);
            btnConfirm.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirm.ForeColor = Color.FromArgb(204, 233, 255);
            btnConfirm.Location = new Point(402, 285);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(141, 56);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // ConfirmBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Name = "ConfirmBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirm delete";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtReason;
        private Button btnCancel;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnConfirm;
    }
}