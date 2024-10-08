﻿using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_leave
    {
        Common cmn = new Common();
        filloperation fill = new filloperation();


        public int leaveid { get; set; }

        public int emp_id { get; set; }

        public string start { get; set; }

        public string end { get; set; }

        public string days { get; set; }

        public string reason { get; set; }


        

        public void Insertdata()
        {
            string query = "INSERT INTO tbl_leave(emp_id, start_date, end_date, days, reason ) " +
                           "VALUES('" + emp_id + "' , '" + start + "' , '" + end + "' , '" + days + "' , '" + reason + "')";

            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_leave SET emp_id = '" + emp_id + "', start_date = '" + start + "', end_date = '" + end + "'," +
                           " days = '" + days + "', reason = '" + reason + "' WHERE leave_id = " + leaveid;

            cmn.messages(query, "update");
        }

        public void DeleteData()
        {
            string query = "Delete from tbl_leave WHERE leave_id = " + leaveid;

            cmn.messages(query, "delete");
        }


        public void Getdata()
        {
            string qry = "SELECT * FROM tbl_leave WHERE leave_id = " + leaveid;
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                emp_id = Convert.ToInt32(rd["emp_id"].ToString());
                start = rd["start_date"].ToString();
                end = rd["end_date"].ToString();
                days = rd["days"].ToString();
                reason = rd["reason"].ToString();
            }
        }
    }
}
