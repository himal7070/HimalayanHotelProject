namespace PresentationLayer.Views
{
    partial class FindGuestBookingInfo
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
            tbBookingId = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            lblBookingInfo = new Label();
            SuspendLayout();
            // 
            // tbBookingId
            // 
            tbBookingId.Location = new Point(82, 54);
            tbBookingId.Name = "tbBookingId";
            tbBookingId.Size = new Size(100, 23);
            tbBookingId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 2;
            label1.Text = "Booking Id";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(202, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblBookingInfo
            // 
            lblBookingInfo.AutoSize = true;
            lblBookingInfo.Location = new Point(12, 136);
            lblBookingInfo.Name = "lblBookingInfo";
            lblBookingInfo.Size = new Size(14, 15);
            lblBookingInfo.TabIndex = 5;
            lblBookingInfo.Text = "B";
            // 
            // FindGuestBookingInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(653, 450);
            Controls.Add(lblBookingInfo);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(tbBookingId);
            Name = "FindGuestBookingInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FindGuestBookingInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbBookingId;
        private Label label1;
        private Button btnSearch;
        private Label lblBookingInfo;
    }
}