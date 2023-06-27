namespace PresentationLayer.Views
{
    partial class Bookings
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
            dateTimeCheckOut = new DateTimePicker();
            label7 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            dateTimeCheckIn = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            tbBookingId = new TextBox();
            label1 = new Label();
            dgvBooking = new DataGridView();
            tbTotalCost = new TextBox();
            label8 = new Label();
            cbRoomType = new ComboBox();
            cbGuestId = new ComboBox();
            cbDiscountName = new ComboBox();
            label4 = new Label();
            lblStayDuration = new Label();
            label9 = new Label();
            btnCalculateTotalCost = new Button();
            tbRoomId = new TextBox();
            btnFind = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            SuspendLayout();
            // 
            // dateTimeCheckOut
            // 
            dateTimeCheckOut.Location = new Point(664, 189);
            dateTimeCheckOut.Margin = new Padding(4, 3, 4, 3);
            dateTimeCheckOut.Name = "dateTimeCheckOut";
            dateTimeCheckOut.Size = new Size(233, 23);
            dateTimeCheckOut.TabIndex = 67;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(661, 171);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 66;
            label7.Text = "Check-Out Date";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(851, 466);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 65;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(851, 516);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 27);
            btnClear.TabIndex = 64;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(661, 516);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 63;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(661, 466);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 62;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(661, 234);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 60;
            label6.Text = "Room Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(664, 296);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 58;
            label5.Text = "Available Discount ";
            // 
            // dateTimeCheckIn
            // 
            dateTimeCheckIn.Location = new Point(664, 129);
            dateTimeCheckIn.Margin = new Padding(4, 3, 4, 3);
            dateTimeCheckIn.Name = "dateTimeCheckIn";
            dateTimeCheckIn.Size = new Size(233, 23);
            dateTimeCheckIn.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(661, 111);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 54;
            label3.Text = "Check-In Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(824, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 52;
            label2.Text = "GuestId";
            // 
            // tbBookingId
            // 
            tbBookingId.Enabled = false;
            tbBookingId.Location = new Point(661, 66);
            tbBookingId.Margin = new Padding(4, 3, 4, 3);
            tbBookingId.Name = "tbBookingId";
            tbBookingId.Size = new Size(58, 23);
            tbBookingId.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(658, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 50;
            label1.Text = "BookingId";
            // 
            // dgvBooking
            // 
            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooking.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooking.Location = new Point(13, 47);
            dgvBooking.Margin = new Padding(4, 3, 4, 3);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.Size = new Size(618, 496);
            dgvBooking.TabIndex = 49;
            dgvBooking.CellClick += dgvBooking_CellClick;
            // 
            // tbTotalCost
            // 
            tbTotalCost.Location = new Point(661, 417);
            tbTotalCost.Margin = new Padding(4, 3, 4, 3);
            tbTotalCost.Name = "tbTotalCost";
            tbTotalCost.Size = new Size(116, 23);
            tbTotalCost.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(661, 399);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 68;
            label8.Text = "Total Cost";
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(664, 252);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(121, 23);
            cbRoomType.TabIndex = 71;
            cbRoomType.SelectedIndexChanged += cbRoomType_SelectedIndexChanged;
            // 
            // cbGuestId
            // 
            cbGuestId.FormattingEnabled = true;
            cbGuestId.Items.AddRange(new object[] { "Checked In", "Checked Out" });
            cbGuestId.Location = new Point(824, 65);
            cbGuestId.Name = "cbGuestId";
            cbGuestId.Size = new Size(115, 23);
            cbGuestId.TabIndex = 72;
            // 
            // cbDiscountName
            // 
            cbDiscountName.FormattingEnabled = true;
            cbDiscountName.Location = new Point(664, 314);
            cbDiscountName.Name = "cbDiscountName";
            cbDiscountName.Size = new Size(181, 23);
            cbDiscountName.TabIndex = 73;
            cbDiscountName.SelectedIndexChanged += cbDiscountName_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(661, 367);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 74;
            label4.Text = "Stay Duration :";
            // 
            // lblStayDuration
            // 
            lblStayDuration.AutoSize = true;
            lblStayDuration.Location = new Point(754, 367);
            lblStayDuration.Name = "lblStayDuration";
            lblStayDuration.Size = new Size(0, 15);
            lblStayDuration.TabIndex = 75;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(827, 234);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 76;
            label9.Text = "Room Id";
            // 
            // btnCalculateTotalCost
            // 
            btnCalculateTotalCost.Location = new Point(851, 363);
            btnCalculateTotalCost.Name = "btnCalculateTotalCost";
            btnCalculateTotalCost.Size = new Size(88, 27);
            btnCalculateTotalCost.TabIndex = 79;
            btnCalculateTotalCost.Text = "Get Total Cost";
            btnCalculateTotalCost.UseVisualStyleBackColor = true;
            btnCalculateTotalCost.Click += btnCalculateTotalCost_Click;
            // 
            // tbRoomId
            // 
            tbRoomId.Enabled = false;
            tbRoomId.Location = new Point(827, 252);
            tbRoomId.Margin = new Padding(4, 3, 4, 3);
            tbRoomId.Name = "tbRoomId";
            tbRoomId.Size = new Size(70, 23);
            tbRoomId.TabIndex = 80;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(13, 12);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(170, 23);
            btnFind.TabIndex = 81;
            btnFind.Text = "Find Guest Booking Info";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // Bookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1014, 565);
            Controls.Add(btnFind);
            Controls.Add(tbRoomId);
            Controls.Add(btnCalculateTotalCost);
            Controls.Add(label9);
            Controls.Add(lblStayDuration);
            Controls.Add(label4);
            Controls.Add(cbDiscountName);
            Controls.Add(cbGuestId);
            Controls.Add(cbRoomType);
            Controls.Add(tbTotalCost);
            Controls.Add(label8);
            Controls.Add(dateTimeCheckOut);
            Controls.Add(label7);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dateTimeCheckIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbBookingId);
            Controls.Add(label1);
            Controls.Add(dgvBooking);
            Name = "Bookings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookings";
            Load += Bookings_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeCheckOut;
        private Label label7;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimeCheckIn;
        private Label label3;
        private Label label2;
        private TextBox tbBookingId;
        private Label label1;
        private DataGridView dgvBooking;
        private TextBox tbTotalCost;
        private Label label8;
        private ComboBox cbRoomType;
        private ComboBox cbGuestId;
        private ComboBox cbDiscountName;
        private Label label4;
        private Label lblStayDuration;
        private Label label9;
        private Button btnCalculateTotalCost;
        private TextBox tbRoomId;
        private Button btnFind;
    }
}