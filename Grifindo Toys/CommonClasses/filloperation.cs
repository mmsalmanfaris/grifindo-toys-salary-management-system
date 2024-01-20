using Microsoft.ReportingServices.Diagnostics.Internal;
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

        double leaves;
        double totalleaves;

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

        public double AvailableLeave(int empid)
        {
            try
            {
                con.mycon.Open();
                string qry = "SELECT SUM(TRY_CONVERT(INT, days)) AS TotalLeaves FROM tbl_leave WHERE emp_id = " + empid;
                SqlCommand cmd = new SqlCommand(qry, con.mycon);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read() && rdr["TotalLeaves"] != DBNull.Value)
                {
                    leaves = Convert.ToInt32(rdr["TotalLeaves"]);
                }

                return leaves;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.mycon.Close();
            }

        }

        public double TotalLeave(int emp_id)
        {
            try
            {
                con.mycon.Open();
                string qry = "SELECT et.annual_leave FROM tbl_employee e INNER JOIN tbl_employeetype et ON e.emp_type_id = et.emp_type_id WHERE e.emp_id = " + emp_id;
                SqlCommand cmd = new SqlCommand(qry, con.mycon);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    totalleaves = Convert.ToInt32(rdr["annual_leave"]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.mycon.Close();
            }

            return totalleaves;
        }

        public SqlDataReader getBeginDate(string yearmonth)
        {
            con.mycon.Open();
            string qry = $"SELECT * FROM tbl_setting WHERE yearmonth = '{yearmonth}'";
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        public void FillCombobox(string qry, ComboBox cmbox_name, string display_mem, string value_mem)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(qry, con.mycon);
            da.Fill(dt);
            cmbox_name.DisplayMember = display_mem;
            cmbox_name.ValueMember = value_mem;
            cmbox_name.DataSource = dt;
        }

        public SqlDataReader runReader(string qry)
        {
            con.mycon.Open();
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
        }

        public DataTable getData(string qry)
        {
            con.mycon.Open();
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.mycon.Close();
            return dt;

        }

    }

}
