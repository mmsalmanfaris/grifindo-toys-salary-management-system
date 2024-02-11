using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_attrndance
    {
        Common cmn = new Common();


        public int attendanceid { get; set; }

        public int empid { get; set; }

        
        public DateTime date { get; set; }

        public DateTime intime { get; set; }

        public DateTime outime { get; set; }

        public double minutes { get; set; }



        public void Insertdata()
        {
            string query = "INSERT INTO tbl_attendance(emp_id, working_date, in_time, out_time, working_minutes ) " +
                           "VALUES('" + empid + "' , '" + date + "' , '" + intime + "' , '" + outime + "' , '" + minutes + "')";

            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_attendance SET emp_id = '" + empid + "', date = '" + date + "', in_time = '" + intime + "'," +
                           " out_time = '" + outime + "', working_minutes = '" + minutes + "' WHERE attendance_id = " + attendanceid;

            cmn.messages(query, "update");
        }

        public void DeleteData()
        {
            string query = "Delete from tbl_attendance WHERE attendance_id = " + attendanceid;

            cmn.messages(query, "delete");
        }


        public void Getdata()
        {
            string qry = "SELECT * FROM tbl_attendance WHERE attendance_id = " + attendanceid;
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                empid = (int)rd["emp_id"];
                date = Convert.ToDateTime(rd["date"]);
                intime = Convert.ToDateTime(rd["in_time"].ToString());
                outime = Convert.ToDateTime(rd["out_time"].ToString());
                minutes = Convert.ToDouble(rd["working_minutes"].ToString());
            }
        }
    }
}
