namespace FinalProject_WinForm
{
    partial class UCCheckBox
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
            pbMale = new PictureBox();
            pbFemale = new PictureBox();
            pbOther = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbMale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFemale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbOther).BeginInit();
            SuspendLayout();
            // 
            // pbMale
            // 
            pbMale.Image = Properties.Resources.blank_check_box;
            pbMale.Location = new Point(43, 17);
            pbMale.Name = "pbMale";
            pbMale.Size = new Size(30, 30);
            pbMale.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMale.TabIndex = 0;
            pbMale.TabStop = false;
            pbMale.Click += pbMale_Click;
            // 
            // pbFemale
            // 
            pbFemale.Image = Properties.Resources.blank_check_box;
            pbFemale.Location = new Point(170, 17);
            pbFemale.Name = "pbFemale";
            pbFemale.Size = new Size(30, 30);
            pbFemale.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFemale.TabIndex = 1;
            pbFemale.TabStop = false;
            pbFemale.Click += pbFemale_Click;
            // 
            // pbOther
            // 
            pbOther.Image = Properties.Resources.checkbox;
            pbOther.Location = new Point(308, 19);
            pbOther.Name = "pbOther";
            pbOther.Size = new Size(30, 30);
            pbOther.SizeMode = PictureBoxSizeMode.StretchImage;
            pbOther.TabIndex = 2;
            pbOther.TabStop = false;
            pbOther.Click += pbOther_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(79, 19);
            label1.Name = "label1";
            label1.Size = new Size(59, 28);
            label1.TabIndex = 3;
            label1.Text = "Male";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(206, 19);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 4;
            label2.Text = "Female";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(344, 21);
            label3.Name = "label3";
            label3.Size = new Size(66, 28);
            label3.TabIndex = 5;
            label3.Text = "Other";
            // 
            // UCCheckBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbOther);
            Controls.Add(pbFemale);
            Controls.Add(pbMale);
            Name = "UCCheckBox";
            Size = new Size(449, 70);
            ((System.ComponentModel.ISupportInitialize)pbMale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFemale).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbOther).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbMale;
        private PictureBox pbFemale;
        private PictureBox pbOther;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
