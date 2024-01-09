using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Drawing;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_setting
    {
        Common cmn = new Common();

        public int seting_id { get; set; }

        public decimal gov_tax { get; set; }

        public string begindate { get; set;}

        public string endDate { get; set; }

        public string range { get; set; }

        public string yearmonth { get; set; }


        public void Insertdata()
        {
            string query = "INSERT INTO tbl_setting(gov_tax_rate, yearmonth, begin_date, end_date, cycle_range) " +
                           "VALUES('" + gov_tax + "' , '" + yearmonth + "' , '" + begindate + "' , '" + endDate + "' , '" + range + "')";

            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_setting SET gov_tax_rate = '" + gov_tax + "', yearmonth = '" + yearmonth + "', begin_date = '" + begindate + "', end_date = '" + endDate + "'," +
                " cycle_range = '" + range + "' WHERE emp_id = " + seting_id;

            cmn.messages(query, "update");
        }

        public void DeleteData()
        {
            string query = "Delete from tbl_setting WHERE setting_id = " + seting_id;

            cmn.messages(query, "delete");
        }


        public void FillEmployeTypeToField()
        {
            string qry = "SELECT * FROM tbl_setting WHERE setting_id = " + seting_id;
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                gov_tax = Convert.ToDecimal(rd["gov_tax_rate"]);
                yearmonth = rd["yearmonth"].ToString();
                begindate = rd["begin_date"].ToString();
                endDate = rd["end_date"].ToString();
                range = rd["cycle_range"].ToString();
            }
        }
    }
}
