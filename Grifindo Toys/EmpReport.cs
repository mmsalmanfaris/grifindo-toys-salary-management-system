using Grifindo_Toys.CommonClasses;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class Salary_Report : Form
    {
        filloperation fill = new filloperation();
        dbconnection con = new dbconnection();

        int emp_id;
        string startDate;
        string endDate;

        public Salary_Report()
        {
            InitializeComponent();
        }

        private void EmpReport_Load(object sender, EventArgs e)
        {
            loadAtStart();
            cmb_empid.SelectedIndex = 0;
            this.reportViewer1.RefreshReport();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void loadAtStart()
        {
            string qry = "SELECT tbl_salary.salary_id, tbl_employee.full_name, tbl_salary.month_year, tbl_salary.over_time_payment, tbl_salary.no_pay, " +
                "tbl_salary.base_pay, tbl_salary.gross_pay, tbl_salary.emp_id\r\nFROM     tbl_salary INNER JOIN\r\n                  tbl_employee ON tbl_salary.emp_id = tbl_employee.emp_id";

            fill.combobox("SELECT * FROM tbl_employee", cmb_empid, "full_name", "emp_id");
            fill.FillReportView(qry, reportViewer1);


        }

        private void cmb_empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp_id = cmb_empid.SelectedIndex;
                    }

        private void btn_new_Click(object sender, EventArgs e)
        {
            loadAtStart();
            if ((dtpStartDate.CustomFormat == " " && dtpendDate.CustomFormat == " ") && rb_one.Checked)
            {
                string query = "SELECT tbl_employee.full_name, tbl_salary.emp_id, tbl_salary.month_year, tbl_salary.no_pay, tbl_salary.base_pay, tbl_salary.gross_pay" +
                $" FROM tbl_salary INNER JOIN tbl_employee ON tbl_salary.emp_id = tbl_employee.emp_id WHERE tbl_salary.emp_id = {emp_id}";
                fill.FillReportView(query, reportViewer1);
            }
            else if (rb_one.Checked)
            {
                string query = "SELECT tbl_employee.full_name, tbl_salary.emp_id, tbl_salary.month_year, tbl_salary.no_pay, tbl_salary.base_pay, tbl_salary.gross_pay" +
                $" FROM tbl_salary INNER JOIN tbl_employee ON tbl_salary.emp_id = tbl_employee.emp_id WHERE tbl_salary.emp_id = {emp_id} AND tbl_salary.month_year >= '{dtpStartDate}' AND tbl_salary.month_year <= '{dtpendDate}'";
                fill.FillReportView(query, reportViewer1);
            }
            else if (rb_all.Checked)
            {
                string query = "SELECT tbl_employee.full_name, tbl_salary.emp_id, tbl_salary.month_year, tbl_salary.no_pay, tbl_salary.base_pay, tbl_salary.gross_pay" +
                $" FROM tbl_salary INNER JOIN tbl_employee ON tbl_salary.emp_id = tbl_employee.emp_id WHERE tbl_salary.month_year >= '{dtpStartDate}' AND tbl_salary.month_year <= '{dtpendDate}'";
                fill.FillReportView(query, reportViewer1);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            cmb_empid.Visible = false;
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpStartDate.CustomFormat = "yyyy-MM-dd";
            startDate = dtpStartDate.Value.ToString("yyyy-MM-dd");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rb_one_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            cmb_empid.Visible = true;

        }

        private void dtpendDate_ValueChanged(object sender, EventArgs e)
        {
            dtpendDate.CustomFormat = "yyyy-MM-dd";
            endDate = dtpendDate.Value.ToString("yyyy-MM-dd");
        }
    }
}
