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
    public partial class frm_admin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=SALMAN_FARIS\\SQLEXPRESS;Initial Catalog=grifindo_toys;Integrated Security=True");

        string id = string.Empty;
        public frm_admin()
        {
            InitializeComponent();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_name.Text = string.Empty;
            txt_nic.Text = string.Empty;
            txt_password.Text = string.Empty;
            txt_username.Text = string.Empty;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM admin WHERE admin_id = " + id;

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Delete Successfully", "Delete Operation");

                    btn_new.PerformClick();
                    griddetail();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE admin SET " +
                        "name = '" + txt_name.Text.Trim() + "'," +
                        "nic = '" + txt_nic.Text.Trim() + "'," +
                        "username = '" + txt_username.Text.Trim() + "'," +
                        "password = '" + txt_password.Text.Trim()+ "'" +
                        "WHERE admin_id = " + id;



                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated Successfully", "Update Operation");

                    btn_new.PerformClick();
                    griddetail();
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            { 
                string name = txt_name.Text.Trim();
                string nic = txt_nic.Text.Trim();
                string username = txt_username.Text.Trim();
                string password = txt_password.Text.Trim();

                string qry = "INSERT INTO admin (name, nic, username, password) VALUES('" + name + "','" + nic+ "','" + username+ "','" + password+ "')";

                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saves Successfull");

                griddetail();
                btn_new.PerformClick();
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
        void griddetail()
        {
            string qry = "SELECT * FROM admin";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            da.Fill(dt);
            dgv_admin.DataSource = dt;

            dgv_admin.Columns[0].Visible = false;
        }

        private void admin_Load(object sender, EventArgs e)
        {
            griddetail();
        }

        private void dgv_admin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgv_admin.Rows[e.RowIndex].Cells[0].Value.ToString();

            try
            {
                string qry = "SELECT * FROM admin WHERE admin_id = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txt_name.Text = rdr[1].ToString();
                    txt_nic.Text = rdr[2].ToString();
                    txt_username.Text= rdr[3].ToString();
                    txt_password.Text = rdr[4].ToString();
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
    }
}
