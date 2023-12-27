namespace Grifindo_Toys
{
    partial class frm_emp_type
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
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_emp_type = new System.Windows.Forms.DataGridView();
            this.txt_overtime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_emp_type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_annualleave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp_type)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(452, 471);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(163, 58);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_delete.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(662, 471);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(163, 58);
            this.btn_delete.TabIndex = 21;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_new
            // 
            this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_new.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(39, 471);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(163, 58);
            this.btn_new.TabIndex = 20;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btn_save.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(247, 471);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 58);
            this.btn_save.TabIndex = 19;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_emp_type
            // 
            this.dgv_emp_type.BackgroundColor = System.Drawing.Color.White;
            this.dgv_emp_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp_type.Location = new System.Drawing.Point(375, 113);
            this.dgv_emp_type.Name = "dgv_emp_type";
            this.dgv_emp_type.RowHeadersWidth = 51;
            this.dgv_emp_type.RowTemplate.Height = 24;
            this.dgv_emp_type.Size = new System.Drawing.Size(451, 302);
            this.dgv_emp_type.TabIndex = 18;
            this.dgv_emp_type.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_emp_type.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_type_CellDoubleClick);
            // 
            // txt_overtime
            // 
            this.txt_overtime.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_overtime.Location = new System.Drawing.Point(39, 266);
            this.txt_overtime.Name = "txt_overtime";
            this.txt_overtime.Size = new System.Drawing.Size(257, 33);
            this.txt_overtime.TabIndex = 26;
            this.txt_overtime.TextChanged += new System.EventHandler(this.txt_overtime_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 31);
            this.label6.TabIndex = 25;
            this.label6.Text = "Overtime Rate Hourly:";
            // 
            // txt_emp_type
            // 
            this.txt_emp_type.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp_type.Location = new System.Drawing.Point(40, 147);
            this.txt_emp_type.Name = "txt_emp_type";
            this.txt_emp_type.Size = new System.Drawing.Size(256, 33);
            this.txt_emp_type.TabIndex = 24;
            this.txt_emp_type.TextChanged += new System.EventHandler(this.txt_emp_type_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Employee Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(864, 77);
            this.label7.TabIndex = 27;
            this.label7.Text = "Employee Type";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_annualleave
            // 
            this.txt_annualleave.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_annualleave.Location = new System.Drawing.Point(40, 382);
            this.txt_annualleave.Name = "txt_annualleave";
            this.txt_annualleave.Size = new System.Drawing.Size(257, 33);
            this.txt_annualleave.TabIndex = 29;
            this.txt_annualleave.TextChanged += new System.EventHandler(this.txt_annualleave_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Annual Leave:";
            // 
            // frm_emp_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 569);
            this.Controls.Add(this.txt_annualleave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_overtime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_emp_type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_emp_type);
            this.Name = "frm_emp_type";
            this.Text = "Employee Type";
            this.Load += new System.EventHandler(this.frm_emp_type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp_type)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_emp_type;
        private System.Windows.Forms.TextBox txt_overtime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_emp_type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_annualleave;
        private System.Windows.Forms.Label label2;
    }
}