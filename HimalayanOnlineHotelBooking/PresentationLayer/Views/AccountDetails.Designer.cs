namespace PresentationLayer.Views
{
    partial class AccountDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountDetails));
            lblPassword = new Label();
            lblUserName = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnOk = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(150, 200);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 78;
            lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(154, 118);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(65, 15);
            lblUserName.TabIndex = 77;
            lblUserName.Text = "User Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.ForeColor = SystemColors.ButtonShadow;
            panel2.Location = new Point(154, 241);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(192, 1);
            panel2.TabIndex = 76;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.ForeColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(154, 156);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 1);
            panel1.TabIndex = 75;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(113, 128);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 74;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(112, 213);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(102, 76);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(255, 50);
            label1.TabIndex = 72;
            label1.Text = "Your Account Details\r\n\r\n";
            // 
            // tbPassword
            // 
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(154, 219);
            tbPassword.Margin = new Padding(4, 3, 4, 3);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(192, 17);
            tbPassword.TabIndex = 71;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.Location = new Point(154, 136);
            tbUsername.Margin = new Padding(4, 3, 4, 3);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(192, 17);
            tbUsername.TabIndex = 70;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(211, 289);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 36);
            btnOk.TabIndex = 79;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(79, 51);
            label2.Name = "label2";
            label2.Size = new Size(309, 15);
            label2.TabIndex = 80;
            label2.Text = "You can change your password first time when you login.\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(143, 23);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 81;
            label3.Text = "Your Account has been created. ";
            // 
            // AccountDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 337);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnOk);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Name = "AccountDetails";
            Text = "AccountDetails";
            Load += AccountDetails_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private Label lblUserName;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Button btnOk;
        private Label label2;
        private Label label3;
    }
}