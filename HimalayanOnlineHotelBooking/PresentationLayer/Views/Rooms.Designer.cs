namespace PresentationLayer.Views
{
    partial class Rooms
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tbRoomId = new TextBox();
            label1 = new Label();
            btnUpdate = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            cbAvailability = new ComboBox();
            cbRoomType = new ComboBox();
            tbRoomNo = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgvRoom = new DataGridView();
            tabPage2 = new TabPage();
            tbDescription = new TextBox();
            tbCost = new TextBox();
            tbName = new TextBox();
            tbRoomTypeId = new TextBox();
            btnUpdateRoomType = new Button();
            btnClearRoomType = new Button();
            btnDeleteRoomType = new Button();
            btnAddRoomType = new Button();
            label6 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            dgvRoomType = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomType).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(918, 495);
            tabControl1.TabIndex = 46;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientActiveCaption;
            tabPage1.Controls.Add(tbRoomId);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnClear);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(cbAvailability);
            tabPage1.Controls.Add(cbRoomType);
            tabPage1.Controls.Add(tbRoomNo);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dgvRoom);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(910, 467);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Room";
            // 
            // tbRoomId
            // 
            tbRoomId.Enabled = false;
            tbRoomId.Location = new Point(612, 52);
            tbRoomId.Margin = new Padding(4, 3, 4, 3);
            tbRoomId.Name = "tbRoomId";
            tbRoomId.Size = new Size(61, 23);
            tbRoomId.TabIndex = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(609, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 61;
            label1.Text = "Room Id";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(773, 327);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 60;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(773, 377);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 27);
            btnClear.TabIndex = 59;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(609, 377);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(609, 327);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 57;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbAvailability
            // 
            cbAvailability.FormattingEnabled = true;
            cbAvailability.Items.AddRange(new object[] { "Yes", "No" });
            cbAvailability.Location = new Point(612, 257);
            cbAvailability.Margin = new Padding(4, 3, 4, 3);
            cbAvailability.Name = "cbAvailability";
            cbAvailability.Size = new Size(140, 23);
            cbAvailability.TabIndex = 55;
            // 
            // cbRoomType
            // 
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(612, 186);
            cbRoomType.Margin = new Padding(4, 3, 4, 3);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(140, 23);
            cbRoomType.TabIndex = 54;
            // 
            // tbRoomNo
            // 
            tbRoomNo.Location = new Point(612, 122);
            tbRoomNo.Margin = new Padding(4, 3, 4, 3);
            tbRoomNo.Name = "tbRoomNo";
            tbRoomNo.Size = new Size(116, 23);
            tbRoomNo.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(615, 168);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 50;
            label4.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(612, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 48;
            label2.Text = "Room No.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(615, 239);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 49;
            label3.Text = "Availability";
            // 
            // dgvRoom
            // 
            dgvRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoom.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoom.Location = new Point(31, 33);
            dgvRoom.Margin = new Padding(4, 3, 4, 3);
            dgvRoom.Name = "dgvRoom";
            dgvRoom.Size = new Size(543, 407);
            dgvRoom.TabIndex = 46;
            dgvRoom.CellClick += dgvRoom_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientActiveCaption;
            tabPage2.Controls.Add(tbDescription);
            tabPage2.Controls.Add(tbCost);
            tabPage2.Controls.Add(tbName);
            tabPage2.Controls.Add(tbRoomTypeId);
            tabPage2.Controls.Add(btnUpdateRoomType);
            tabPage2.Controls.Add(btnClearRoomType);
            tabPage2.Controls.Add(btnDeleteRoomType);
            tabPage2.Controls.Add(btnAddRoomType);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(dgvRoomType);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(910, 467);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Room Type";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(599, 175);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(282, 145);
            tbDescription.TabIndex = 69;
            // 
            // tbCost
            // 
            tbCost.Location = new Point(599, 135);
            tbCost.Name = "tbCost";
            tbCost.Size = new Size(165, 23);
            tbCost.TabIndex = 68;
            // 
            // tbName
            // 
            tbName.Location = new Point(599, 90);
            tbName.Name = "tbName";
            tbName.Size = new Size(165, 23);
            tbName.TabIndex = 66;
            // 
            // tbRoomTypeId
            // 
            tbRoomTypeId.Enabled = false;
            tbRoomTypeId.Location = new Point(599, 49);
            tbRoomTypeId.Name = "tbRoomTypeId";
            tbRoomTypeId.Size = new Size(61, 23);
            tbRoomTypeId.TabIndex = 65;
            // 
            // btnUpdateRoomType
            // 
            btnUpdateRoomType.Location = new Point(763, 344);
            btnUpdateRoomType.Margin = new Padding(4, 3, 4, 3);
            btnUpdateRoomType.Name = "btnUpdateRoomType";
            btnUpdateRoomType.Size = new Size(112, 27);
            btnUpdateRoomType.TabIndex = 64;
            btnUpdateRoomType.Text = "Update";
            btnUpdateRoomType.UseVisualStyleBackColor = true;
            btnUpdateRoomType.Click += btnUpdateRoomType_Click;
            // 
            // btnClearRoomType
            // 
            btnClearRoomType.Location = new Point(763, 394);
            btnClearRoomType.Margin = new Padding(4, 3, 4, 3);
            btnClearRoomType.Name = "btnClearRoomType";
            btnClearRoomType.Size = new Size(112, 27);
            btnClearRoomType.TabIndex = 63;
            btnClearRoomType.Text = "Clear";
            btnClearRoomType.UseVisualStyleBackColor = true;
            btnClearRoomType.Click += btnClearRoomType_Click;
            // 
            // btnDeleteRoomType
            // 
            btnDeleteRoomType.Location = new Point(599, 394);
            btnDeleteRoomType.Margin = new Padding(4, 3, 4, 3);
            btnDeleteRoomType.Name = "btnDeleteRoomType";
            btnDeleteRoomType.Size = new Size(112, 27);
            btnDeleteRoomType.TabIndex = 62;
            btnDeleteRoomType.Text = "Delete";
            btnDeleteRoomType.UseVisualStyleBackColor = true;
            btnDeleteRoomType.Click += btnDeleteRoomType_Click;
            // 
            // btnAddRoomType
            // 
            btnAddRoomType.Location = new Point(599, 344);
            btnAddRoomType.Margin = new Padding(4, 3, 4, 3);
            btnAddRoomType.Name = "btnAddRoomType";
            btnAddRoomType.Size = new Size(112, 27);
            btnAddRoomType.TabIndex = 61;
            btnAddRoomType.Text = "Add";
            btnAddRoomType.UseVisualStyleBackColor = true;
            btnAddRoomType.Click += btnAddRoomType_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 175);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 60;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(515, 140);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 59;
            label7.Text = "Cost";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(513, 90);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 57;
            label9.Text = "Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(513, 49);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 56;
            label10.Text = "Room Type Id";
            // 
            // dgvRoomType
            // 
            dgvRoomType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoomType.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvRoomType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomType.Location = new Point(30, 49);
            dgvRoomType.Name = "dgvRoomType";
            dgvRoomType.RowTemplate.Height = 25;
            dgvRoomType.Size = new Size(464, 372);
            dgvRoomType.TabIndex = 55;
            dgvRoomType.CellClick += dgvRoomType_CellClick;

            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(942, 542);
            Controls.Add(tabControl1);
            Name = "Rooms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rooms";
            Load += Rooms_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoomType).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnDelete;
        private Button btnAdd;
        private ComboBox cbAvailability;
        private ComboBox cbRoomType;
        private TextBox tbRoomNo;
        private Label label4;
        private Label label2;
        private Label label3;
        private DataGridView dgvRoom;
        private TabPage tabPage2;
        private TextBox tbDescription;
        private TextBox tbCost;
        private TextBox tbName;
        private TextBox tbRoomTypeId;
        private Button btnUpdateRoomType;
        private Button btnClearRoomType;
        private Button btnDeleteRoomType;
        private Button btnAddRoomType;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private DataGridView dgvRoomType;
        private TextBox tbRoomId;
        private Label label1;
    }
}