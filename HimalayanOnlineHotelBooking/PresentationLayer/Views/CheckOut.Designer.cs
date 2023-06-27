namespace PresentationLayer.Views
{
    partial class CheckOut
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
            dgvPayment = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbPaymentId = new TextBox();
            cbBookingId = new ComboBox();
            cbPaymentType = new ComboBox();
            tbStatus = new TextBox();
            tbTotalAmount = new TextBox();
            btnPay = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPayment).BeginInit();
            SuspendLayout();
            // 
            // dgvPayment
            // 
            dgvPayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayment.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayment.Location = new Point(239, 66);
            dgvPayment.Name = "dgvPayment";
            dgvPayment.RowTemplate.Height = 25;
            dgvPayment.Size = new Size(549, 370);
            dgvPayment.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 66);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Payment Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 128);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Booking Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 186);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "Payment Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 247);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 334);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 5;
            label5.Text = "Total Amount To Pay";
            // 
            // tbPaymentId
            // 
            tbPaymentId.Enabled = false;
            tbPaymentId.Location = new Point(21, 84);
            tbPaymentId.Name = "tbPaymentId";
            tbPaymentId.Size = new Size(67, 23);
            tbPaymentId.TabIndex = 6;
            // 
            // cbBookingId
            // 
            cbBookingId.FormattingEnabled = true;
            cbBookingId.Location = new Point(21, 146);
            cbBookingId.Name = "cbBookingId";
            cbBookingId.Size = new Size(121, 23);
            cbBookingId.TabIndex = 7;
            cbBookingId.SelectedIndexChanged += cbBookingId_SelectedIndexChanged;
            // 
            // cbPaymentType
            // 
            cbPaymentType.FormattingEnabled = true;
            cbPaymentType.Items.AddRange(new object[] { "Debit Card", "Credit Card", "Cash" });
            cbPaymentType.Location = new Point(21, 204);
            cbPaymentType.Name = "cbPaymentType";
            cbPaymentType.Size = new Size(121, 23);
            cbPaymentType.TabIndex = 8;
            // 
            // tbStatus
            // 
            tbStatus.Enabled = false;
            tbStatus.Location = new Point(21, 265);
            tbStatus.Name = "tbStatus";
            tbStatus.Size = new Size(100, 23);
            tbStatus.TabIndex = 9;
            tbStatus.Text = "Paid";
            // 
            // tbTotalAmount
            // 
            tbTotalAmount.Location = new Point(21, 352);
            tbTotalAmount.Name = "tbTotalAmount";
            tbTotalAmount.Size = new Size(116, 23);
            tbTotalAmount.TabIndex = 10;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(21, 413);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 11;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(133, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // CheckOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 502);
            Controls.Add(btnClear);
            Controls.Add(btnPay);
            Controls.Add(tbTotalAmount);
            Controls.Add(tbStatus);
            Controls.Add(cbPaymentType);
            Controls.Add(cbBookingId);
            Controls.Add(tbPaymentId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPayment);
            Name = "CheckOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckOut";
            Load += CheckOut_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPayment;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbPaymentId;
        private ComboBox cbBookingId;
        private ComboBox cbPaymentType;
        private TextBox tbStatus;
        private TextBox tbTotalAmount;
        private Button btnPay;
        private Button btnClear;
    }
}