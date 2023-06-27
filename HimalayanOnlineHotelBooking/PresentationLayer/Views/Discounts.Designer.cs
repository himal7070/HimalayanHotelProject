namespace PresentationLayer.Views
{
    partial class Discounts
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
            dgvDiscount = new DataGridView();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            tbDiscountId = new TextBox();
            tbDiscountOfferName = new TextBox();
            tbDiscountDetails = new TextBox();
            cbDiscountRate = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dtpStartDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dtpExpiryDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).BeginInit();
            SuspendLayout();
            // 
            // dgvDiscount
            // 
            dgvDiscount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiscount.Location = new Point(421, 38);
            dgvDiscount.Name = "dgvDiscount";
            dgvDiscount.RowTemplate.Height = 25;
            dgvDiscount.Size = new Size(521, 395);
            dgvDiscount.TabIndex = 0;
            dgvDiscount.CellClick += dgvDiscount_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(301, 347);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 64;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(301, 397);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 27);
            btnClear.TabIndex = 63;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(137, 397);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 62;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(137, 347);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 61;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbDiscountId
            // 
            tbDiscountId.Enabled = false;
            tbDiscountId.Location = new Point(85, 38);
            tbDiscountId.Name = "tbDiscountId";
            tbDiscountId.Size = new Size(56, 23);
            tbDiscountId.TabIndex = 65;
            // 
            // tbDiscountOfferName
            // 
            tbDiscountOfferName.Location = new Point(137, 79);
            tbDiscountOfferName.Name = "tbDiscountOfferName";
            tbDiscountOfferName.Size = new Size(231, 23);
            tbDiscountOfferName.TabIndex = 66;
            // 
            // tbDiscountDetails
            // 
            tbDiscountDetails.Location = new Point(138, 119);
            tbDiscountDetails.Multiline = true;
            tbDiscountDetails.Name = "tbDiscountDetails";
            tbDiscountDetails.Size = new Size(230, 82);
            tbDiscountDetails.TabIndex = 67;
            // 
            // cbDiscountRate
            // 
            cbDiscountRate.FormattingEnabled = true;
            cbDiscountRate.Items.AddRange(new object[] { "5", "10", "20", "25", "30", "40" });
            cbDiscountRate.Location = new Point(138, 212);
            cbDiscountRate.Name = "cbDiscountRate";
            cbDiscountRate.Size = new Size(121, 23);
            cbDiscountRate.TabIndex = 68;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 69;
            label1.Text = "Discount Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 70;
            label2.Text = "Discount Offer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 119);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 71;
            label3.Text = "Discount Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 215);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 72;
            label4.Text = "Discount Rate %";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(137, 250);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 73;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 258);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 74;
            label5.Text = "Start Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 298);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 75;
            label6.Text = "Expiry Date";
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(137, 292);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(200, 23);
            dtpExpiryDate.TabIndex = 76;
            // 
            // Discounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 455);
            Controls.Add(dtpExpiryDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpStartDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbDiscountRate);
            Controls.Add(tbDiscountDetails);
            Controls.Add(tbDiscountOfferName);
            Controls.Add(tbDiscountId);
            Controls.Add(btnUpdate);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvDiscount);
            Name = "Discounts";
            Text = "Discounts";
            Load += Discounts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDiscount;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox tbDiscountId;
        private TextBox tbDiscountOfferName;
        private TextBox tbDiscountDetails;
        private ComboBox cbDiscountRate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpStartDate;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpExpiryDate;
    }
}