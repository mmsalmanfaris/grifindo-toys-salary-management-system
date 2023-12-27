using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string qry = "INSERT INTO tbl_employeetype(emp_type, overtime_rate_hour, annual_leave) VALUES " +
                "('" + emptype + "' , '" + Overtimerate + "' , '" + Annualleaves + "')";
            cmn.messages(qry, "insert");
        }
    }
}
