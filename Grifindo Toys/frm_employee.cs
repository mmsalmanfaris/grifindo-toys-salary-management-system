using Grifindo_Toys.AppClasses;
using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Grifindo_Toys
{
    public partial class frm_emp : Form
    {
        cls_employee clsemp = new cls_employee();
        filloperation fill = new filloperation();

        public frm_emp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_emp_Load(object sender, EventArgs e)
        {
            fill.combobox("SELECT * FROM tbl_employeetype", cmb_emptype, "emp_type", "emp_type_id");
            FirstRun();
        }

        void FirstRun()
        {
            txt_name.Text = "";
            txt_fullname.Text = "";
            txt_nic.Text = "123";
            txt_email.Text = "";
            txt_salary.Text = "0.00";
            cmb_emptype.SelectedIndex = 0;
            txt_allowance.Text = "0.00";
            dtp_joiningdate.Value = DateTime.Now;
            cmb_jobrole.SelectedIndex = 0;
            rb_male.Checked = false;
            rb_female.Checked = false;

            fill.FillDataGridView("SELECT * FROM tbl_employee", dgv_emp);
        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            FirstRun();
            txt_name.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            clsemp.Insertdata();
            FirstRun();
        }

        private void dgv_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_name.Text = Convert.ToString(dgv_emp.Rows[e.RowIndex].Cells[0].Value);
            clsemp.FillEmployeTypeToField();
            txt_fullname.Text = clsemp.fullname;
            txt_nic.Text = clsemp.nic.ToString();
            txt_email.Text = clsemp.email;
            txt_salary.Text = clsemp.salary.ToString();
            cmb_emptype.Text = clsemp.emptype.ToString();
            txt_allowance.Text = clsemp.allowance.ToString();
            dtp_joiningdate.Text = clsemp.joindate.ToString();
            cmb_jobrole.Text = clsemp.jobrole.ToString();

            if ("Male" == clsemp.gender)
            {
                rb_male.Checked = true;
            }
            else
            {
                rb_female.Checked = true;
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            clsemp.UpdateData();
            FirstRun();
        } 

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clsemp.DeleteDate();
            FirstRun();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            clsemp.name = txt_name.Text.Trim();
        }

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            clsemp.nic = Convert.ToString(txt_nic.Text);
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            clsemp.email = txt_email.Text.Trim();
        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {
            clsemp.salary = (int)Convert.ToDecimal(txt_salary.Text.Trim());
        }

        private void cmb_emptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsemp.emptype = cmb_emptype.SelectedValue.ToString();
        }

        private void txt_allowance_TextChanged(object sender, EventArgs e)
        {
            clsemp.allowance = (int)Convert.ToDecimal(txt_allowance.Text.Trim());
        }

        private void dtp_joiningdate_ValueChanged(object sender, EventArgs e)
        {
            clsemp.joindate = dtp_joiningdate.Value;
        }

        private void txt_jobrole_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_male.Checked)
            {
                clsemp.gender = "Male";
            }
        }

        private void rb_female_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_female.Checked)
            {
                clsemp.gender = "Female";
            }
        }

        private void txt_salary_Click(object sender, EventArgs e)
        {
            txt_salary.SelectAll();
        }

        private void txt_nic_Click(object sender, EventArgs e)
        {
            txt_nic.SelectAll();
        }

        private void txt_email_Click(object sender, EventArgs e)
        {
            txt_email.SelectAll();
        }

        private void txt_allowance_Click(object sender, EventArgs e)
        {
            txt_allowance.SelectAll();
        }

        private void cmb_jobrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsemp.jobrole = Convert.ToString(cmb_jobrole.SelectedItem);
        }

        private void txt_fullname_TextChanged(object sender, EventArgs e)
        {
            clsemp.fullname = txt_fullname.Text;
        }
    }
}
