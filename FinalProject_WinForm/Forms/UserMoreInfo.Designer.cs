namespace FinalProject_WinForm
{
    partial class UserMoreInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMoreInfo));
            pbUserAvatar = new PictureBox();
            pictureBox2 = new PictureBox();
            ucMenu1 = new UCMenu();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ucGender = new UCCheckBox();
            pbUpload = new PictureBox();
            pbUpdateAvatar = new PictureBox();
            txtVisa = new TextBox();
            txtPaypal = new TextBox();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbUserAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAvatar).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pbUserAvatar
            // 
            pbUserAvatar.Image = (Image)resources.GetObject("pbUserAvatar.Image");
            pbUserAvatar.Location = new Point(144, 127);
            pbUserAvatar.Name = "pbUserAvatar";
            pbUserAvatar.Size = new Size(240, 240);
            pbUserAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUserAvatar.TabIndex = 13;
            pbUserAvatar.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._31958787_v915_techi_006_k;
            pictureBox2.Location = new Point(-5, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1200, 710);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // ucMenu1
            // 
            ucMenu1.BackColor = Color.FromArgb(60, 100, 159);
            ucMenu1.Location = new Point(-5, -2);
            ucMenu1.Name = "ucMenu1";
            ucMenu1.Size = new Size(1500, 114);
            ucMenu1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(343, 0);
            label1.Name = "label1";
            label1.Size = new Size(630, 81);
            label1.TabIndex = 15;
            label1.Text = "Personal Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(471, 105);
            label2.Margin = new Padding(3, 20, 3, 10);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 16;
            label2.Text = "User Name:";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(584, 95);
            txtName.Margin = new Padding(3, 20, 3, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(389, 38);
            txtName.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(471, 168);
            label3.Margin = new Padding(3, 0, 3, 10);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 18;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(471, 229);
            label4.Margin = new Padding(3, 0, 3, 10);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 19;
            label4.Text = "Email:";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(584, 158);
            txtPassword.Margin = new Padding(3, 20, 3, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(389, 38);
            txtPassword.TabIndex = 20;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(584, 219);
            txtEmail.Margin = new Padding(3, 20, 3, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(389, 38);
            txtEmail.TabIndex = 21;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(584, 266);
            txtAddress.Margin = new Padding(3, 20, 3, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(389, 38);
            txtAddress.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(471, 276);
            label5.Margin = new Padding(3, 0, 3, 10);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 23;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(471, 355);
            label6.Margin = new Padding(3, 0, 3, 10);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 24;
            label6.Text = "Gender:";
            // 
            // ucGender
            // 
            ucGender.Femaleimage = null;
            ucGender.Location = new Point(537, 333);
            ucGender.Maleimage = null;
            ucGender.Name = "ucGender";
            ucGender.Otherimage = null;
            ucGender.Size = new Size(436, 56);
            ucGender.TabIndex = 25;
            // 
            // pbUpload
            // 
            pbUpload.Image = Properties.Resources.up_loading;
            pbUpload.Location = new Point(923, 408);
            pbUpload.Name = "pbUpload";
            pbUpload.Size = new Size(50, 50);
            pbUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpload.TabIndex = 27;
            pbUpload.TabStop = false;
            pbUpload.Click += pbUpload_Click;
            // 
            // pbUpdateAvatar
            // 
            pbUpdateAvatar.Image = (Image)resources.GetObject("pbUpdateAvatar.Image");
            pbUpdateAvatar.Location = new Point(55, 141);
            pbUpdateAvatar.Name = "pbUpdateAvatar";
            pbUpdateAvatar.Size = new Size(50, 50);
            pbUpdateAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpdateAvatar.TabIndex = 28;
            pbUpdateAvatar.TabStop = false;
            pbUpdateAvatar.Click += pbUpdateAvatar_Click;
            // 
            // txtVisa
            // 
            txtVisa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtVisa.Location = new Point(132, 219);
            txtVisa.Margin = new Padding(3, 20, 3, 3);
            txtVisa.Name = "txtVisa";
            txtVisa.Size = new Size(316, 38);
            txtVisa.TabIndex = 29;
            // 
            // txtPaypal
            // 
            txtPaypal.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPaypal.Location = new Point(132, 266);
            txtPaypal.Margin = new Padding(3, 20, 3, 3);
            txtPaypal.Name = "txtPaypal";
            txtPaypal.Size = new Size(316, 38);
            txtPaypal.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(58, 229);
            label7.Margin = new Padding(3, 0, 3, 10);
            label7.Name = "label7";
            label7.Size = new Size(47, 23);
            label7.TabIndex = 31;
            label7.Text = "Visa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(55, 276);
            label8.Margin = new Padding(3, 0, 3, 10);
            label8.Name = "label8";
            label8.Size = new Size(67, 23);
            label8.TabIndex = 32;
            label8.Text = "PayPal:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtPaypal);
            panel2.Controls.Add(txtVisa);
            panel2.Controls.Add(pbUpdateAvatar);
            panel2.Controls.Add(pbUpload);
            panel2.Controls.Add(ucGender);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(89, 232);
            panel2.Name = "panel2";
            panel2.Size = new Size(993, 478);
            panel2.TabIndex = 0;
            // 
            // UserMoreInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(pbUserAvatar);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(ucMenu1);
            Name = "UserMoreInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMoreInfo";
            ((System.ComponentModel.ISupportInitialize)pbUserAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpload).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUpdateAvatar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnUpdUser;
        private PictureBox pbUserAvatar;
        private Button btnMainReturn;
        private PictureBox pictureBox2;
        private UCMenu ucMenu1;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private Label label5;
        private Label label6;
        private UCCheckBox ucGender;
        private PictureBox pbUpload;
        private PictureBox pbUpdateAvatar;
        private TextBox txtVisa;
        private TextBox txtPaypal;
        private Label label7;
        private Label label8;
        private Panel panel2;
    }
}