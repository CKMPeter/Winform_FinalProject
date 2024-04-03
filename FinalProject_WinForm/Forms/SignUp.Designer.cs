namespace FinalProject_WinForm
{
    partial class SignUp
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
            btnReturn = new Button();
            btnSignUp = new Button();
            label1 = new Label();
            ucLogin1 = new UCLogin();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReturn
            // 
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.Location = new Point(229, 214);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(76, 40);
            btnReturn.TabIndex = 7;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.Location = new Point(81, 214);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(76, 40);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(97, 29);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 5;
            label1.Text = "SIGN UP.";
            // 
            // ucLogin1
            // 
            ucLogin1.Location = new Point(-15, 88);
            ucLogin1.Name = "ucLogin1";
            ucLogin1.Size = new Size(384, 120);
            ucLogin1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 128);
            panel1.Controls.Add(btnReturn);
            panel1.Controls.Add(ucLogin1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSignUp);
            panel1.Location = new Point(393, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(379, 274);
            panel1.TabIndex = 8;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SignUp";
            Text = "SignUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnReturn;
        private Button btnSignUp;
        private Label label1;
        private UCLogin ucLogin1;
        private Panel panel1;
    }
}