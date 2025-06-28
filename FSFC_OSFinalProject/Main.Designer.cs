namespace FSFC_OSFinalProject
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            btnConsultation = new Button();
            btnVaccination = new Button();
            btnLabTesting = new Button();
            btnBilling = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(681, 411);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnConsultation
            // 
            btnConsultation.BackColor = SystemColors.InactiveCaption;
            btnConsultation.FlatAppearance.BorderSize = 0;
            btnConsultation.FlatStyle = FlatStyle.Flat;
            btnConsultation.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultation.ForeColor = Color.FromArgb(0, 0, 64);
            btnConsultation.Location = new Point(41, 110);
            btnConsultation.Name = "btnConsultation";
            btnConsultation.Size = new Size(278, 125);
            btnConsultation.TabIndex = 2;
            btnConsultation.Text = "CONSULTATION";
            btnConsultation.UseVisualStyleBackColor = false;
            // 
            // btnVaccination
            // 
            btnVaccination.BackColor = SystemColors.InactiveCaption;
            btnVaccination.FlatAppearance.BorderSize = 0;
            btnVaccination.FlatStyle = FlatStyle.Flat;
            btnVaccination.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVaccination.ForeColor = Color.FromArgb(0, 0, 64);
            btnVaccination.Location = new Point(41, 259);
            btnVaccination.Name = "btnVaccination";
            btnVaccination.Size = new Size(278, 124);
            btnVaccination.TabIndex = 3;
            btnVaccination.Text = "VACCINATION";
            btnVaccination.UseVisualStyleBackColor = false;
            // 
            // btnLabTesting
            // 
            btnLabTesting.BackColor = SystemColors.InactiveCaption;
            btnLabTesting.FlatAppearance.BorderSize = 0;
            btnLabTesting.FlatStyle = FlatStyle.Flat;
            btnLabTesting.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLabTesting.ForeColor = Color.FromArgb(0, 0, 64);
            btnLabTesting.Location = new Point(363, 110);
            btnLabTesting.Name = "btnLabTesting";
            btnLabTesting.Size = new Size(276, 125);
            btnLabTesting.TabIndex = 4;
            btnLabTesting.Text = "LAB TESTING";
            btnLabTesting.UseVisualStyleBackColor = false;
            // 
            // btnBilling
            // 
            btnBilling.BackColor = SystemColors.InactiveCaption;
            btnBilling.FlatAppearance.BorderSize = 0;
            btnBilling.FlatStyle = FlatStyle.Flat;
            btnBilling.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBilling.ForeColor = Color.FromArgb(0, 0, 64);
            btnBilling.Location = new Point(363, 259);
            btnBilling.Name = "btnBilling";
            btnBilling.Size = new Size(276, 124);
            btnBilling.TabIndex = 5;
            btnBilling.Text = "BILLING";
            btnBilling.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(0, 0, 64);
            btnClose.Location = new Point(645, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 33);
            btnClose.TabIndex = 7;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 410);
            Controls.Add(btnClose);
            Controls.Add(btnBilling);
            Controls.Add(btnLabTesting);
            Controls.Add(btnVaccination);
            Controls.Add(btnConsultation);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnConsultation;
        private Button btnVaccination;
        private Button btnLabTesting;
        private Button btnBilling;
        private Button btnClose;
    }
}
