using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_employee
    {
        Common cmn = new Common();

        public int empid { get; set; }

        public string name {  get; set; }

        public string fullname { get; set; }

        public string nic { get; set; }

        public string email {  get; set; }

        public decimal salary { get; set; }

        public string emptype { get; set; }

        public decimal allowance { get; set; }

        public DateTime joindate { get; set;}

        public string jobrole { get; set;}

        public string gender { get; set;}


        public void Insertdata()
        {
            string query = "INSERT INTO tbl_employee(name, full_name, nic, email, monthly_salary, emp_type_id, allowance, joindate, job_role, gender) " +
                "VALUES('" + name + "' , '" + fullname + "' , '" + nic + "' , '" + email + "' , '" + salary + "' , '" + emptype + "' , '" + allowance + "' ," +
                " '" + joindate + "' , '" + jobrole + "' , '" + gender + "')";

            cmn.messages(query, "insert");
        }


        public void UpdateData()
        {
            string query = "UPDATE tbl_employee SET name = '" + name + "', full_name = '" + fullname + "', nic = '" + nic + "', email = '" + email + "', monthly_salary = '" + salary + "', " +
                "  emp_type_id = '" + emptype + "', allowance = '" + allowance + "', joindate = '" + joindate + "', job_role = '" + jobrole + "', gender = '" + gender + "'" +
                " WHERE name = '" + name + "'";

            cmn.messages(query, "update");
        }

        public void DeleteDate()
        {
            string query = "Delete from tbl_employee WHERE name = '" + name + "'";

            cmn.messages(query, "delete");
        }


        public void FillEmployeTypeToField()
        {
            string qry = "SELECT * FROM tbl_employee WHERE name = '" + name + "'";
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                name = rd["name"].ToString();
                fullname = rd["full_name"].ToString();
                nic =  Convert.ToString(rd["nic"]);
                email = rd["email"].ToString();
                salary = Convert.ToInt32(rd["monthly_salary"]);
                emptype = rd["emp_type_id"].ToString();
                allowance = Convert.ToInt32(rd["allowance"]);
                joindate = Convert.ToDateTime( rd["joindate"]);
                jobrole = Convert.ToString(rd["job_role"]);
                gender = rd["gender"].ToString();
            }
        }
    }
}
