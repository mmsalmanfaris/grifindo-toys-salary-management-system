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
    public partial class frm_salary : Form
    {
        filloperation fill = new filloperation();
        cls_salary salary = new cls_salary();

        public frm_salary()
        {
            InitializeComponent();
        }

        void clearAll()
        {
            lblmonthyear.Text = DateTime.Now.ToString("MMMM ") +" "+ DateTime.Now.ToString("yyyy");
            salary.monthyear = DateTime.Now.ToString("MMMM") /*+ " " + DateTime.Now.ToString("yyyy")*/;

            fill.combobox("SELECT * FROM tbl_employee", cmb_empid, "name", "emp_id");

            salary.SettingDetails();

            // lbl.Text = salary.No_of_Holidays.ToString() + " Days";

        }
        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void frm_salary_Load(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
        void GridDetail()
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void dgv_empoyee_salary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_empoyee_salary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_holidays_Click(object sender, EventArgs e)
        {/*
            int totalholidays = SELECT SUM(TRY_CONVERT(INT, days)) as Total_Leaves FROM tbl_leave WHERE start_date >= TRY_CONVERT(datetime, '12/31/2023') AND end_date <= TRY_CONVERT(datetime, '1/20/2024')
            */
        }

        public void cmb_empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            salary.empid = Convert.ToInt32(cmb_empid.SelectedValue);
            //salary.FK_EmpID = Convert.ToInt32(cmbEmployee.SelectedValue);

            // Total Leaves
            salary.TotalLeave();
            lbl_leaves.Text = salary.leaves.ToString() + " Days";


            salary.TotalOverTime();
            lbl_overtime.Text = (Math.Round(salary.overtime / 60)).ToString();
            salary.GetEmployeeDetails();
            lbl_overtimepayment.Text = salary.overtime_payment.ToString();

            lbl_leaves.Text = salary.leaves.ToString();

            salary.PayValues();
            lbl_nopay.Text = salary.nopay.ToString();
            lbl_basepay.Text = salary.basepay.ToString();
            lbl_grosspay.Text = salary.grosspay.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
