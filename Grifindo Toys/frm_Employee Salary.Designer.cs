namespace Grifindo_Toys
{
    partial class frm_salary
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_empid = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_empoyee_salary = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_leaves = new System.Windows.Forms.Label();
            this.lbl_holidays = new System.Windows.Forms.Label();
            this.lbl_nopay = new System.Windows.Forms.Label();
            this.lbl_absents = new System.Windows.Forms.Label();
            this.lbl_grosspay = new System.Windows.Forms.Label();
            this.lbl_basepay = new System.Windows.Forms.Label();
            this.lbl_overtimepayment = new System.Windows.Forms.Label();
            this.lbl_allowance = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.aadd = new System.Windows.Forms.Label();
            this.lbl_overtime = new System.Windows.Forms.Label();
            this.lbl_attendence = new System.Windows.Forms.Label();
            this.lblmonthyear = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_monthlysalary = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbl_overtimerate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_taxrate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empoyee_salary)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(218, 46);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employee Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_empid
            // 
            this.cmb_empid.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empid.FormattingEnabled = true;
            this.cmb_empid.Location = new System.Drawing.Point(568, 144);
            this.cmb_empid.Name = "cmb_empid";
            this.cmb_empid.Size = new System.Drawing.Size(197, 44);
            this.cmb_empid.TabIndex = 0;
            this.cmb_empid.SelectedIndexChanged += new System.EventHandler(this.cmb_empid_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1168, 80);
            this.label8.TabIndex = 41;
            this.label8.Text = "     Employee Salary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dgv_empoyee_salary
            // 
            this.dgv_empoyee_salary.BackgroundColor = System.Drawing.Color.White;
            this.dgv_empoyee_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empoyee_salary.Location = new System.Drawing.Point(41, 692);
            this.dgv_empoyee_salary.Name = "dgv_empoyee_salary";
            this.dgv_empoyee_salary.RowHeadersWidth = 51;
            this.dgv_empoyee_salary.RowTemplate.Height = 24;
            this.dgv_empoyee_salary.Size = new System.Drawing.Size(1092, 335);
            this.dgv_empoyee_salary.TabIndex = 47;
            this.dgv_empoyee_salary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empoyee_salary_CellContentClick);
            this.dgv_empoyee_salary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empoyee_salary_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 31);
            this.label10.TabIndex = 48;
            this.label10.Text = "No Pay Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 31);
            this.label11.TabIndex = 56;
            this.label11.Text = "Total Absents:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(27, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 31);
            this.label13.TabIndex = 50;
            this.label13.Text = "Total Leaves:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(30, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 31);
            this.label14.TabIndex = 52;
            this.label14.Text = "Total Holidays:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(648, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Gross Pay Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 64;
            this.label4.Text = "Base Pay Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 31);
            this.label6.TabIndex = 60;
            this.label6.Text = "Allowance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 31);
            this.label9.TabIndex = 62;
            this.label9.Text = "Over Time Payment:";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(726, 599);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(179, 58);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(950, 599);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(183, 58);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(296, 599);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(162, 58);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(506, 599);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(179, 58);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // lbl_leaves
            // 
            this.lbl_leaves.AutoSize = true;
            this.lbl_leaves.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaves.Location = new System.Drawing.Point(27, 179);
            this.lbl_leaves.Name = "lbl_leaves";
            this.lbl_leaves.Size = new System.Drawing.Size(104, 31);
            this.lbl_leaves.TabIndex = 75;
            this.lbl_leaves.Text = "---------";
            this.lbl_leaves.Click += new System.EventHandler(this.lbl_leaves_Click);
            // 
            // lbl_holidays
            // 
            this.lbl_holidays.AutoSize = true;
            this.lbl_holidays.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_holidays.Location = new System.Drawing.Point(30, 391);
            this.lbl_holidays.Name = "lbl_holidays";
            this.lbl_holidays.Size = new System.Drawing.Size(104, 31);
            this.lbl_holidays.TabIndex = 76;
            this.lbl_holidays.Text = "---------";
            this.lbl_holidays.Click += new System.EventHandler(this.lbl_holidays_Click);
            // 
            // lbl_nopay
            // 
            this.lbl_nopay.AutoSize = true;
            this.lbl_nopay.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nopay.Location = new System.Drawing.Point(253, 71);
            this.lbl_nopay.Name = "lbl_nopay";
            this.lbl_nopay.Size = new System.Drawing.Size(104, 31);
            this.lbl_nopay.TabIndex = 78;
            this.lbl_nopay.Text = "---------";
            // 
            // lbl_absents
            // 
            this.lbl_absents.AutoSize = true;
            this.lbl_absents.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_absents.Location = new System.Drawing.Point(27, 289);
            this.lbl_absents.Name = "lbl_absents";
            this.lbl_absents.Size = new System.Drawing.Size(104, 31);
            this.lbl_absents.TabIndex = 77;
            this.lbl_absents.Text = "---------";
            this.lbl_absents.Click += new System.EventHandler(this.lbl_absents_Click);
            // 
            // lbl_grosspay
            // 
            this.lbl_grosspay.AutoSize = true;
            this.lbl_grosspay.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grosspay.Location = new System.Drawing.Point(648, 71);
            this.lbl_grosspay.Name = "lbl_grosspay";
            this.lbl_grosspay.Size = new System.Drawing.Size(104, 31);
            this.lbl_grosspay.TabIndex = 82;
            this.lbl_grosspay.Text = "---------";
            // 
            // lbl_basepay
            // 
            this.lbl_basepay.AutoSize = true;
            this.lbl_basepay.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_basepay.Location = new System.Drawing.Point(439, 71);
            this.lbl_basepay.Name = "lbl_basepay";
            this.lbl_basepay.Size = new System.Drawing.Size(104, 31);
            this.lbl_basepay.TabIndex = 81;
            this.lbl_basepay.Text = "---------";
            // 
            // lbl_overtimepayment
            // 
            this.lbl_overtimepayment.AutoSize = true;
            this.lbl_overtimepayment.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overtimepayment.Location = new System.Drawing.Point(18, 71);
            this.lbl_overtimepayment.Name = "lbl_overtimepayment";
            this.lbl_overtimepayment.Size = new System.Drawing.Size(104, 31);
            this.lbl_overtimepayment.TabIndex = 80;
            this.lbl_overtimepayment.Text = "---------";
            // 
            // lbl_allowance
            // 
            this.lbl_allowance.AutoSize = true;
            this.lbl_allowance.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_allowance.Location = new System.Drawing.Point(253, 75);
            this.lbl_allowance.Name = "lbl_allowance";
            this.lbl_allowance.Size = new System.Drawing.Size(104, 31);
            this.lbl_allowance.TabIndex = 79;
            this.lbl_allowance.Text = "---------";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.aadd);
            this.groupBox1.Controls.Add(this.lbl_overtime);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbl_attendence);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_holidays);
            this.groupBox1.Controls.Add(this.lbl_absents);
            this.groupBox1.Controls.Add(this.lbl_leaves);
            this.groupBox1.Location = new System.Drawing.Point(41, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 541);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendence";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 455);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 31);
            this.label17.TabIndex = 92;
            this.label17.Text = "Over Time Hours:";
            // 
            // aadd
            // 
            this.aadd.AutoSize = true;
            this.aadd.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aadd.Location = new System.Drawing.Point(30, 38);
            this.aadd.Name = "aadd";
            this.aadd.Size = new System.Drawing.Size(174, 31);
            this.aadd.TabIndex = 87;
            this.aadd.Text = "Total Attendence:";
            // 
            // lbl_overtime
            // 
            this.lbl_overtime.AutoSize = true;
            this.lbl_overtime.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overtime.Location = new System.Drawing.Point(30, 491);
            this.lbl_overtime.Name = "lbl_overtime";
            this.lbl_overtime.Size = new System.Drawing.Size(104, 31);
            this.lbl_overtime.TabIndex = 93;
            this.lbl_overtime.Text = "---------";
            // 
            // lbl_attendence
            // 
            this.lbl_attendence.AutoSize = true;
            this.lbl_attendence.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attendence.Location = new System.Drawing.Point(30, 74);
            this.lbl_attendence.Name = "lbl_attendence";
            this.lbl_attendence.Size = new System.Drawing.Size(104, 31);
            this.lbl_attendence.TabIndex = 90;
            this.lbl_attendence.Text = "---------";
            // 
            // lblmonthyear
            // 
            this.lblmonthyear.AutoSize = true;
            this.lblmonthyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.lblmonthyear.Font = new System.Drawing.Font("Poppins Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmonthyear.ForeColor = System.Drawing.Color.White;
            this.lblmonthyear.Location = new System.Drawing.Point(938, 21);
            this.lblmonthyear.Name = "lblmonthyear";
            this.lblmonthyear.Size = new System.Drawing.Size(143, 40);
            this.lblmonthyear.TabIndex = 83;
            this.lblmonthyear.Text = "---------";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbl_nopay);
            this.groupBox2.Controls.Add(this.lbl_grosspay);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl_overtimepayment);
            this.groupBox2.Controls.Add(this.lbl_basepay);
            this.groupBox2.Location = new System.Drawing.Point(296, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 129);
            this.groupBox2.TabIndex = 84;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary Calculation";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(903, 139);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(4);
            this.button1.Size = new System.Drawing.Size(230, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Genarate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 31);
            this.label12.TabIndex = 86;
            this.label12.Text = "Month Salary:";
            // 
            // lbl_monthlysalary
            // 
            this.lbl_monthlysalary.AutoSize = true;
            this.lbl_monthlysalary.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthlysalary.Location = new System.Drawing.Point(35, 75);
            this.lbl_monthlysalary.Name = "lbl_monthlysalary";
            this.lbl_monthlysalary.Size = new System.Drawing.Size(104, 31);
            this.lbl_monthlysalary.TabIndex = 89;
            this.lbl_monthlysalary.Text = "---------";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(457, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 31);
            this.label16.TabIndex = 88;
            this.label16.Text = "Over Time Rate:";
            // 
            // lbl_overtimerate
            // 
            this.lbl_overtimerate.AutoSize = true;
            this.lbl_overtimerate.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overtimerate.Location = new System.Drawing.Point(457, 75);
            this.lbl_overtimerate.Name = "lbl_overtimerate";
            this.lbl_overtimerate.Size = new System.Drawing.Size(104, 31);
            this.lbl_overtimerate.TabIndex = 91;
            this.lbl_overtimerate.Text = "---------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(693, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 94;
            this.label3.Text = "Tax Rate:";
            // 
            // lbl_taxrate
            // 
            this.lbl_taxrate.AutoSize = true;
            this.lbl_taxrate.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taxrate.Location = new System.Drawing.Point(693, 75);
            this.lbl_taxrate.Name = "lbl_taxrate";
            this.lbl_taxrate.Size = new System.Drawing.Size(104, 31);
            this.lbl_taxrate.TabIndex = 95;
            this.lbl_taxrate.Text = "---------";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbl_taxrate);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.lbl_allowance);
            this.groupBox3.Controls.Add(this.lbl_overtimerate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.lbl_monthlysalary);
            this.groupBox3.Location = new System.Drawing.Point(296, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(837, 134);
            this.groupBox3.TabIndex = 96;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basic Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            this.label5.Location = new System.Drawing.Point(753, 201);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(6, 42);
            this.label5.TabIndex = 84;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frm_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 1054);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblmonthyear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_empoyee_salary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_empid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empoyee_salary)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_empid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv_empoyee_salary;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_leaves;
        private System.Windows.Forms.Label lbl_holidays;
        private System.Windows.Forms.Label lbl_nopay;
        private System.Windows.Forms.Label lbl_absents;
        private System.Windows.Forms.Label lbl_grosspay;
        private System.Windows.Forms.Label lbl_basepay;
        private System.Windows.Forms.Label lbl_overtimepayment;
        private System.Windows.Forms.Label lbl_allowance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblmonthyear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label aadd;
        private System.Windows.Forms.Label lbl_attendence;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_monthlysalary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbl_overtimerate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_taxrate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_overtime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
    }
}