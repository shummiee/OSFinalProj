namespace FSFC_OSFinalProject
{
    partial class Queue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Queue));
            pictureBox1 = new PictureBox();
            txtConsultation = new Label();
            txtLabTesting = new Label();
            txtVaccination = new Label();
            txtBilling = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(681, 413);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtConsultation
            // 
            txtConsultation.AutoSize = true;
            txtConsultation.BackColor = Color.Transparent;
            txtConsultation.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConsultation.ForeColor = SystemColors.ControlLight;
            txtConsultation.Location = new Point(157, 91);
            txtConsultation.Name = "txtConsultation";
            txtConsultation.Size = new Size(34, 47);
            txtConsultation.TabIndex = 1;
            txtConsultation.Text = "-";
            // 
            // txtLabTesting
            // 
            txtLabTesting.AutoSize = true;
            txtLabTesting.BackColor = Color.Transparent;
            txtLabTesting.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLabTesting.ForeColor = Color.FromArgb(0, 0, 64);
            txtLabTesting.Location = new Point(479, 91);
            txtLabTesting.Name = "txtLabTesting";
            txtLabTesting.Size = new Size(34, 47);
            txtLabTesting.TabIndex = 2;
            txtLabTesting.Text = "-";
            // 
            // txtVaccination
            // 
            txtVaccination.AutoSize = true;
            txtVaccination.BackColor = Color.Transparent;
            txtVaccination.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVaccination.ForeColor = Color.FromArgb(0, 0, 64);
            txtVaccination.Location = new Point(157, 269);
            txtVaccination.Name = "txtVaccination";
            txtVaccination.Size = new Size(34, 47);
            txtVaccination.TabIndex = 3;
            txtVaccination.Text = "-";
            // 
            // txtBilling
            // 
            txtBilling.AutoSize = true;
            txtBilling.BackColor = Color.Transparent;
            txtBilling.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBilling.ForeColor = SystemColors.ControlLight;
            txtBilling.Location = new Point(479, 269);
            txtBilling.Name = "txtBilling";
            txtBilling.Size = new Size(34, 47);
            txtBilling.TabIndex = 4;
            txtBilling.Text = "-";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.FromArgb(0, 0, 64);
            btnClose.Location = new Point(644, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 33);
            btnClose.TabIndex = 7;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // Queue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 410);
            Controls.Add(btnClose);
            Controls.Add(txtBilling);
            Controls.Add(txtVaccination);
            Controls.Add(txtLabTesting);
            Controls.Add(txtConsultation);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Queue";
            Text = "Queue";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtConsultation;
        private Label txtLabTesting;
        private Label txtVaccination;
        private Label txtBilling;
        private Button btnClose;
    }
}