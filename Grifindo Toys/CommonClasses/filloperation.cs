using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys.CommonClasses
{
    internal class filloperation
    {
        dbconnection con = new dbconnection();

        public void combobox(string qry, ComboBox cmb_name, string display_member, string value_member)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, con.mycon);
            da.Fill(dt);
            cmb_name.DisplayMember = display_member;
            cmb_name.ValueMember = value_member;
            cmb_name.DataSource = dt;
        }

        public void FillDataGridView(string qry, DataGridView dgv)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, con.mycon);
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        public SqlDataReader FillWithID(string qry)
        {
            con.mycon.Open();
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

    }
}
