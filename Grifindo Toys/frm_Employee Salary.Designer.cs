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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_empid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_salary_issue_date = new System.Windows.Forms.DateTimePicker();
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
            this.cmb_month = new System.Windows.Forms.ComboBox();
            this.lbl_leaves = new System.Windows.Forms.Label();
            this.lbl_holidays = new System.Windows.Forms.Label();
            this.lbl_nopay = new System.Windows.Forms.Label();
            this.lbl_absents = new System.Windows.Forms.Label();
            this.lbl_grosspay = new System.Windows.Forms.Label();
            this.lbl_basepay = new System.Windows.Forms.Label();
            this.lbl_overtimepayment = new System.Windows.Forms.Label();
            this.lbl_overtime = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empoyee_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(891, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "End Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Month:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employee Id:";
            // 
            // cmb_empid
            // 
            this.cmb_empid.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empid.FormattingEnabled = true;
            this.cmb_empid.Location = new System.Drawing.Point(44, 163);
            this.cmb_empid.Name = "cmb_empid";
            this.cmb_empid.Size = new System.Drawing.Size(218, 38);
            this.cmb_empid.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(607, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Begin Date:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1160, 105);
            this.label8.TabIndex = 41;
            this.label8.Text = "Employee Salary";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtp_salary_issue_date
            // 
            this.dtp_salary_issue_date.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_salary_issue_date.Location = new System.Drawing.Point(897, 168);
            this.dtp_salary_issue_date.Name = "dtp_salary_issue_date";
            this.dtp_salary_issue_date.Size = new System.Drawing.Size(219, 33);
            this.dtp_salary_issue_date.TabIndex = 46;
            // 
            // dgv_empoyee_salary
            // 
            this.dgv_empoyee_salary.BackgroundColor = System.Drawing.Color.White;
            this.dgv_empoyee_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_empoyee_salary.Location = new System.Drawing.Point(44, 469);
            this.dgv_empoyee_salary.Name = "dgv_empoyee_salary";
            this.dgv_empoyee_salary.RowHeadersWidth = 51;
            this.dgv_empoyee_salary.RowTemplate.Height = 24;
            this.dgv_empoyee_salary.Size = new System.Drawing.Size(1072, 517);
            this.dgv_empoyee_salary.TabIndex = 47;
            this.dgv_empoyee_salary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empoyee_salary_CellContentClick);
            this.dgv_empoyee_salary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_empoyee_salary_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(891, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 31);
            this.label10.TabIndex = 48;
            this.label10.Text = "No Pay Value:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(607, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 31);
            this.label11.TabIndex = 56;
            this.label11.Text = "Total Absents:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 31);
            this.label13.TabIndex = 50;
            this.label13.Text = "Total Leaves:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(321, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 31);
            this.label14.TabIndex = 52;
            this.label14.Text = "Total Holidays:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(891, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Gross Pay Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 64;
            this.label4.Text = "Base Pay Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 31);
            this.label6.TabIndex = 60;
            this.label6.Text = "Over Time Hours:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(321, 358);
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
            this.btn_update.Location = new System.Drawing.Point(743, 1023);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(163, 58);
            this.btn_update.TabIndex = 73;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(953, 1023);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(163, 58);
            this.btn_delete.TabIndex = 72;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(323, 1023);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(156, 58);
            this.btn_new.TabIndex = 71;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(530, 1023);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 58);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // cmb_month
            // 
            this.cmb_month.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_month.FormattingEnabled = true;
            this.cmb_month.Location = new System.Drawing.Point(327, 163);
            this.cmb_month.Name = "cmb_month";
            this.cmb_month.Size = new System.Drawing.Size(218, 38);
            this.cmb_month.TabIndex = 74;
            // 
            // lbl_leaves
            // 
            this.lbl_leaves.AutoSize = true;
            this.lbl_leaves.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaves.Location = new System.Drawing.Point(38, 282);
            this.lbl_leaves.Name = "lbl_leaves";
            this.lbl_leaves.Size = new System.Drawing.Size(104, 31);
            this.lbl_leaves.TabIndex = 75;
            this.lbl_leaves.Text = "---------";
            // 
            // lbl_holidays
            // 
            this.lbl_holidays.AutoSize = true;
            this.lbl_holidays.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_holidays.Location = new System.Drawing.Point(321, 282);
            this.lbl_holidays.Name = "lbl_holidays";
            this.lbl_holidays.Size = new System.Drawing.Size(104, 31);
            this.lbl_holidays.TabIndex = 76;
            this.lbl_holidays.Text = "---------";
            // 
            // lbl_nopay
            // 
            this.lbl_nopay.AutoSize = true;
            this.lbl_nopay.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nopay.Location = new System.Drawing.Point(891, 282);
            this.lbl_nopay.Name = "lbl_nopay";
            this.lbl_nopay.Size = new System.Drawing.Size(104, 31);
            this.lbl_nopay.TabIndex = 78;
            this.lbl_nopay.Text = "---------";
            // 
            // lbl_absents
            // 
            this.lbl_absents.AutoSize = true;
            this.lbl_absents.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_absents.Location = new System.Drawing.Point(607, 282);
            this.lbl_absents.Name = "lbl_absents";
            this.lbl_absents.Size = new System.Drawing.Size(104, 31);
            this.lbl_absents.TabIndex = 77;
            this.lbl_absents.Text = "---------";
            // 
            // lbl_grosspay
            // 
            this.lbl_grosspay.AutoSize = true;
            this.lbl_grosspay.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grosspay.Location = new System.Drawing.Point(891, 394);
            this.lbl_grosspay.Name = "lbl_grosspay";
            this.lbl_grosspay.Size = new System.Drawing.Size(104, 31);
            this.lbl_grosspay.TabIndex = 82;
            this.lbl_grosspay.Text = "---------";
            // 
            // lbl_basepay
            // 
            this.lbl_basepay.AutoSize = true;
            this.lbl_basepay.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_basepay.Location = new System.Drawing.Point(607, 394);
            this.lbl_basepay.Name = "lbl_basepay";
            this.lbl_basepay.Size = new System.Drawing.Size(104, 31);
            this.lbl_basepay.TabIndex = 81;
            this.lbl_basepay.Text = "---------";
            // 
            // lbl_overtimepayment
            // 
            this.lbl_overtimepayment.AutoSize = true;
            this.lbl_overtimepayment.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overtimepayment.Location = new System.Drawing.Point(321, 394);
            this.lbl_overtimepayment.Name = "lbl_overtimepayment";
            this.lbl_overtimepayment.Size = new System.Drawing.Size(104, 31);
            this.lbl_overtimepayment.TabIndex = 80;
            this.lbl_overtimepayment.Text = "---------";
            // 
            // lbl_overtime
            // 
            this.lbl_overtime.AutoSize = true;
            this.lbl_overtime.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_overtime.Location = new System.Drawing.Point(38, 394);
            this.lbl_overtime.Name = "lbl_overtime";
            this.lbl_overtime.Size = new System.Drawing.Size(104, 31);
            this.lbl_overtime.TabIndex = 79;
            this.lbl_overtime.Text = "---------";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(613, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 33);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // frm_salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1160, 1104);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_grosspay);
            this.Controls.Add(this.lbl_basepay);
            this.Controls.Add(this.lbl_overtimepayment);
            this.Controls.Add(this.lbl_overtime);
            this.Controls.Add(this.lbl_nopay);
            this.Controls.Add(this.lbl_absents);
            this.Controls.Add(this.lbl_holidays);
            this.Controls.Add(this.lbl_leaves);
            this.Controls.Add(this.cmb_month);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgv_empoyee_salary);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtp_salary_issue_date);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_empid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frm_salary";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_empoyee_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_empid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_salary_issue_date;
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
        private System.Windows.Forms.ComboBox cmb_month;
        private System.Windows.Forms.Label lbl_leaves;
        private System.Windows.Forms.Label lbl_holidays;
        private System.Windows.Forms.Label lbl_nopay;
        private System.Windows.Forms.Label lbl_absents;
        private System.Windows.Forms.Label lbl_grosspay;
        private System.Windows.Forms.Label lbl_basepay;
        private System.Windows.Forms.Label lbl_overtimepayment;
        private System.Windows.Forms.Label lbl_overtime;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}