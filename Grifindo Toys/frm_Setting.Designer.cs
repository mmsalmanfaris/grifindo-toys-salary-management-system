namespace Grifindo_Toys
{
    partial class frm_setting
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
            this.dtp_salary_begin = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_gov_tax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_salary_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_salary_setting = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_range = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_monthyear = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary_setting)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_salary_begin
            // 
            this.dtp_salary_begin.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_salary_begin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_salary_begin.Location = new System.Drawing.Point(38, 364);
            this.dtp_salary_begin.Name = "dtp_salary_begin";
            this.dtp_salary_begin.Size = new System.Drawing.Size(196, 33);
            this.dtp_salary_begin.TabIndex = 31;
            this.dtp_salary_begin.ValueChanged += new System.EventHandler(this.dtp_salary_begin_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 31);
            this.label10.TabIndex = 30;
            this.label10.Text = "Salary Begin Date:";
            // 
            // txt_gov_tax
            // 
            this.txt_gov_tax.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gov_tax.Location = new System.Drawing.Point(36, 155);
            this.txt_gov_tax.Name = "txt_gov_tax";
            this.txt_gov_tax.Size = new System.Drawing.Size(196, 33);
            this.txt_gov_tax.TabIndex = 29;
            this.txt_gov_tax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_gov_tax.Click += new System.EventHandler(this.txt_gov_tax_Click);
            this.txt_gov_tax.TextChanged += new System.EventHandler(this.txt_gov_tax_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 31);
            this.label6.TabIndex = 28;
            this.label6.Text = "Goverment Tax Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Salary Cycle Range:";
            // 
            // dtp_salary_end
            // 
            this.dtp_salary_end.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_salary_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_salary_end.Location = new System.Drawing.Point(39, 478);
            this.dtp_salary_end.Name = "dtp_salary_end";
            this.dtp_salary_end.Size = new System.Drawing.Size(195, 33);
            this.dtp_salary_end.TabIndex = 33;
            this.dtp_salary_end.ValueChanged += new System.EventHandler(this.dtp_salary_end_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "Salary End Date:";
            // 
            // dgv_salary_setting
            // 
            this.dgv_salary_setting.BackgroundColor = System.Drawing.Color.White;
            this.dgv_salary_setting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salary_setting.Location = new System.Drawing.Point(292, 121);
            this.dgv_salary_setting.Name = "dgv_salary_setting";
            this.dgv_salary_setting.RowHeadersWidth = 51;
            this.dgv_salary_setting.RowTemplate.Height = 24;
            this.dgv_salary_setting.Size = new System.Drawing.Size(522, 494);
            this.dgv_salary_setting.TabIndex = 34;
            this.dgv_salary_setting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_salary_setting_CellContentClick);
            this.dgv_salary_setting.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_salary_setting_CellDoubleClick);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(443, 671);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(163, 58);
            this.btn_update.TabIndex = 38;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(651, 671);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(163, 58);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(38, 671);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(156, 58);
            this.btn_new.TabIndex = 36;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Lime;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(236, 671);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 58);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(857, 81);
            this.label7.TabIndex = 39;
            this.label7.Text = "Employee Salary Setting";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_range
            // 
            this.lbl_range.AutoSize = true;
            this.lbl_range.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_range.Location = new System.Drawing.Point(32, 581);
            this.lbl_range.Name = "lbl_range";
            this.lbl_range.Size = new System.Drawing.Size(104, 31);
            this.lbl_range.TabIndex = 55;
            this.lbl_range.Text = "---------";
            this.lbl_range.Click += new System.EventHandler(this.lbl_range_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 39);
            this.label3.TabIndex = 56;
            this.label3.Text = "Month Year:";
            // 
            // lbl_monthyear
            // 
            this.lbl_monthyear.AutoSize = true;
            this.lbl_monthyear.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthyear.Location = new System.Drawing.Point(34, 253);
            this.lbl_monthyear.Name = "lbl_monthyear";
            this.lbl_monthyear.Size = new System.Drawing.Size(104, 31);
            this.lbl_monthyear.TabIndex = 57;
            this.lbl_monthyear.Text = "---------";
            this.lbl_monthyear.Click += new System.EventHandler(this.lbl_monthyear_Click);
            // 
            // frm_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(857, 762);
            this.Controls.Add(this.lbl_monthyear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_range);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_salary_setting);
            this.Controls.Add(this.dtp_salary_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_salary_begin);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_gov_tax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary_setting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_salary_begin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_gov_tax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_salary_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_salary_setting;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_monthyear;
    }
}