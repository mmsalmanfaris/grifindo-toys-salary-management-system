using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_salary
    {

        Common cmn = new Common();

        public int empid { get; set; }

        public string yearmoth { get; set; }

        public string begindate { get; set; }

        public string enddate { get; set; }

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
    }
}
