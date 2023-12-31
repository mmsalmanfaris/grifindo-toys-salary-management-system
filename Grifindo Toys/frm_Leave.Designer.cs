namespace Grifindo_Toys
{
    partial class Leave
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
            this.lbl_total_days = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_leave = new System.Windows.Forms.DataGridView();
            this.dtp_leave_end = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_leave_start = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.yyy = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_empid = new System.Windows.Forms.ComboBox();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leave)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_total_days
            // 
            this.lbl_total_days.AutoSize = true;
            this.lbl_total_days.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_days.Location = new System.Drawing.Point(28, 511);
            this.lbl_total_days.Name = "lbl_total_days";
            this.lbl_total_days.Size = new System.Drawing.Size(104, 31);
            this.lbl_total_days.TabIndex = 54;
            this.lbl_total_days.Text = "---------";
            this.lbl_total_days.Click += new System.EventHandler(this.lbl_total_days_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(842, 98);
            this.label7.TabIndex = 53;
            this.label7.Text = "Employee Leave Application";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(434, 693);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(163, 58);
            this.btn_update.TabIndex = 52;
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
            this.btn_delete.Location = new System.Drawing.Point(642, 693);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(163, 58);
            this.btn_delete.TabIndex = 51;
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
            this.btn_new.Location = new System.Drawing.Point(29, 693);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(156, 58);
            this.btn_new.TabIndex = 50;
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
            this.btn_save.Location = new System.Drawing.Point(227, 693);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 58);
            this.btn_save.TabIndex = 49;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_leave
            // 
            this.dgv_leave.BackgroundColor = System.Drawing.Color.White;
            this.dgv_leave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_leave.Location = new System.Drawing.Point(268, 132);
            this.dgv_leave.Name = "dgv_leave";
            this.dgv_leave.RowHeadersWidth = 51;
            this.dgv_leave.RowTemplate.Height = 24;
            this.dgv_leave.Size = new System.Drawing.Size(538, 509);
            this.dgv_leave.TabIndex = 48;
            this.dgv_leave.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_leave_CellContentClick);
            this.dgv_leave.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_leave_CellDoubleClick);
            // 
            // dtp_leave_end
            // 
            this.dtp_leave_end.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_leave_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_leave_end.Location = new System.Drawing.Point(31, 395);
            this.dtp_leave_end.Name = "dtp_leave_end";
            this.dtp_leave_end.Size = new System.Drawing.Size(195, 33);
            this.dtp_leave_end.TabIndex = 47;
            this.dtp_leave_end.ValueChanged += new System.EventHandler(this.dtp_leave_end_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 31);
            this.label2.TabIndex = 46;
            this.label2.Text = "Leave End Date:";
            // 
            // dtp_leave_start
            // 
            this.dtp_leave_start.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_leave_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_leave_start.Location = new System.Drawing.Point(30, 281);
            this.dtp_leave_start.Name = "dtp_leave_start";
            this.dtp_leave_start.Size = new System.Drawing.Size(196, 33);
            this.dtp_leave_start.TabIndex = 45;
            this.dtp_leave_start.ValueChanged += new System.EventHandler(this.dtp_leave_start_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 31);
            this.label10.TabIndex = 44;
            this.label10.Text = "Leave Start Date:";
            // 
            // yyy
            // 
            this.yyy.AutoSize = true;
            this.yyy.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yyy.Location = new System.Drawing.Point(25, 132);
            this.yyy.Name = "yyy";
            this.yyy.Size = new System.Drawing.Size(127, 31);
            this.yyy.TabIndex = 42;
            this.yyy.Text = "Employee Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 467);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Total Days:";
            // 
            // cmb_empid
            // 
            this.cmb_empid.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_empid.FormattingEnabled = true;
            this.cmb_empid.Location = new System.Drawing.Point(29, 171);
            this.cmb_empid.Name = "cmb_empid";
            this.cmb_empid.Size = new System.Drawing.Size(197, 38);
            this.cmb_empid.TabIndex = 55;
            this.cmb_empid.SelectedIndexChanged += new System.EventHandler(this.cmb_empid_SelectedIndexChanged);
            // 
            // txt_reason
            // 
            this.txt_reason.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reason.Location = new System.Drawing.Point(29, 608);
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(197, 33);
            this.txt_reason.TabIndex = 57;
            this.txt_reason.TextChanged += new System.EventHandler(this.txt_reason_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 574);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 31);
            this.label3.TabIndex = 56;
            this.label3.Text = "Reason:";
            // 
            // Leave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 785);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_empid);
            this.Controls.Add(this.lbl_total_days);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_leave);
            this.Controls.Add(this.dtp_leave_end);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_leave_start);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yyy);
            this.Controls.Add(this.label1);
            this.Name = "Leave";
            this.Text = "Leave";
            this.Load += new System.EventHandler(this.Leave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_total_days;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_leave;
        private System.Windows.Forms.DateTimePicker dtp_leave_end;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_leave_start;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label yyy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_empid;
        private System.Windows.Forms.TextBox txt_reason;
        private System.Windows.Forms.Label label3;
    }
}