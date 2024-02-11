using Grifindo_Toys.CommonClasses;
using System;
using System.Data.SqlClient;

namespace Grifindo_Toys.AppClasses
{
    internal class cls_salary
    {

        Common cmn = new Common();
        filloperation fill = new filloperation();
        dbconnection con = new dbconnection();

        public int salaryid { get; set; }

        public int empid { get; set; }

        public string empname { get; set; }

        public string monthyear { get; set; }

        public DateTime begindate { get; set; }

        public DateTime enddate { get; set; }

        public int cycle_range { get; set; }

        public double salary { get; set; }

        public double allowance { get; set; }

        public double gov_tax_rate { get; set; }

        public int attendance {  get; set; }

        public int leaves { get; set; }

        public int holiday { get; set; }

        public int total_absent { get; set; }

        public double nopay { get; set; }

        public double overtime { get; set; }

        public int rate { get; set; }

        public double overtime_payment {  get; set; }

        public double basepay { get; set; }

        public double grosspay { get; set; }


        public void Insertdata()
        {
            string query = "INSERT INTO tbl_salary(emp_id, month_year, attendance, leaves, absents, holidays, over_time, salary, allowance, overtime_rate, tax, over_time_payment, no_pay, base_pay, gross_pay) " +
                "VALUES('" + empid + "' , '" + monthyear + "' , '" + attendance + "' , '" + leaves + "' , '" + total_absent + "' , '" + holiday + "' ," +
                " '" + overtime + "' , '" + salary + "' , '" + allowance + "' , '" + rate + "' , '" + gov_tax_rate + "' , '" + overtime_payment + "' , '" + nopay + "' , '" + basepay + "' , '" + grosspay + "')";

            cmn.messages(query, "insert");
        }

        public void UpdateData()
        {
            string query = "UPDATE tbl_salary SET emp_id = '" + empid + "', month_year = '" + monthyear + "', attendance = '" + attendance + "', leaves = '" + leaves + "', " +
                "  absents = '" + total_absent + "', holidays = '" + holiday + "', over_time = '" + overtime + "', salary = '" + salary + "', allowance = '" + allowance + "', overtime_rate = '" + rate + 
                "', tax = '" + gov_tax_rate + "', over_time_payment = '" + overtime_payment + "', no_pay = '" + nopay + "', base_pay = '" + basepay + "', gross_pay = '" + grosspay +"' '"+
                " WHERE salary_id = '" + salaryid + "'";

            cmn.messages(query, "update");
        }

        public void DeleteDate()
        {
            string query = "Delete from tbl_salary WHERE salary_id = '" + salaryid + "'";

            cmn.messages(query, "delete");
        }

        public void Getdata()
        {
            string qry = "SELECT * FROM tbl_salary WHERE salary_id = '" + salaryid + "'";
            filloperation fill = new filloperation();
            SqlDataReader rd = fill.FillWithID(qry);

            if (rd.Read())
            {
                empid = Convert.ToInt32(rd["emp_id"].ToString());
                monthyear = rd["month_year"].ToString();
                attendance = Convert.ToInt32(rd["attendance"]);
                leaves = Convert.ToInt32(rd["leaves"]);
                total_absent = Convert.ToInt32(rd["absents"]);
                holiday = Convert.ToInt32(rd["holidays"]);
                overtime = Convert.ToInt32(rd["over_time"]);
                salary = Convert.ToInt32(rd["salary"]);
                allowance = Convert.ToInt32(rd["allowance"]);
                rate = Convert.ToInt32(rd["overtime_rate"]);
                gov_tax_rate = Convert.ToInt32(rd["tax"]);
                overtime_payment = Convert.ToInt32(rd["over_time_payment"]);
                nopay = Convert.ToInt32(rd["no_pay"]);
                basepay = Convert.ToInt32(rd["base_pay"]);
                grosspay = Convert.ToInt32(rd["gross_pay"]);
        }
            }

        public void SettingDetails()
        {
            SqlDataReader rd = fill.getBeginDate(monthyear);
            if (rd.Read())
            {
                begindate = Convert.ToDateTime(rd["begin_date"]);
                enddate = Convert.ToDateTime(rd["end_date"]);
                cycle_range = Convert.ToInt32(rd["cycle_range"]);
                gov_tax_rate = Convert.ToInt32(rd["gov_tax_rate"]);

                con.mycon.Close();
                rd.Close();
                rd = null;
                TotalHoliday();
            }
        }

        public void TotalLeave()
        {
            string qry = $"SELECT SUM(days) AS TotalLeave FROM tbl_leave WHERE start_date >= '{begindate.ToString("yyyy-MM-dd")}' AND end_date <='{enddate.ToString("yyyy-MM-dd")}' AND emp_id = " + empid;

            using (SqlDataReader rd = fill.runReader(qry))
            {
                if (rd.HasRows)
                {
                    rd.Read();

                    if (rd["TotalLeave"] != DBNull.Value)
                    {
                        leaves = Convert.ToInt32(rd["TotalLeave"]);
                        rd.Close();
                    }
                }
            }
        }



        public void TotalOverTime()
        {
            string qry = $"SELECT SUM(DATEDIFF(MINUTE,in_time,out_time) - 480)  AS Total_Hours, COUNT(working_date) AS Total_Attendance FROM tbl_attendance WHERE working_date >= '{begindate}' AND working_date <='{enddate}' AND emp_id = " + empid;

            SqlDataReader rd = fill.runReader(qry);
            if (rd.Read())
            {
                overtime = Convert.ToInt32(rd["Total_Hours"]);
                attendance = Convert.ToInt32(rd["Total_Attendance"]);
            }
            rd.Close();
            rd = null;
            con.mycon.Close();
        }

        public void GetEmployeeDetails()
        {

            string qry = $"SELECT * FROM tbl_employee WHERE emp_id = {empid}";
            SqlDataReader rd = fill.runReader(qry);
            if (rd.Read())
            {
                salary= Convert.ToDouble(rd["monthly_salary"]);
                allowance= Convert.ToDouble(rd["allowance"]);                
            }
            rd.Close();
            rd = null;
            con.mycon.Close();
        }

        public void overtimerate()
        {
            rate = (int)fill.Overtime_rate(empid);
            overtime_payment = Math.Round(overtime / 60) * rate;
        }

        public void TotalHoliday()
        {
            string qry = $"SELECT COUNT(holiday) AS totalholidays FROM tbl_holiday WHERE holiday >= '{begindate.ToString("yyyy-MM-dd")}' AND holiday <='{enddate.ToString("yyyy-MM-dd")}'";

            SqlDataReader rd = fill.runReader(qry);


            if (rd.Read())
            {
                holiday = Convert.ToInt32(rd["totalholidays"]);
            }
            rd.Close();
            rd = null;
            con.mycon.Close() ;
        }


        public void PayValues()
        {
            total_absent = (cycle_range - (attendance + holiday + leaves));
            nopay = (int)((salary / cycle_range) * total_absent);
            basepay = (int)(salary + allowance + overtime_payment);
            grosspay = (int)(basepay - (nopay + (basepay * gov_tax_rate / 100)));
        }
    }
}
