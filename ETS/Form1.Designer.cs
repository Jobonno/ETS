namespace ETS
{
    partial class Form1
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
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Manage = new System.Windows.Forms.TabPage();
            this.btnAddTimesheet = new System.Windows.Forms.Button();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpWorkedDate = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.dtpDOB2 = new System.Windows.Forms.DateTimePicker();
            this.txtEmail2 = new System.Windows.Forms.TextBox();
            this.txtLastName2 = new System.Windows.Forms.TextBox();
            this.txtFirstName2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lstboxEmployees = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnTotalHours = new System.Windows.Forms.Button();
            this.lstboxReport = new System.Windows.Forms.ListBox();
            this.lstBoxEmployeesReport = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.Add.SuspendLayout();
            this.Manage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(204, 284);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.Add);
            this.tabControl1.Controls.Add(this.Manage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(10, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(649, 360);
            this.tabControl1.TabIndex = 1;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.label8);
            this.Home.Controls.Add(this.label7);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Size = new System.Drawing.Size(641, 334);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Joseph Bonifacio 2016";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(167, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Employees Tracking System";
            // 
            // Add
            // 
            this.Add.Controls.Add(this.label6);
            this.Add.Controls.Add(this.btnClear);
            this.Add.Controls.Add(this.dtpDOB);
            this.Add.Controls.Add(this.txtPhone);
            this.Add.Controls.Add(this.label5);
            this.Add.Controls.Add(this.label4);
            this.Add.Controls.Add(this.txtEmail);
            this.Add.Controls.Add(this.label3);
            this.Add.Controls.Add(this.txtLastName);
            this.Add.Controls.Add(this.label2);
            this.Add.Controls.Add(this.txtFirstName);
            this.Add.Controls.Add(this.label1);
            this.Add.Controls.Add(this.btnSave);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Add.Size = new System.Drawing.Size(641, 334);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "New Employee Details";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(336, 284);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 25);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(215, 205);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(228, 22);
            this.dtpDOB.TabIndex = 11;
            this.dtpDOB.Value = new System.DateTime(1979, 1, 1, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(260, 258);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(260, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "DOB:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(260, 155);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(260, 115);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(260, 74);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // Manage
            // 
            this.Manage.Controls.Add(this.btnAddTimesheet);
            this.Manage.Controls.Add(this.txtHours);
            this.Manage.Controls.Add(this.label16);
            this.Manage.Controls.Add(this.label15);
            this.Manage.Controls.Add(this.dtpWorkedDate);
            this.Manage.Controls.Add(this.lblID);
            this.Manage.Controls.Add(this.btnUpdate);
            this.Manage.Controls.Add(this.txtPhone2);
            this.Manage.Controls.Add(this.dtpDOB2);
            this.Manage.Controls.Add(this.txtEmail2);
            this.Manage.Controls.Add(this.txtLastName2);
            this.Manage.Controls.Add(this.txtFirstName2);
            this.Manage.Controls.Add(this.label14);
            this.Manage.Controls.Add(this.label13);
            this.Manage.Controls.Add(this.label12);
            this.Manage.Controls.Add(this.label11);
            this.Manage.Controls.Add(this.label10);
            this.Manage.Controls.Add(this.label9);
            this.Manage.Controls.Add(this.lstboxEmployees);
            this.Manage.Location = new System.Drawing.Point(4, 22);
            this.Manage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Manage.Name = "Manage";
            this.Manage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Manage.Size = new System.Drawing.Size(641, 334);
            this.Manage.TabIndex = 2;
            this.Manage.Text = "Manage";
            this.Manage.UseVisualStyleBackColor = true;
            // 
            // btnAddTimesheet
            // 
            this.btnAddTimesheet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimesheet.Location = new System.Drawing.Point(457, 207);
            this.btnAddTimesheet.Name = "btnAddTimesheet";
            this.btnAddTimesheet.Size = new System.Drawing.Size(131, 23);
            this.btnAddTimesheet.TabIndex = 20;
            this.btnAddTimesheet.Text = "Save Timesheet";
            this.btnAddTimesheet.UseVisualStyleBackColor = true;
            this.btnAddTimesheet.Click += new System.EventHandler(this.btnAddTimesheet_Click);
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHours.Location = new System.Drawing.Point(457, 167);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 22);
            this.txtHours.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(454, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 16);
            this.label16.TabIndex = 18;
            this.label16.Text = "Hours Worked:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(454, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 16);
            this.label15.TabIndex = 17;
            this.label15.Text = "Working Date:";
            // 
            // dtpWorkedDate
            // 
            this.dtpWorkedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkedDate.Location = new System.Drawing.Point(410, 106);
            this.dtpWorkedDate.Name = "dtpWorkedDate";
            this.dtpWorkedDate.Size = new System.Drawing.Size(226, 22);
            this.dtpWorkedDate.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(226, 28);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 16);
            this.lblID.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(229, 305);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 25);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtPhone2
            // 
            this.txtPhone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone2.Location = new System.Drawing.Point(212, 266);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(130, 22);
            this.txtPhone2.TabIndex = 11;
            // 
            // dtpDOB2
            // 
            this.dtpDOB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB2.Location = new System.Drawing.Point(197, 210);
            this.dtpDOB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDOB2.Name = "dtpDOB2";
            this.dtpDOB2.Size = new System.Drawing.Size(219, 22);
            this.dtpDOB2.TabIndex = 10;
            // 
            // txtEmail2
            // 
            this.txtEmail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail2.Location = new System.Drawing.Point(214, 167);
            this.txtEmail2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail2.Name = "txtEmail2";
            this.txtEmail2.Size = new System.Drawing.Size(130, 22);
            this.txtEmail2.TabIndex = 9;
            // 
            // txtLastName2
            // 
            this.txtLastName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName2.Location = new System.Drawing.Point(214, 122);
            this.txtLastName2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName2.Name = "txtLastName2";
            this.txtLastName2.Size = new System.Drawing.Size(130, 22);
            this.txtLastName2.TabIndex = 8;
            // 
            // txtFirstName2
            // 
            this.txtFirstName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName2.Location = new System.Drawing.Point(211, 75);
            this.txtFirstName2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName2.Name = "txtFirstName2";
            this.txtFirstName2.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName2.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(209, 248);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(209, 193);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "DOB:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(209, 151);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(209, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Last Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(209, 58);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "First Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(211, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Employee ID:";
            // 
            // lstboxEmployees
            // 
            this.lstboxEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxEmployees.FormattingEnabled = true;
            this.lstboxEmployees.ItemHeight = 16;
            this.lstboxEmployees.Location = new System.Drawing.Point(3, 6);
            this.lstboxEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstboxEmployees.Name = "lstboxEmployees";
            this.lstboxEmployees.Size = new System.Drawing.Size(190, 292);
            this.lstboxEmployees.TabIndex = 0;
            this.lstboxEmployees.SelectedIndexChanged += new System.EventHandler(this.lstboxEmployees_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTotalHours);
            this.tabPage1.Controls.Add(this.lstboxReport);
            this.tabPage1.Controls.Add(this.lstBoxEmployeesReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(641, 334);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Reports";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnTotalHours
            // 
            this.btnTotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalHours.Location = new System.Drawing.Point(228, 255);
            this.btnTotalHours.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTotalHours.Name = "btnTotalHours";
            this.btnTotalHours.Size = new System.Drawing.Size(222, 30);
            this.btnTotalHours.TabIndex = 2;
            this.btnTotalHours.Text = "Show Total Hours";
            this.btnTotalHours.UseVisualStyleBackColor = true;
            this.btnTotalHours.Click += new System.EventHandler(this.btnTotalHours_Click);
            // 
            // lstboxReport
            // 
            this.lstboxReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstboxReport.FormattingEnabled = true;
            this.lstboxReport.ItemHeight = 24;
            this.lstboxReport.Location = new System.Drawing.Point(170, 7);
            this.lstboxReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstboxReport.Name = "lstboxReport";
            this.lstboxReport.Size = new System.Drawing.Size(390, 244);
            this.lstboxReport.TabIndex = 1;
            // 
            // lstBoxEmployeesReport
            // 
            this.lstBoxEmployeesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxEmployeesReport.FormattingEnabled = true;
            this.lstBoxEmployeesReport.ItemHeight = 16;
            this.lstBoxEmployeesReport.Location = new System.Drawing.Point(7, 7);
            this.lstBoxEmployeesReport.Name = "lstBoxEmployeesReport";
            this.lstBoxEmployeesReport.Size = new System.Drawing.Size(158, 308);
            this.lstBoxEmployeesReport.TabIndex = 0;
            this.lstBoxEmployeesReport.SelectedIndexChanged += new System.EventHandler(this.lstBoxEmployeesReport_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 396);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.Manage.ResumeLayout(false);
            this.Manage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage Manage;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.DateTimePicker dtpDOB2;
        private System.Windows.Forms.TextBox txtEmail2;
        private System.Windows.Forms.TextBox txtLastName2;
        private System.Windows.Forms.TextBox txtFirstName2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstboxEmployees;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAddTimesheet;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpWorkedDate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstBoxEmployeesReport;
        private System.Windows.Forms.ListBox lstboxReport;
        private System.Windows.Forms.Button btnTotalHours;
    }
}

