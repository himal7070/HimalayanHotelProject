namespace PresentationLayer.Views
{
    partial class Guests
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
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            tbCity = new TextBox();
            tbPostalCode = new TextBox();
            tbStreet = new TextBox();
            tbPassportNumber = new TextBox();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            tbGuestId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvGuest = new DataGridView();
            tbCountry = new TextBox();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvGuest).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(799, 460);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 69;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(799, 510);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 27);
            btnClear.TabIndex = 68;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(636, 510);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(636, 460);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 66;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(636, 335);
            tbCity.Margin = new Padding(4, 3, 4, 3);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(116, 23);
            tbCity.TabIndex = 65;
            // 
            // tbPostalCode
            // 
            tbPostalCode.Location = new Point(796, 335);
            tbPostalCode.Margin = new Padding(4, 3, 4, 3);
            tbPostalCode.Name = "tbPostalCode";
            tbPostalCode.Size = new Size(116, 23);
            tbPostalCode.TabIndex = 64;
            // 
            // tbStreet
            // 
            tbStreet.Location = new Point(636, 406);
            tbStreet.Margin = new Padding(4, 3, 4, 3);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(116, 23);
            tbStreet.TabIndex = 63;
            // 
            // tbPassportNumber
            // 
            tbPassportNumber.Location = new Point(796, 265);
            tbPassportNumber.Margin = new Padding(4, 3, 4, 3);
            tbPassportNumber.Name = "tbPassportNumber";
            tbPassportNumber.Size = new Size(116, 23);
            tbPassportNumber.TabIndex = 62;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(636, 265);
            tbPhone.Margin = new Padding(4, 3, 4, 3);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(116, 23);
            tbPhone.TabIndex = 61;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(636, 205);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(276, 23);
            tbEmail.TabIndex = 60;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(796, 143);
            tbLastName.Margin = new Padding(4, 3, 4, 3);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(116, 23);
            tbLastName.TabIndex = 59;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(636, 143);
            tbFirstName.Margin = new Padding(4, 3, 4, 3);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(116, 23);
            tbFirstName.TabIndex = 58;
            // 
            // tbGuestId
            // 
            tbGuestId.Enabled = false;
            tbGuestId.Location = new Point(636, 77);
            tbGuestId.Margin = new Padding(4, 3, 4, 3);
            tbGuestId.Name = "tbGuestId";
            tbGuestId.Size = new Size(61, 23);
            tbGuestId.TabIndex = 57;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(633, 316);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 56;
            label9.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(792, 316);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 55;
            label8.Text = "Postal Code";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(633, 388);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 54;
            label7.Text = "Street";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(792, 247);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 53;
            label6.Text = "Passport Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(633, 247);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 52;
            label5.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(633, 187);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 51;
            label4.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(792, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 50;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(633, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 49;
            label2.Text = "First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(633, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 48;
            label1.Text = "GuestId";
            // 
            // dgvGuest
            // 
            dgvGuest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGuest.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvGuest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuest.Location = new Point(13, 59);
            dgvGuest.Margin = new Padding(4, 3, 4, 3);
            dgvGuest.Name = "dgvGuest";
            dgvGuest.Size = new Size(597, 478);
            dgvGuest.TabIndex = 47;
            dgvGuest.CellClick += dgvGuest_CellClick;
         
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(796, 406);
            tbCountry.Margin = new Padding(4, 3, 4, 3);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(116, 23);
            tbCountry.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(793, 388);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(50, 15);
            label10.TabIndex = 70;
            label10.Text = "Country";
            // 
            // Guests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(940, 573);
            Controls.Add(tbCountry);
            Controls.Add(label10);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(tbCity);
            Controls.Add(tbPostalCode);
            Controls.Add(tbStreet);
            Controls.Add(tbPassportNumber);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(tbGuestId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvGuest);
            Name = "Guests";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guests";
            Load += Guests_Load;
            ((System.ComponentModel.ISupportInitialize)dgvGuest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox tbCity;
        private TextBox tbPostalCode;
        private TextBox tbStreet;
        private TextBox tbPassportNumber;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private TextBox tbGuestId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvGuest;
        private TextBox tbCountry;
        private Label label10;
    }
}