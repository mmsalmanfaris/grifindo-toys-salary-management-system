using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_employeetype
    {
        Common cmn = new Common();

        public int emptype_id { get; set; }

        public string emptype { get; set;}

        public int Overtimerate { get; set;}

        public string Annualleaves { get; set;}

        public void Inserdata()
        {
            string query = "INSERT INTO tbl_employeetype(emp_type, overtime_rate_hour, annual_leave) VALUES " +
                "('" + emptype + "' , " + Overtimerate + " , '" + Annualleaves + "')";
            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_employeetype SET emp_type = '" + emptype + "', overtime_rate_hour = " + Overtimerate + ", " +
                "annual_leave = " + Annualleaves + " WHERE emp_type_id = " + emptype_id;
            cmn.messages(query, "update");
        }

        public void DeleteDate()
        {
            string query = "Delete from tbl_employeetype WHERE emp_type_id = " + emptype_id;
            cmn.messages(query, "delete");
        }

        public void FillEmployeTypeToField()
        {
            string qry = "SELECT * FROM tbl_employeetype WHERE emp_type_id = " + emptype_id;
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);
            if (rd.Read())
            {
                emptype = rd["emp_type"].ToString();
                Overtimerate = Convert.ToInt32(rd["overtime_rate_hour"]);
                Annualleaves = rd["annual_leave"].ToString();
            }
        }
    }
}
