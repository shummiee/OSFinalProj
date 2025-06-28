namespace FSFC_OSFinalProject
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(681, 414);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(291, 177);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(192, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(291, 226);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 0, 64);
            button1.Location = new Point(301, 268);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 410);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
    }
}