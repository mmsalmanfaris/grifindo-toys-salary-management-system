namespace Grifindo_Toys
{
    partial class frm_admin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_admin = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nic
            // 
            this.txt_nic.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nic.Location = new System.Drawing.Point(34, 257);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.Size = new System.Drawing.Size(219, 33);
            this.txt_nic.TabIndex = 1;
            this.txt_nic.Click += new System.EventHandler(this.txt_nic_Click);
            this.txt_nic.TextChanged += new System.EventHandler(this.txt_nic_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 31);
            this.label5.TabIndex = 55;
            this.label5.Text = "NIC:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(34, 481);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(219, 33);
            this.txt_password.TabIndex = 3;
            this.txt_password.Click += new System.EventHandler(this.txt_password_Click);
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 53;
            this.label1.Text = "Password:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(36, 150);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(219, 33);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 31);
            this.label2.TabIndex = 51;
            this.label2.Text = "Name:";
            this.label2.UseWaitCursor = true;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(35, 368);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(219, 33);
            this.txt_username.TabIndex = 2;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 31);
            this.label4.TabIndex = 49;
            this.label4.Text = "User Name:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1132, 86);
            this.label7.TabIndex = 57;
            this.label7.Text = "System Admin";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(715, 552);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(163, 58);
            this.btn_update.TabIndex = 6;
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
            this.btn_delete.Location = new System.Drawing.Point(930, 552);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(163, 58);
            this.btn_delete.TabIndex = 7;
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
            this.btn_new.Location = new System.Drawing.Point(302, 552);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(163, 58);
            this.btn_new.TabIndex = 4;
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
            this.btn_save.Location = new System.Drawing.Point(510, 552);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 58);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_admin
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dgv_admin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_admin.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_admin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_admin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_admin.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_admin.Location = new System.Drawing.Point(302, 150);
            this.dgv_admin.Name = "dgv_admin";
            this.dgv_admin.RowHeadersWidth = 51;
            this.dgv_admin.RowTemplate.Height = 24;
            this.dgv_admin.Size = new System.Drawing.Size(791, 364);
            this.dgv_admin.TabIndex = 62;
            this.dgv_admin.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_admin_CellDoubleClick);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 642);
            this.Controls.Add(this.dgv_admin);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_admin;
    }
}