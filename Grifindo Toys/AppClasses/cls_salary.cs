using Grifindo_Toys.CommonClasses;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_salary
    {

        Common cmn = new Common();
        filloperation fill = new filloperation();
        dbconnection con = new dbconnection();

        public int salaryid { get; set; }

        public int empid { get; set; }

        public string empname { get; set; }

        public string yearmonth { get; set; }

        public DateTime begindate { get; set; }

        public DateTime enddate { get; set; }

        public int cycle_range { get; set; }

        public double gov_tax_rate { get; set; }

        public int leaves { get; set; }

        public int holiday { get; set; }

        public int absent { get; set; }

        public int nopay { get; set; }

        public int overtime { get; set; }

        public int rate { get; set; }

        public int basepay { get; set; }

        public int grosspay { get; set; }


        public void Insertdata()
        {
            /*string query = "INSERT INTO tbl_salary(emp_id, year_month, leaves, holidays, emp_type_id, allowance, joindate, job_role, gender) " +
                "VALUES('" + name + "' , '" + nic + "' , '" + email + "' , '" + salary + "' , '" + emptype + "' , '" + allowance + "' ," +
                " '" + joindate + "' , '" + jobrole + "' , '" + gender + "')";

            cmn.messages(query, "insert");*/
        }


        public void UpdateData()
        {
            /*string query = "UPDATE tbl_employee SET name = '" + name + "', nic = '" + nic + "', email = '" + email + "', monthly_salary = '" + salary + "', " +
                "  emp_type_id = '" + emptype + "', allowance = '" + allowance + "', joindate = '" + joindate + "', job_role = '" + jobrole + "', gender = '" + gender + "'" +
                " WHERE emp_id = " + empid;

            cmn.messages(query, "update");*/
        }

        public void DeleteDate()
        {
            /*string query = "Delete from tbl_employee WHERE emp_id = " + empid;

            cmn.messages(query, "delete");
        }*/

            /*
            public void FillEmployeTypeToField()
            {
                string qry = "SELECT * FROM tbl_employee WHERE emp_id = " + empid;
                filloperation fill = new filloperation();
                SqlDataReader rd = fill.FillWithID(qry);

                if (rd.Read())
                {
                    name = rd["name"].ToString();
                    nic = Convert.ToInt32(rd["nic"]);
                    email = rd["email"].ToString();
                    salary = Convert.ToInt32(rd["monthly_salary"]);
                    emptype = rd["emp_type_id"].ToString();
                    allowance = Convert.ToInt32(rd["allowance"]);
                    joindate = rd["joindate"].ToString();
                    jobrole = rd["job_role"].ToString();
                    gender = rd["gender"].ToString();
                }*/
        }

        public void SettingDetails()
        {
            SqlDataReader rd = fill.getBeginDate(yearmonth);
            if (rd.Read())
            {
                begindate = Convert.ToDateTime(rd["begin_date"].ToString());
                enddate = Convert.ToDateTime(rd["end_date"].ToString());
                cycle_range = Convert.ToInt32(rd["cycle_range"]);
                gov_tax_rate = Convert.ToInt32(rd["gov_tax_rate"]);
            }

        }
        public void TotalLeave()
        {
            string qry = $"SELECT SUM(days) AS TotalLeave FROM tbl_leave WHERE start_date >= '{begindate.ToString("yyyy-MM-dd")}' AND end_date <='{enddate.ToString("yyyy-MM-dd")}' AND emp_id = " + empid;

            SqlDataReader rd = fill.runReader(qry);
            if (rd.Read())
            {
                leaves = Convert.ToInt32(rd["TotalLeave"]);

            }
            con.mycon.Close();
        }
    }
}
