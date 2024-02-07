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
            salary.monthyear = DateTime.Now.ToString("MMMM") + "  " + DateTime.Now.ToString("yyyy");
            fill.combobox("SELECT * FROM tbl_employee", cmb_empid, "name", "emp_id");

            salary.SettingDetails();
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
        {
        }

        public void cmb_empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            salary.empid = Convert.ToInt32(cmb_empid.SelectedValue);
            salary.SettingDetails();
            salary.TotalLeave();
            salary.TotalOverTime();
            lbl_attendence.Text = salary.attendance.ToString() + " Days";
            lbl_leaves.Text = salary.leaves.ToString() + " Days";
            lbl_holidays.Text = salary.holiday.ToString() + " Days";
            lbl_absents.Text = salary.total_absent.ToString() + " Days";
            lbl_overtime.Text = Math.Round(salary.overtime / 60).ToString() + " Hours";
            lbl_taxrate.Text = salary.gov_tax_rate.ToString() + "%";

            salary.GetEmployeeDetails();
            salary.overtimerate();
            lbl_monthlysalary.Text = salary.salary.ToString() + " lkr";
            lbl_allowance.Text = salary.allowance.ToString() + " lkr";
            lbl_overtimerate.Text = salary.rate.ToString() + " lkr";
            salary.PayValues();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_overtimepayment.Text = "= " + salary.overtime_payment.ToString();
            lbl_nopay.Text = "= " + salary.nopay.ToString() + " lkr";
            lbl_basepay.Text = "= " + salary.basepay.ToString() + " lkr";
            lbl_grosspay.Text = "= " + salary.grosspay.ToString() + " lkr";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lbl_absents_Click(object sender, EventArgs e)
        {

        }

        private void lbl_leaves_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
