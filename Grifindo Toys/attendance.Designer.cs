namespace Grifindo_Toys
{
    partial class frm_attendance
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
            this.txt_holiday = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_overtime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_employee = new System.Windows.Forms.ComboBox();
            this.dgv_attendance = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_absent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_holiday
            // 
            this.txt_holiday.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_holiday.Location = new System.Drawing.Point(50, 586);
            this.txt_holiday.Name = "txt_holiday";
            this.txt_holiday.Size = new System.Drawing.Size(219, 33);
            this.txt_holiday.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 31);
            this.label4.TabIndex = 26;
            this.label4.Text = "In Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 24;
            this.label3.Text = "Employee:";
            this.label3.UseWaitCursor = true;
            // 
            // txt_overtime
            // 
            this.txt_overtime.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overtime.Location = new System.Drawing.Point(49, 699);
            this.txt_overtime.Name = "txt_overtime";
            this.txt_overtime.Size = new System.Drawing.Size(219, 33);
            this.txt_overtime.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Over Time Hours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 28;
            this.label2.Text = "Leaves:";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(895, 81);
            this.label7.TabIndex = 40;
            this.label7.Text = "Employee Attendance";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_employee
            // 
            this.cmb_employee.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_employee.FormattingEnabled = true;
            this.cmb_employee.Location = new System.Drawing.Point(50, 160);
            this.cmb_employee.Name = "cmb_employee";
            this.cmb_employee.Size = new System.Drawing.Size(218, 38);
            this.cmb_employee.TabIndex = 41;
            this.cmb_employee.SelectedIndexChanged += new System.EventHandler(this.cmb_employee_SelectedIndexChanged);
            // 
            // dgv_attendance
            // 
            this.dgv_attendance.BackgroundColor = System.Drawing.Color.White;
            this.dgv_attendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attendance.Location = new System.Drawing.Point(318, 160);
            this.dgv_attendance.Name = "dgv_attendance";
            this.dgv_attendance.RowHeadersWidth = 51;
            this.dgv_attendance.RowTemplate.Height = 24;
            this.dgv_attendance.Size = new System.Drawing.Size(525, 477);
            this.dgv_attendance.TabIndex = 42;
            this.dgv_attendance.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_attendance_CellDoubleClick);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(566, 674);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(142, 58);
            this.btn_update.TabIndex = 46;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_delete.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(714, 674);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(129, 58);
            this.btn_delete.TabIndex = 45;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_new.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(318, 674);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(121, 58);
            this.btn_new.TabIndex = 44;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_save.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(445, 674);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(115, 58);
            this.btn_save.TabIndex = 43;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_absent
            // 
            this.txt_absent.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_absent.Location = new System.Drawing.Point(50, 372);
            this.txt_absent.Name = "txt_absent";
            this.txt_absent.Size = new System.Drawing.Size(219, 33);
            this.txt_absent.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "No Absent:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(50, 479);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 33);
            this.textBox1.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 31);
            this.label6.TabIndex = 49;
            this.label6.Text = "In Time:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 265);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 38);
            this.comboBox1.TabIndex = 51;
            // 
            // frm_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 773);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_absent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_attendance);
            this.Controls.Add(this.cmb_employee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_overtime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_holiday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "frm_attendance";
            this.Text = "attendance";
            this.Load += new System.EventHandler(this.attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_holiday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_overtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_employee;
        private System.Windows.Forms.DataGridView dgv_attendance;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_absent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}