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
            salary.yearmonth = DateTime.Now.ToString("MMMM");
            salary.SettingDetails();
            fill.FillCombobox("SELECT * FROM tbl_employee", cmb_empid, "name", "emp_id");

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
            /*try
            {
                int attendance = 1 + cmb_attendance.SelectedIndex;
                int employee = 1 + cmb_employee.SelectedIndex;
                string salary = txt_salary.Text.Trim();
                string salary_issu_date = dtp_salary_issue_date.Value.ToString("yyy-mm-dd");

                //int nopay_value = (salary/30*);
                
                string qry = "INSERT INTO salary" +
                    "(attendance_id, emp_id, total_salary, setting_id, salary_issue_date, nopay_value, basepay_value, gross_pay_value)" +
                    " VALUES('" + attendance + "','" + employee + "','" + salary + "','" + salary_issu_date + "')";

                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");

                btn_new.PerformClick();

                GridDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }*/
        }
        void GridDetail()
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            /*try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        string qry = "UPDATE salary SET " +
                        "attendance_id = '" + cmb_attendance.Text.Trim() + "'," +
                        "emp_id = '" + cmb_employee.Text.Trim() + "'," +
                        "total_salary = '" + txt_salary.Text.Trim() + "'," +
                        "setting_id = '" + cmb_setting.Text.Trim() + "'," +
                        "salary_issue_date = '" + dtp_salary_issue_date.Value.ToShortDateString() + "'," +
                        "nopay_value = '" + txt_allowance.Text.Trim() + "'," +
                        "basepay_value = '" + dtp_joiningdate.Value.ToShortDateString() + "'," +
                        "gross_pay_value = '" + cmb_bloodgrp.Text.Trim() + "'," +
                        "WHERE salary_id = " + id;

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Update Operation");

                    btn_new.PerformClick();
                    GridDetail();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }*/
        }

        private void dgv_empoyee_salary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* id = dgv_empoyee_salary.Rows[e.RowIndex].Cells[0].Value.ToString();

            try
            {
                string qry = "SELECT * FROM salary WHERE salary_id = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    //cmb_attendance.Text = rdr[1].ToString();
                    cmb_empid.Text = rdr[2].ToString();
                    txt_salary.Text = rdr[3].ToString();
                    cmb_setting.Text = rdr[4].ToString();
                    string dtp_salary_issue_date = rdr[5].ToString();
                    
                }
                btn_new.Enabled = false;
                btn_save.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }*/
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
    }
}
