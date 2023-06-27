namespace PresentationLayer.Views
{
    partial class Employees
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
            tbCountry = new TextBox();
            label8 = new Label();
            cbDesignation = new ComboBox();
            label6 = new Label();
            label1 = new Label();
            cbDepartments = new ComboBox();
            tbCity = new TextBox();
            tbPostalCode = new TextBox();
            tbStreet = new TextBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            btnUpdateEmployee = new Button();
            btnClearFields = new Button();
            btnDeleteEmployee = new Button();
            btnAddEmployee = new Button();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbLastName = new TextBox();
            tbFirstName = new TextBox();
            tbEmployeeId = new TextBox();
            label15 = new Label();
            dtpJoiningDate = new DateTimePicker();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            dgvEmployees = new DataGridView();
            tabPage2 = new TabPage();
            tbSalary = new TextBox();
            label7 = new Label();
            tbDepartmentDesc = new TextBox();
            tbDepartmentName = new TextBox();
            btnUpdateDepartments = new Button();
            btnClearDepartments = new Button();
            btnDeleteDepartments = new Button();
            btnAddDepartments = new Button();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            dgvDepartment = new DataGridView();
            tbDepartmentId = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1068, 623);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.GradientActiveCaption;
            tabPage1.Controls.Add(tbCountry);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(cbDesignation);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(cbDepartments);
            tabPage1.Controls.Add(tbCity);
            tabPage1.Controls.Add(tbPostalCode);
            tabPage1.Controls.Add(tbStreet);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(btnUpdateEmployee);
            tabPage1.Controls.Add(btnClearFields);
            tabPage1.Controls.Add(btnDeleteEmployee);
            tabPage1.Controls.Add(btnAddEmployee);
            tabPage1.Controls.Add(tbEmail);
            tabPage1.Controls.Add(tbPhone);
            tabPage1.Controls.Add(tbLastName);
            tabPage1.Controls.Add(tbFirstName);
            tabPage1.Controls.Add(tbEmployeeId);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(dtpJoiningDate);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(dgvEmployees);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1060, 595);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add Employees";
            // 
            // tbCountry
            // 
            tbCountry.Location = new Point(687, 290);
            tbCountry.Margin = new Padding(4, 3, 4, 3);
            tbCountry.Name = "tbCountry";
            tbCountry.Size = new Size(116, 23);
            tbCountry.TabIndex = 135;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(687, 272);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 134;
            label8.Text = "Country";
            // 
            // cbDesignation
            // 
            cbDesignation.FormattingEnabled = true;
            cbDesignation.Items.AddRange(new object[] { "Satff", "Inetrn", "Manager", "Assistant" });
            cbDesignation.Location = new Point(862, 348);
            cbDesignation.Name = "cbDesignation";
            cbDesignation.Size = new Size(113, 23);
            cbDesignation.TabIndex = 133;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(859, 330);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 132;
            label6.Text = "Designation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(687, 330);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 129;
            label1.Text = "Departments";
            // 
            // cbDepartments
            // 
            cbDepartments.FormattingEnabled = true;
            cbDepartments.Location = new Point(687, 348);
            cbDepartments.Name = "cbDepartments";
            cbDepartments.Size = new Size(152, 23);
            cbDepartments.TabIndex = 128;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(859, 180);
            tbCity.Margin = new Padding(4, 3, 4, 3);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(116, 23);
            tbCity.TabIndex = 127;
            // 
            // tbPostalCode
            // 
            tbPostalCode.Location = new Point(687, 239);
            tbPostalCode.Margin = new Padding(4, 3, 4, 3);
            tbPostalCode.Name = "tbPostalCode";
            tbPostalCode.Size = new Size(116, 23);
            tbPostalCode.TabIndex = 126;
            // 
            // tbStreet
            // 
            tbStreet.Location = new Point(860, 239);
            tbStreet.Margin = new Padding(4, 3, 4, 3);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(116, 23);
            tbStreet.TabIndex = 125;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(860, 161);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 124;
            label12.Text = "City";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(687, 221);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 123;
            label13.Text = "Postal Code";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(860, 221);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 122;
            label14.Text = "Street";
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(888, 467);
            btnUpdateEmployee.Margin = new Padding(4, 3, 4, 3);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(88, 27);
            btnUpdateEmployee.TabIndex = 121;
            btnUpdateEmployee.Text = "Update";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.Location = new Point(888, 517);
            btnClearFields.Margin = new Padding(4, 3, 4, 3);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(88, 27);
            btnClearFields.TabIndex = 120;
            btnClearFields.Text = "Clear";
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(683, 517);
            btnDeleteEmployee.Margin = new Padding(4, 3, 4, 3);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(88, 27);
            btnDeleteEmployee.TabIndex = 119;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(683, 467);
            btnAddEmployee.Margin = new Padding(4, 3, 4, 3);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(88, 27);
            btnAddEmployee.TabIndex = 118;
            btnAddEmployee.Text = "Add";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(860, 124);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(178, 23);
            tbEmail.TabIndex = 117;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(687, 180);
            tbPhone.Margin = new Padding(4, 3, 4, 3);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(116, 23);
            tbPhone.TabIndex = 116;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(687, 124);
            tbLastName.Margin = new Padding(4, 3, 4, 3);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(116, 23);
            tbLastName.TabIndex = 115;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(859, 67);
            tbFirstName.Margin = new Padding(4, 3, 4, 3);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(116, 23);
            tbFirstName.TabIndex = 114;
            // 
            // tbEmployeeId
            // 
            tbEmployeeId.Location = new Point(687, 67);
            tbEmployeeId.Margin = new Padding(4, 3, 4, 3);
            tbEmployeeId.Name = "tbEmployeeId";
            tbEmployeeId.Size = new Size(70, 23);
            tbEmployeeId.TabIndex = 113;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(687, 400);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(72, 15);
            label15.TabIndex = 112;
            label15.Text = "Joining Date";
            // 
            // dtpJoiningDate
            // 
            dtpJoiningDate.Location = new Point(691, 418);
            dtpJoiningDate.Margin = new Padding(4, 3, 4, 3);
            dtpJoiningDate.Name = "dtpJoiningDate";
            dtpJoiningDate.Size = new Size(233, 23);
            dtpJoiningDate.TabIndex = 111;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(683, 161);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(63, 15);
            label16.TabIndex = 110;
            label16.Text = "Phone No.";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(860, 105);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(36, 15);
            label17.TabIndex = 109;
            label17.Text = "Email";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(687, 105);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(63, 15);
            label18.TabIndex = 108;
            label18.Text = "Last Name";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(859, 48);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(64, 15);
            label19.TabIndex = 107;
            label19.Text = "First Name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(683, 48);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(69, 15);
            label20.TabIndex = 106;
            label20.Text = "EmployeeId";
            // 
            // dgvEmployees
            // 
            dgvEmployees.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(24, 48);
            dgvEmployees.Margin = new Padding(4, 3, 4, 3);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.Size = new Size(634, 499);
            dgvEmployees.TabIndex = 105;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientActiveCaption;
            tabPage2.Controls.Add(tbSalary);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(tbDepartmentDesc);
            tabPage2.Controls.Add(tbDepartmentName);
            tabPage2.Controls.Add(btnUpdateDepartments);
            tabPage2.Controls.Add(btnClearDepartments);
            tabPage2.Controls.Add(btnDeleteDepartments);
            tabPage2.Controls.Add(btnAddDepartments);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(dgvDepartment);
            tabPage2.Controls.Add(tbDepartmentId);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1060, 595);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Department";
            // 
            // tbSalary
            // 
            tbSalary.Location = new Point(708, 284);
            tbSalary.Name = "tbSalary";
            tbSalary.Size = new Size(140, 23);
            tbSalary.TabIndex = 102;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(597, 292);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 101;
            label7.Text = "Salary";
            // 
            // tbDepartmentDesc
            // 
            tbDepartmentDesc.Location = new Point(708, 165);
            tbDepartmentDesc.Multiline = true;
            tbDepartmentDesc.Name = "tbDepartmentDesc";
            tbDepartmentDesc.Size = new Size(277, 96);
            tbDepartmentDesc.TabIndex = 100;
            // 
            // tbDepartmentName
            // 
            tbDepartmentName.Location = new Point(708, 116);
            tbDepartmentName.Name = "tbDepartmentName";
            tbDepartmentName.Size = new Size(183, 23);
            tbDepartmentName.TabIndex = 99;
            // 
            // btnUpdateDepartments
            // 
            btnUpdateDepartments.Location = new Point(803, 345);
            btnUpdateDepartments.Margin = new Padding(4, 3, 4, 3);
            btnUpdateDepartments.Name = "btnUpdateDepartments";
            btnUpdateDepartments.Size = new Size(88, 27);
            btnUpdateDepartments.TabIndex = 98;
            btnUpdateDepartments.Text = "Update";
            btnUpdateDepartments.UseVisualStyleBackColor = true;
            btnUpdateDepartments.Click += btnUpdateDepartments_Click;
            // 
            // btnClearDepartments
            // 
            btnClearDepartments.Location = new Point(803, 395);
            btnClearDepartments.Margin = new Padding(4, 3, 4, 3);
            btnClearDepartments.Name = "btnClearDepartments";
            btnClearDepartments.Size = new Size(88, 27);
            btnClearDepartments.TabIndex = 97;
            btnClearDepartments.Text = "Clear";
            btnClearDepartments.UseVisualStyleBackColor = true;
            btnClearDepartments.Click += btnClearDepartments_Click;
            // 
            // btnDeleteDepartments
            // 
            btnDeleteDepartments.Location = new Point(597, 395);
            btnDeleteDepartments.Margin = new Padding(4, 3, 4, 3);
            btnDeleteDepartments.Name = "btnDeleteDepartments";
            btnDeleteDepartments.Size = new Size(88, 27);
            btnDeleteDepartments.TabIndex = 96;
            btnDeleteDepartments.Text = "Delete";
            btnDeleteDepartments.UseVisualStyleBackColor = true;
            btnDeleteDepartments.Click += btnDeleteDepartments_Click;
            // 
            // btnAddDepartments
            // 
            btnAddDepartments.Location = new Point(597, 345);
            btnAddDepartments.Margin = new Padding(4, 3, 4, 3);
            btnAddDepartments.Name = "btnAddDepartments";
            btnAddDepartments.Size = new Size(88, 27);
            btnAddDepartments.TabIndex = 95;
            btnAddDepartments.Text = "Add";
            btnAddDepartments.UseVisualStyleBackColor = true;
            btnAddDepartments.Click += btnAddDepartments_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(597, 168);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 94;
            label4.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 124);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 93;
            label2.Text = "Department Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(597, 79);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 92;
            label5.Text = "Department Id";
            // 
            // dgvDepartment
            // 
            dgvDepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartment.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDepartment.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvDepartment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartment.Location = new Point(32, 79);
            dgvDepartment.Name = "dgvDepartment";
            dgvDepartment.RowTemplate.Height = 25;
            dgvDepartment.Size = new Size(516, 343);
            dgvDepartment.TabIndex = 91;
            dgvDepartment.CellClick += dgvDepartment_CellClick;
            // 
            // tbDepartmentId
            // 
            tbDepartmentId.Enabled = false;
            tbDepartmentId.Location = new Point(708, 76);
            tbDepartmentId.Name = "tbDepartmentId";
            tbDepartmentId.Size = new Size(61, 23);
            tbDepartmentId.TabIndex = 90;
            // 
            // Employees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1092, 647);
            Controls.Add(tabControl1);
            Name = "Employees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += Employees_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cbDesignation;
        private Label label6;
        private TextBox tbSalary;
        private Label label3;
        private Label label1;
        private ComboBox cbDepartments;
        private TextBox tbCity;
        private TextBox tbPostalCode;
        private TextBox tbStreet;
        private Label label12;
        private Label label13;
        private Label label14;
        private Button btnUpdateEmployee;
        private Button btnClearFields;
        private Button btnDeleteEmployee;
        private Button btnAddEmployee;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbLastName;
        private TextBox tbFirstName;
        private TextBox tbEmployeeId;
        private Label label15;
        private DateTimePicker dtpJoiningDate;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private DataGridView dgvEmployees;
        private TextBox tbDepartmentDesc;
        private TextBox tbDepartmentName;
        private Button btnUpdateDepartments;
        private Button btnClearDepartments;
        private Button btnDeleteDepartments;
        private Button btnAddDepartments;
        private Label label4;
        private Label label2;
        private Label label5;
        private DataGridView dgvDepartment;
        private TextBox tbDepartmentId;

        private Label label7;
        private TextBox tbCountry;
        private Label label8;
    }
}