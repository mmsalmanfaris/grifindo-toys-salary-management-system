using Grifindo_Toys.AppClasses;
using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class frm_admin : Form
    {
        cls_admin clsadmin = new cls_admin();
        filloperation fill = new filloperation();

        public frm_admin()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            firstrun();
        }

        void firstrun()
        {
            txt_name.Text = "";
            txt_nic.Text = "000000";
            txt_username.Text = "";
            txt_password.Text = "******";

            fill.FillDataGridView("SELECT * FROM tbl_admin", dgv_admin);
            dgv_admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_admin.Columns[0].HeaderText = "ID";
            dgv_admin.Columns[1].HeaderText = "Full Name";
            dgv_admin.Columns[2].HeaderText = "NIC";
            dgv_admin.Columns[3].HeaderText = "Username";
            dgv_admin.Columns[4].HeaderText = "Password";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clsadmin.DeleteData();
            firstrun();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            clsadmin.UpdateData();
            firstrun();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            clsadmin.Insertdata();
            firstrun();
        }
        void griddetail()
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
            firstrun();
        }

        private void dgv_admin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsadmin.adminid = Convert.ToInt32(dgv_admin.Rows[e.RowIndex].Cells[0].Value);
            clsadmin.FillEmployeTypeToField();
            txt_name.Text = clsadmin.name;
            txt_nic.Text = clsadmin.nic;
            txt_username.Text = clsadmin.username;
            txt_password.Text = clsadmin.password;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            clsadmin.name = txt_name.Text;
        }

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            clsadmin.nic = txt_nic.Text;
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            clsadmin.username = txt_username.Text;
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            clsadmin.password = txt_password.Text;
        }

        private void txt_nic_Click(object sender, EventArgs e)
        {
            txt_nic.SelectAll();
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_password.SelectAll();
        }
    }
}
