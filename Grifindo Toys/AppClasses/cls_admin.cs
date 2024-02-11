using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_admin
    {

        Common cmn = new Common();

        public int adminid { get; set; }

        public string name { get; set; }

        public string nic { get; set; }

        public string username { get; set; }

        public string password { get; set; }




        public void Insertdata()
        {
            string query = "INSERT INTO tbl_admin(name, nic, username, password) " +
                           "VALUES('" + name + "' , '" + nic + "' , '" + username + "' , '" + password + "')";

            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_admin SET name = '" + name + "', nic = '" + nic + "', username = '" + username + "'," +
                " password = '" + password + "' WHERE admin_id = " + adminid;

            cmn.messages(query, "update");
        }

        public void DeleteData()
        {
            string query = "Delete from tbl_admin WHERE admin_id = " + adminid;

            cmn.messages(query, "delete");
        }


        public void Getdata()
        {
            string qry = "SELECT * FROM tbl_admin WHERE admin_id = " + adminid;
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                name = rd["name"].ToString();
                nic = rd["nic"].ToString();
                username = rd["username"].ToString();
                password = rd["password"].ToString();
            }
        }
    }
}
