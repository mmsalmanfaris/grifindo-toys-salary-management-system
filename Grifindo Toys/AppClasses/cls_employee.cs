using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_employee
    {
        Common cmn = new Common();

        public string name {  get; set; }

        public int nic { get; set; }

        public string email {  get; set; }

        public int salary { get; set; }

        public string emptype { get; set; }

        public int allowance { get; set; }

        public string joindate { get; set;}

        public string jobrole { get; set;}

        public string gender { get; set;}


        public void Insertdata()
        {
            string qry = "INSERT INTO tbl_employee(name, nic, email, monthly_salary, emp_type_id, allowance, join_date, job_role, gender) " +
                "VALUES('" + name +"' , '" + nic + "' , '" + email + "' , '" + salary + "' , '" + emptype + "' , '" + allowance + "' ," +
                " '" + joindate + "' , '" + jobrole + "' , '" + gender + "')";

            cmn.messages(qry, "insert");
        }

 
    }
}
