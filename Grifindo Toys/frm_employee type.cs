using Grifindo_Toys.AppClasses;
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
    public partial class frm_emp_type : Form
    {   
        cls_employeetype clsemptype = new cls_employeetype();

        public frm_emp_type()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_emp_type_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_emp_type_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* id = dgv_emp_type.Rows[e.RowIndex].Cells[0].Value.ToString();

            try
            {
                string qry = "SELECT * FROM employee_type WHERE emp_type_id = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txt_emp_type.Text = rdr[1].ToString();
                    txt_overtime.Text = rdr[2].ToString();
                }
                btn_new.Enabled = false;
                btn_save.Enabled = true;
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            clsemptype.Inserdata();
        }
        void myFillGridDetail()
        {
            /*try
            {
                string qry = "SELECT * FROM employee_type";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgv_emp_type.DataSource = dt;

                dgv_emp_type.Columns[0].Visible = true;
                //dgv_employee.Columns[1].HeaderText = "First Name";
                dgv_emp_type.Columns[1].Width = 200;

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
                    string qry = "UPDATE employee_type SET " +
                        "emp_type = '" + txt_emp_type.Text.Trim() + "'," +
                        "overtime_rate_hour = '" + txt_overtime.Text.Trim() + "'," +
                        "WHERE emp_type_id = " + id;

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
                    string qry = "DELETE FROM employee_type WHERE emp_type_id = " + id;
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

        private void txt_emp_type_TextChanged(object sender, EventArgs e)
        {
            clsemptype.emptype = txt_emp_type.Text.Trim();
        }

        private void txt_overtime_TextChanged(object sender, EventArgs e)
        {
            clsemptype.Overtimerate =  Convert.ToInt32(txt_overtime.Text.Trim());
        }

        private void txt_annualleave_TextChanged(object sender, EventArgs e)
        {
            clsemptype.Annualleaves = txt_annualleave.Text.Trim();
        }
    }   
}
