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
    public partial class frm_setting : Form
    {

        public frm_setting()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           /* try
            {
                string leave = txt_annual_leave.Text.Trim();
                string tax = txt_gov_tax.Text.Trim();
                string begindate = dtp_salary_begin.Value.ToString("yyyy-mm-dd");
                string enddate = dtp_salary_end.Value.ToString("yyyy-mm-dd");
               
                string qry = "INSERT INTO setting" +
                    "(annual_leave, tax_rate, begin_date, end_date)" +
                    " VALUES('" + leave + "','" + tax + "','" + begindate + "','" + enddate + "')";

                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");

                btn_new.PerformClick();

                myFillGridDetail();
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
        void myFillGridDetail()
        {
            /*try
            {
                string qry = "SELECT * FROM setting";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgv_salary_setting.DataSource = dt;

                dgv_salary_setting.Columns[0].Visible = true;
                //dgv_employee.Columns[1].HeaderText = "First Name";
                dgv_salary_setting.Columns[1].Width = 200;

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }*/
        }

        private void Setting_Load(object sender, EventArgs e)
        {
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            /*try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE setting SET " +
                        "annual_leave = '" + txt_annual_leave.Text.Trim() + "'," +
                        "tax_rate = '" + txt_gov_tax.Text.Trim() + "'," +
                        "begin_date = '" + dtp_salary_begin.Value.ToShortDateString() + "'," +
                        "end_date = '" + dtp_salary_end.Value.ToShortDateString() + "'" +
                        "WHERE setting_id = " + id;



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

        private void dgv_salary_setting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           /* id = dgv_salary_setting.Rows[e.RowIndex].Cells[0].Value.ToString();

            try
            {
                string qry = "SELECT * FROM setting WHERE setting_id = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txt_annual_leave.Text = rdr[1].ToString();
                    txt_gov_tax.Text = rdr[2].ToString();
                    string dtp_salary_end = rdr[4].ToString();
                    dtp_salary_end = rdr[4].ToString();

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

        private void dgv_salary_setting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
           /* try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM setting WHERE setting_id = " + id;

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
    }
}
