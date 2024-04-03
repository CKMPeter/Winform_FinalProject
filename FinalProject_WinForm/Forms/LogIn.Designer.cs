namespace FinalProject_WinForm
{
    partial class FormEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntry));
            btnLogin = new Button();
            btnSUp = new Button();
            panel1 = new Panel();
            lbMode = new Label();
            ucLogin = new UCLogin();
            btnLogSign_Main = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbCopyRight = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(60, 100, 159);
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.FromArgb(204, 233, 255);
            btnLogin.Location = new Point(436, 90);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 40);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSUp
            // 
            btnSUp.BackColor = Color.LightGray;
            btnSUp.FlatAppearance.BorderColor = Color.LightGray;
            btnSUp.FlatAppearance.BorderSize = 0;
            btnSUp.FlatStyle = FlatStyle.Flat;
            btnSUp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSUp.Location = new Point(523, 90);
            btnSUp.Name = "btnSUp";
            btnSUp.Size = new Size(90, 40);
            btnSUp.TabIndex = 3;
            btnSUp.Text = "Sign Up";
            btnSUp.UseVisualStyleBackColor = false;
            btnSUp.Click += btnSUp_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 100, 159);
            panel1.Controls.Add(lbMode);
            panel1.Controls.Add(ucLogin);
            panel1.Controls.Add(btnLogSign_Main);
            panel1.Location = new Point(436, 127);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 320);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // lbMode
            // 
            lbMode.AutoSize = true;
            lbMode.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbMode.ForeColor = Color.FromArgb(204, 233, 255);
            lbMode.Location = new Point(109, 38);
            lbMode.Name = "lbMode";
            lbMode.Size = new Size(175, 67);
            lbMode.TabIndex = 6;
            lbMode.Text = "Login.";
            // 
            // ucLogin
            // 
            ucLogin.Location = new Point(20, 103);
            ucLogin.Name = "ucLogin";
            ucLogin.Size = new Size(347, 111);
            ucLogin.TabIndex = 5;
            ucLogin.Load += ucLogin1_Load;
            // 
            // btnLogSign_Main
            // 
            btnLogSign_Main.BackColor = Color.FromArgb(0, 0, 64);
            btnLogSign_Main.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogSign_Main.ForeColor = Color.FromArgb(204, 233, 255);
            btnLogSign_Main.Location = new Point(156, 232);
            btnLogSign_Main.Name = "btnLogSign_Main";
            btnLogSign_Main.Size = new Size(90, 40);
            btnLogSign_Main.TabIndex = 5;
            btnLogSign_Main.Text = "Login";
            btnLogSign_Main.UseVisualStyleBackColor = false;
            btnLogSign_Main.Click += btnLogSign_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(btnSUp);
            panel2.Location = new Point(159, 109);
            panel2.Margin = new Padding(150, 100, 150, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(864, 535);
            panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.shopping_icon_2184065_1280;
            pictureBox2.Location = new Point(36, 90);
            pictureBox2.Margin = new Padding(3, 90, 3, 90);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(377, 357);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-6, -6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1195, 766);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lbCopyRight
            // 
            lbCopyRight.AutoSize = true;
            lbCopyRight.BackColor = Color.Transparent;
            lbCopyRight.FlatStyle = FlatStyle.Flat;
            lbCopyRight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbCopyRight.Location = new Point(900, 724);
            lbCopyRight.Name = "lbCopyRight";
            lbCopyRight.Size = new Size(274, 20);
            lbCopyRight.TabIndex = 7;
            lbCopyRight.Text = "All Rights Reserved to Cao Khải Minh.\r\n";
            // 
            // FormEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 753);
            Controls.Add(lbCopyRight);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "FormEntry";
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Button btnSUp;
        private Panel panel1;
        private Button btnLogSign_Main;
        private UCLogin ucLogin;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lbMode;
        private Label lbCopyRight;
        private PictureBox pictureBox2;
    }
}