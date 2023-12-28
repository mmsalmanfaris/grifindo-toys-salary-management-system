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
            cmb_load();
            /*
            string qry = "SELECT * FROM tbl_employeetype";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);*/

        }

        void cmb_load()
        {
            fill.combobox("SELECT * FROM tbl_employeetype", cmb_emptype, "emp_type", "emp_type_id");
        }
        void myFillGridDetail()
        {
           /* try
            {
                string qry = "SELECT * FROM employee";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgv_emp.DataSource = dt;

                dgv_emp.Columns[0].Visible = true;
                //dgv_employee.Columns[1].HeaderText = "First Name";
                dgv_emp.Columns[1].Width = 200;

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }*/

        }

        private void dgv_emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            clsemp.Insertdata();

        }

        private void dgv_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {/*
            id = dgv_emp.Rows[e.RowIndex].Cells[0].Value.ToString();

            try
            {
                string qry = "SELECT * FROM emp_attendance_salary WHERE emp_id = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txt_name.Text = rdr[1].ToString();
                    txt_nic.Text = rdr[2].ToString();
                    txt_email.Text = rdr[3].ToString();
                    txt_salary.Text = rdr[4].ToString();
                    //cmb_emp_type.Text = rdr[5].ToString();
                    txt_allowance.Text = rdr[6].ToString();
                    string dtp_joiningdate = rdr[7].ToString();
                    cmb_bloodgrp.Text = rdr[8].ToString();

                    if (rdr[9].ToString() == "Male")
                    {
                        rb_male.Checked = true;
                    }
                    else if (rdr[9].ToString() == "Female")
                    {
                        rb_female.Checked = true;
                    }


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

        private void btn_update_Click(object sender, EventArgs e)
        {/*
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (rb_male.Checked)
                    {
                        gender = "Male";
                    }
                    else if (rb_female.Checked)
                    {
                        gender = "Female";
                    }

                    string qry = "UPDATE emp_attendance_salary SET " +
                        "emp_name = '" + txt_name.Text.Trim() + "'," +
                        "emp_nic = '" + txt_nic.Text.Trim() + "'," +
                        "emp_email = '" + txt_email.Text.Trim() + "'," +
                        "emp_monthly_salary = '" + txt_salary.Text.Trim() + "'," +
                        //"emp_type_id = '" + cmb_emp_type.Text.Trim() + "'," +
                        "emp_allowance = '" + txt_allowance.Text.Trim() + "'," +
                        "emp_joindate = '" + dtp_joiningdate.Value.ToShortDateString() + "'," +
                        "emp_bloodgrp = '" + cmb_bloodgrp.Text.Trim() + "'," +
                        "emp_gender = '" + gender.Trim() + "'" +
                        "WHERE emp_id = " + id;

                                           

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Update Operation");
                    btn_new.PerformClick();
                    myFillGridDetail();
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            /*try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM employee WHERE emp_id = " + id;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully", "Delete Operation");
                    btn_new.PerformClick();
                    myFillGridDetail();
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

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            clsemp.name = txt_name.Text.Trim();
        }

        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            clsemp.nic = Convert.ToInt32(txt_nic.Text.Trim());
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            clsemp.email = txt_email.Text.Trim();
        }

        private void txt_salary_TextChanged(object sender, EventArgs e)
        {
            clsemp.salary = Int32.Parse(txt_salary.Text.Trim());
        }

        private void cmb_emptype_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsemp.emptype = cmb_emptype.SelectedValue.ToString();
        }

        private void txt_allowance_TextChanged(object sender, EventArgs e)
        {
            clsemp.allowance = Convert.ToInt32(txt_allowance.Text.Trim());
        }

        private void dtp_joiningdate_ValueChanged(object sender, EventArgs e)
        {
            clsemp.joindate = dtp_joiningdate.ToString();
        }

        private void txt_jobrole_TextChanged(object sender, EventArgs e)
        {
            clsemp.jobrole = txt_jobrole.Text.Trim();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_male_CheckedChanged(object sender, EventArgs e)
        {
            clsemp.gender = rb_male.Checked.ToString();
        }

        private void rb_female_CheckedChanged(object sender, EventArgs e)
        {
            clsemp.gender = rb_female.Checked.ToString();
        }

        private void txt_salary_Click(object sender, EventArgs e)
        {
            txt_salary.SelectAll();
        }
    }
}
