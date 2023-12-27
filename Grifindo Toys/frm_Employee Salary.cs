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


        public frm_salary()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           /* try
            {

                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM salary WHERE salary_id = " + id;

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully", "Delete Operation");
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

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void frm_salary_Load(object sender, EventArgs e)
        {

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
           /* try
            {
                string qry = "SELECT * FROM salary";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgv_empoyee_salary.DataSource = dt;

                dgv_empoyee_salary.Columns[0].Visible = true;
                //dgv_employee.Columns[1].HeaderText = "First Name";
                dgv_empoyee_salary.Columns[1].Width = 200;
            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }*/
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
    }
}
