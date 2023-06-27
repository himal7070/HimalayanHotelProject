namespace PresentationLayer.Views
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnLogout = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnCheckOut = new Button();
            btnBookings = new Button();
            btnRooms = new Button();
            btnEmployee = new Button();
            btnGuests = new Button();
            panel1 = new Panel();
            btnExit = new Button();
            btnDiscount = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.HotelDesktopLogo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlText;
            label3.Font = new Font("Book Antiqua", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(270, 20);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(419, 33);
            label3.TabIndex = 14;
            label3.Text = "Welcome To Himalayan Hotel";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.ActiveCaptionText;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = SystemColors.ControlLightLight;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.Location = new Point(850, 13);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(103, 45);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Log Out";
            btnLogout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(65, 15);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Himal Aryal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(65, 37);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.ErrorImage = (Image)resources.GetObject("pictureBox2.ErrorImage");
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 15);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(btnDiscount);
            panel2.Controls.Add(btnCheckOut);
            panel2.Controls.Add(btnBookings);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnRooms);
            panel2.Controls.Add(btnEmployee);
            panel2.Controls.Add(btnGuests);
            panel2.Location = new Point(1, 73);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 588);
            panel2.TabIndex = 17;
            // 
            // btnCheckOut
            // 
            btnCheckOut.FlatStyle = FlatStyle.Popup;
            btnCheckOut.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.Location = new Point(4, 448);
            btnCheckOut.Margin = new Padding(4, 3, 4, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(172, 66);
            btnCheckOut.TabIndex = 19;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnBookings
            // 
            btnBookings.FlatStyle = FlatStyle.Popup;
            btnBookings.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBookings.Location = new Point(3, 376);
            btnBookings.Margin = new Padding(4, 3, 4, 3);
            btnBookings.Name = "btnBookings";
            btnBookings.Size = new Size(172, 66);
            btnBookings.TabIndex = 13;
            btnBookings.Text = "Bookings";
            btnBookings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBookings.UseVisualStyleBackColor = true;
            btnBookings.Click += btnBookings_Click;
            // 
            // btnRooms
            // 
            btnRooms.BackColor = SystemColors.ControlDarkDark;
            btnRooms.FlatStyle = FlatStyle.Popup;
            btnRooms.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRooms.Location = new Point(3, 232);
            btnRooms.Margin = new Padding(4, 3, 4, 3);
            btnRooms.Name = "btnRooms";
            btnRooms.Size = new Size(172, 66);
            btnRooms.TabIndex = 9;
            btnRooms.Text = "Rooms";
            btnRooms.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRooms.UseVisualStyleBackColor = false;
            btnRooms.Click += btnRooms_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.FlatStyle = FlatStyle.Popup;
            btnEmployee.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEmployee.Location = new Point(4, 161);
            btnEmployee.Margin = new Padding(4, 3, 4, 3);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(172, 66);
            btnEmployee.TabIndex = 11;
            btnEmployee.Text = "Employees";
            btnEmployee.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnGuests
            // 
            btnGuests.FlatStyle = FlatStyle.Popup;
            btnGuests.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuests.Location = new Point(3, 304);
            btnGuests.Margin = new Padding(4, 3, 4, 3);
            btnGuests.Name = "btnGuests";
            btnGuests.Size = new Size(172, 66);
            btnGuests.TabIndex = 12;
            btnGuests.Text = "Guests";
            btnGuests.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuests.UseVisualStyleBackColor = true;
            btnGuests.Click += btnGuests_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(966, 73);
            panel1.TabIndex = 16;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.shutdown;
            btnExit.Location = new Point(904, 599);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 49);
            btnExit.TabIndex = 19;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.FlatStyle = FlatStyle.Popup;
            btnDiscount.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.Location = new Point(4, 519);
            btnDiscount.Margin = new Padding(4, 3, 4, 3);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(172, 66);
            btnDiscount.TabIndex = 20;
            btnDiscount.Text = "Discounts";
            btnDiscount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.HotelDesktop;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(966, 660);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Button btnLogout;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button btnBookings;
        private Button btnRooms;
        private Button btnGuests;
        private Button btnEmployee;
        private Panel panel1;
        private Button btnCheckOut;
        private Button btnExit;
        private Button btnDiscount;
    }
}