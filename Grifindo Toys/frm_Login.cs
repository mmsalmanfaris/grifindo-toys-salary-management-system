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
    public partial class frm_login : Form
    {
        public SqlConnection mycon = new SqlConnection("Data Source=MMSALMANFARIS;Initial Catalog=Grifindo_Toys;Integrated Security=True;Encrypt=False");
        public frm_login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_username.Text.Trim() != "" && txt_password.Text.Trim() != "")
                {
                    mycon.Open();
                    string qry = "SELECT * FROM tbl_admin WHERE username = '" + txt_username.Text.Trim() + "' " +
                    "AND password = '" + txt_password.Text.Trim() + "' ";

                    SqlCommand cmd = new SqlCommand(qry, mycon);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        frm_dashboard dashboard_frm = new frm_dashboard();
                        dashboard_frm.ShowDialog();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Incorrect Username or Password");
                }
                else
                    MessageBox.Show("Incorrect Username or Password");
            }
             catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { mycon.Close(); }
            
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
