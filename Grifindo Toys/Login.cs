﻿using System;
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
        SqlConnection con = new SqlConnection("Data Source=SALMAN_FARIS\\SQLEXPRESS;Initial Catalog=grifindo_toys;Integrated Security=True");

        string id = string.Empty;

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
                    con.Open();
                    string qry = "SELECT * FROM admin WHERE username = '" + txt_username.Text.Trim() + "' " +
                    "AND password = '" + txt_password.Text.Trim() + "' ";

                    SqlCommand cmd = new SqlCommand(qry, con);
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
            finally { con.Close(); }
            
        }
    }
}
