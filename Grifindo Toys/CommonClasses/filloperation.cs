using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
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

        public double Completed_leaves(int empid)
        {
            try
            {
                con.mycon.Open();
                string qry = "SELECT SUM(days) AS TotalLeaves FROM tbl_leave WHERE emp_id = " + empid;
                SqlCommand cmd = new SqlCommand(qry, con.mycon);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read() || rdr["TotalLeaves"] == null)
                {
                    leaves = Convert.ToDouble(rdr["TotalLeaves"]);
                }
                else
                {
                    leaves = 0;
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
            return leaves;
        }

        public double total_leaves(int emp_id)
        {
            try
            {
                con.mycon.Open();
                string qry = "SELECT et.annual_leave AS annual_leave FROM tbl_employee e INNER JOIN tbl_employeetype et ON e.emp_type_id = et.emp_type_id WHERE e.emp_id = " + emp_id;
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

        public double Overtime_rate(int emp_id)
        {
            double overtimeRate = 0;

            try
            {
                con.mycon.Open();
                string qry = "SELECT et.overtime_rate_hour AS overtime_rate FROM tbl_employee e INNER JOIN tbl_employeetype et ON e.emp_type_id = et.emp_type_id WHERE e.emp_id = " + emp_id;
                SqlCommand cmd = new SqlCommand(qry, con.mycon);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    overtimeRate = Convert.ToDouble(rdr["overtime_rate"]);
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

            return overtimeRate;
        }


        public SqlDataReader getBeginDate(string monthyear)
        {
            con.mycon.Open();
            string qry = $"SELECT * FROM tbl_setting WHERE yearmonth = '{monthyear}'";
            SqlCommand cmd = new SqlCommand(qry, con.mycon);
            SqlDataReader rdr = cmd.ExecuteReader();
            return rdr;
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
