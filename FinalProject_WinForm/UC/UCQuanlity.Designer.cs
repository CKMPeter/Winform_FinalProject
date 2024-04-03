namespace FinalProject_WinForm
{
    partial class UCQuanlity
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
            txtQuanlity = new TextBox();
            pbSubtract = new PictureBox();
            pbAdd = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbSubtract).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).BeginInit();
            SuspendLayout();
            // 
            // txtQuanlity
            // 
            txtQuanlity.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtQuanlity.Location = new Point(60, 31);
            txtQuanlity.Name = "txtQuanlity";
            txtQuanlity.PlaceholderText = "1";
            txtQuanlity.Size = new Size(57, 70);
            txtQuanlity.TabIndex = 0;
            txtQuanlity.Text = "1";
            txtQuanlity.TextAlign = HorizontalAlignment.Center;
            // 
            // pbSubtract
            // 
            pbSubtract.Image = Properties.Resources.minus;
            pbSubtract.Location = new Point(4, 31);
            pbSubtract.Name = "pbSubtract";
            pbSubtract.Size = new Size(50, 70);
            pbSubtract.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSubtract.TabIndex = 1;
            pbSubtract.TabStop = false;
            pbSubtract.Click += pbSubtract_Click;
            // 
            // pbAdd
            // 
            pbAdd.Image = Properties.Resources.add;
            pbAdd.Location = new Point(123, 31);
            pbAdd.Name = "pbAdd";
            pbAdd.Size = new Size(50, 70);
            pbAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAdd.TabIndex = 2;
            pbAdd.TabStop = false;
            pbAdd.Click += pbAdd_Click;
            // 
            // UCQuanlity
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pbAdd);
            Controls.Add(pbSubtract);
            Controls.Add(txtQuanlity);
            Name = "UCQuanlity";
            Size = new Size(195, 150);
            Load += UCQuanlity_Load;
            ((System.ComponentModel.ISupportInitialize)pbSubtract).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuanlity;
        private PictureBox pbSubtract;
        private PictureBox pbAdd;
    }
}
