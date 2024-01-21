using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_holiday
    {

        Common cmn = new Common();

        public int holidayid { get; set; }

        public string name { get; set; }

        public string holiday { get; set; }




        public void Insertdata()
        {
            string query = "INSERT INTO tbl_holiday(name, holiday) " +
                           "VALUES('" + name + "' , '" + holiday + "')";

            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_holidays SET name = '" + name + "', holiday = '" + holiday + "' WHERE holiday_id = " + holidayid;

            cmn.messages(query, "update");
        }

        public void DeleteData()
        {
            string query = "Delete from tbl_holidays WHERE holiday_id = " + holidayid;

            cmn.messages(query, "delete");
        }


        public void FillEmployeTypeToField()
        {
            string qry = "SELECT * FROM tbl_holidays WHERE holiday_id = " + holidayid;
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            { 
                name = rd["name"].ToString();
                holiday = rd["date"].ToString();
            }
        }
    }
}
