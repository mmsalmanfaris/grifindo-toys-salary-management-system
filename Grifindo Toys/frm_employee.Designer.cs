﻿namespace Grifindo_Toys
{
    partial class frm_emp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_allowance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_joiningdate = new System.Windows.Forms.DateTimePicker();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_emptype = new System.Windows.Forms.ComboBox();
            this.cmb_jobrole = new System.Windows.Forms.ComboBox();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nic
            // 
            this.txt_nic.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nic.Location = new System.Drawing.Point(941, 153);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(219, 33);
            this.txt_nic.TabIndex = 4;
            this.txt_nic.Click += new System.EventHandler(this.txt_nic_Click);
            this.txt_nic.TextChanged += new System.EventHandler(this.txt_nic_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(934, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "National Identity Card:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(639, 257);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(219, 33);
            this.txt_email.TabIndex = 7;
            this.txt_email.Click += new System.EventHandler(this.txt_email_Click);
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // txt_allowance
            // 
            this.txt_allowance.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_allowance.Location = new System.Drawing.Point(941, 257);
            this.txt_allowance.Name = "txt_allowance";
            this.txt_allowance.Size = new System.Drawing.Size(219, 33);
            this.txt_allowance.TabIndex = 8;
            this.txt_allowance.Click += new System.EventHandler(this.txt_allowance_Click);
            this.txt_allowance.TextChanged += new System.EventHandler(this.txt_allowance_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(935, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Allowance:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee Type:";
            // 
            // txt_salary
            // 
            this.txt_salary.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salary.Location = new System.Drawing.Point(349, 153);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(219, 33);
            this.txt_salary.TabIndex = 2;
            this.txt_salary.Click += new System.EventHandler(this.txt_salary_Click);
            this.txt_salary.TextChanged += new System.EventHandler(this.txt_salary_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monthly Salary:";
            // 
            // dgv_emp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dgv_emp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_emp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_emp.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_emp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_emp.Location = new System.Drawing.Point(53, 347);
            this.dgv_emp.Name = "dgv_emp";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_emp.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_emp.RowHeadersWidth = 51;
            this.dgv_emp.RowTemplate.Height = 24;
            this.dgv_emp.Size = new System.Drawing.Size(1348, 554);
            this.dgv_emp.TabIndex = 14;
            this.dgv_emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellContentClick);
            this.dgv_emp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellDoubleClick);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(770, 942);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 58);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(539, 942);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(163, 58);
            this.btn_new.TabIndex = 10;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1238, 942);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(163, 58);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(999, 942);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(163, 58);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1444, 93);
            this.label7.TabIndex = 18;
            this.label7.Text = "Employee Information";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(633, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 31);
            this.label10.TabIndex = 19;
            this.label10.Text = "Joining Date:";
            // 
            // dtp_joiningdate
            // 
            this.dtp_joiningdate.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_joiningdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_joiningdate.Location = new System.Drawing.Point(639, 153);
            this.dtp_joiningdate.Name = "dtp_joiningdate";
            this.dtp_joiningdate.Size = new System.Drawing.Size(219, 33);
            this.dtp_joiningdate.TabIndex = 3;
            this.dtp_joiningdate.ValueChanged += new System.EventHandler(this.dtp_joiningdate_ValueChanged);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_male.Location = new System.Drawing.Point(35, 42);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(75, 34);
            this.rb_male.TabIndex = 0;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.CheckedChanged += new System.EventHandler(this.rb_male_CheckedChanged);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_female.Location = new System.Drawing.Point(35, 108);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(98, 34);
            this.rb_female.TabIndex = 1;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            this.rb_female.CheckedChanged += new System.EventHandler(this.rb_female_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_female);
            this.groupBox1.Controls.Add(this.rb_male);
            this.groupBox1.Location = new System.Drawing.Point(1217, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 176);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 31);
            this.label9.TabIndex = 21;
            this.label9.Text = "Job Role:";
            // 
            // cmb_emptype
            // 
            this.cmb_emptype.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_emptype.FormattingEnabled = true;
            this.cmb_emptype.Location = new System.Drawing.Point(54, 252);
            this.cmb_emptype.Name = "cmb_emptype";
            this.cmb_emptype.Size = new System.Drawing.Size(218, 38);
            this.cmb_emptype.TabIndex = 5;
            this.cmb_emptype.SelectedIndexChanged += new System.EventHandler(this.cmb_emptype_SelectedIndexChanged);
            // 
            // cmb_jobrole
            // 
            this.cmb_jobrole.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_jobrole.FormattingEnabled = true;
            this.cmb_jobrole.Items.AddRange(new object[] {
            "Manager",
            "Accountant",
            "IT",
            "Sales",
            "Marketing",
            "Toy Maker",
            "Toy Repair",
            "R&D"});
            this.cmb_jobrole.Location = new System.Drawing.Point(348, 252);
            this.cmb_jobrole.Name = "cmb_jobrole";
            this.cmb_jobrole.Size = new System.Drawing.Size(218, 38);
            this.cmb_jobrole.TabIndex = 6;
            this.cmb_jobrole.SelectedIndexChanged += new System.EventHandler(this.cmb_jobrole_SelectedIndexChanged);
            // 
            // txt_fullname
            // 
            this.txt_fullname.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fullname.Location = new System.Drawing.Point(54, 153);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(219, 33);
            this.txt_fullname.TabIndex = 1;
            this.txt_fullname.TextChanged += new System.EventHandler(this.txt_fullname_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "Full Name:";
            // 
            // frm_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 1028);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_jobrole);
            this.Controls.Add(this.cmb_emptype);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtp_joiningdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_emp);
            this.Controls.Add(this.txt_allowance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_emp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.frm_emp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_allowance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_joiningdate;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_emptype;
        private System.Windows.Forms.ComboBox cmb_jobrole;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.Label label8;
    }
}

