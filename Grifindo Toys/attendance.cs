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
/*
namespace Grifindo_Toys
{
    public partial class frm_attendance : Form
    {

       SqlConnection con = new SqlConnection("Data Source=SALMAN_FARIS\\SQLEXPRESS;Initial Catalog=grifindo_toys;Integrated Security=True");

        string id = string.Empty;

        public frm_attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            GridDetail();

            string qry = "SELECT * FROM emp_attendance_salary";

            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmb_employee.DisplayMember = "name";
            cmb_employee.ValueMember = "emp_id";
            cmb_employee.DataSource = dt;

            cmb_employee.SelectedIndex = 0;

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            cmb_employee.SelectedIndex = 0;
            /*txt_leave.Text = string.Empty;
            txt_absent.Text = string.Empty;
            txt_holiday.Text = string.Empty;
            txt_overtime.Text = string.Empty;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedemp = Convert.ToInt32(cmb_employee.SelectedValue);
                /*string leaves = txt_leave.Text.Trim();
                string absent = txt_absent.Text.Trim();
                string holidays = txt_holiday.Text.Trim();
                string overtime = txt_overtime.Text.Trim();

               /* string qry = "UPDATE emp_attendance_salary " +
                    "SET no_leaves = '" + leaves + "', no_absent = '" + absent + "', no_holidays = '" + holidays + "', " +
                    "overtime_hours = '" + overtime + "' " +
                    "WHERE emp_id = " + selectedemp;

                /*string qry = "INSERT INTO emp_attendance_salary" +
                    "(no_leaves, no_absent, no_holidays, overtime_hours)" +
                    " VALUES('" + leaves + "','" + absent + "','" + holidays + "','" + overtime + "')";

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
            }
        }
        void GridDetail()
        {
            try
            {
                string qry = "SELECT * FROM emp_attendance_salary";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgv_attendance.DataSource = dt;

                //dgv_attendance.Columns[0].Visible = false;
                //dgv_employee.Columns[1].HeaderText = "First Name";
                dgv_attendance.Columns[1].Width = 50;

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE attendance SET " +
                        "emp_id = '" + cmb_employee.Text.Trim() + "'," +
                        "no_leaves = '" + txt_leave.Text.Trim() + "'," +
                        "no_absent = '" + txt_absent.Text.Trim() + "'," +
                        "no_holidays = '" + txt_holiday.Text.Trim() + "'," +
                        "overtime_hours = '" + txt_overtime.Text.Trim() + "'," +
                        "WHERE attendance_id = " + id;



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
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM attendance WHERE attendance_id = " + id;

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
            }
        }

        private void dgv_attendance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgv_attendance.Rows[e.RowIndex].Cells[0].Value.ToString();

            try
            {
                string qry = "SELECT * FROM attendance WHERE attendance_id = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    cmb_employee.Text = rdr[1].ToString();
                    txt_leave.Text = rdr[2].ToString();
                    txt_absent.Text = rdr[3].ToString();
                    txt_holiday.Text = rdr[4].ToString();
                    txt_overtime.Text = rdr[5].ToString();
                    
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
            }
        }

        private void cmb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
