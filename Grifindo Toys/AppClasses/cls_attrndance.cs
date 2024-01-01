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

        
        public string date { get; set; }

        public string intime { get; set; }

        public string outime { get; set; }

        public string hours { get; set; }




        public void Insertdata()
        {
            string query = "INSERT INTO tbl_attendance(emp_id, date, in_time, out_time, hours ) " +
                           "VALUES('" + empid + "' , '" + date + "' , '" + intime + "' , '" + outime + "' , '" + hours + "')";

            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_attendance SET emp_id = '" + empid + "', date = '" + date + "', in_time = '" + intime + "'," +
                           " out_time = '" + outime + "', hours = '" + hours + "' WHERE attendance_id = " + attendanceid;

            cmn.messages(query, "update");
        }

        public void DeleteData()
        {
            string query = "Delete from tbl_attendance WHERE attendance_id = " + attendanceid;

            cmn.messages(query, "delete");
        }


        public void FillEmployeTypeToField()
        {
            string qry = "SELECT * FROM tbl_attendance WHERE attendance_id = " + attendanceid;
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                empid = (int)rd["emp_id"];
                date = rd["date"].ToString();
                intime = rd["in_time"].ToString();
                outime = rd["out_time"].ToString();
                hours = rd["hours"].ToString();
            }
        }
    }
}
