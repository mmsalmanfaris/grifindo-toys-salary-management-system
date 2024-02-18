using Grifindo_Toys.AppClasses;
using Grifindo_Toys.CommonClasses;
using System;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class frm_salary : Form
    {
        filloperation fill = new filloperation();
        cls_salary salary = new cls_salary();

        public frm_salary()
        {
            InitializeComponent();
        }
 
        void Firstrun()
        {            
            salary.monthyear = DateTime.Now.ToString("MMMM") + "  " + DateTime.Now.ToString("yyyy");
            lblmonthyear.Text = salary.monthyear.ToString();

            fill.combobox("SELECT * FROM tbl_employee", cmb_empid, "full_name", "emp_id");

            salary.SettingDetails();
        }

        void refresh()
        {
            //Empty the calculated results
            lbl_nopay.Text = "";
            lbl_grosspay.Text = "";
            lbl_basepay.Text = "";
            lbl_overtimepayment.Text = "";

            //Customising Datagrideview header
            fill.FillDataGridView("SELECT * FROM tbl_salary", dgv_empoyee_salary);
            dgv_empoyee_salary.Columns[0].HeaderText = "ID";
            dgv_empoyee_salary.Columns[1].HeaderText = "Emp ID";
            dgv_empoyee_salary.Columns[2].HeaderText = "Month";
            dgv_empoyee_salary.Columns[3].HeaderText = "Attendance";
            dgv_empoyee_salary.Columns[4].HeaderText = "Leave";
            dgv_empoyee_salary.Columns[5].HeaderText = "Absent";
            dgv_empoyee_salary.Columns[6].HeaderText = "Holiday";
            dgv_empoyee_salary.Columns[7].HeaderText = "Over Time";
            dgv_empoyee_salary.Columns[8].HeaderText = "Salary";
            dgv_empoyee_salary.Columns[9].HeaderText = "Allowance";
            dgv_empoyee_salary.Columns[10].HeaderText = "OT Rate";
            dgv_empoyee_salary.Columns[11].HeaderText = "Tax";
            dgv_empoyee_salary.Columns[12].HeaderText = "OT Ammount";
            dgv_empoyee_salary.Columns[13].HeaderText = "No Pay";
            dgv_empoyee_salary.Columns[14].HeaderText = "Base Pay";
            dgv_empoyee_salary.Columns[15].HeaderText = "Gross Pay";
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void frm_salary_Load(object sender, EventArgs e)
        {
            Firstrun();
            refresh();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void dgv_empoyee_salary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_empoyee_salary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            salary.Insertdata();
            refresh();
        }

        private void lbl_holidays_Click(object sender, EventArgs e)
        {
        }

        public void cmb_empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            salary.empid = Convert.ToInt32(cmb_empid.SelectedValue);
            salary.SettingDetails();
            salary.TotalLeave();
            salary.TotalOverTime();
            lbl_attendence.Text = salary.attendance.ToString() + " Days";
            lbl_leaves.Text = salary.leaves.ToString() + " Days";
            lbl_holidays.Text = salary.holiday.ToString() + " Days";
            lbl_overtime.Text = Math.Round(salary.overtime / 60).ToString() + " Hours";
            lbl_taxrate.Text = salary.gov_tax_rate.ToString() + "%";

            salary.GetEmployeeDetails();
            salary.overtimerate();
            lbl_monthlysalary.Text = salary.salary.ToString() + ".00";
            lbl_allowance.Text = salary.allowance.ToString() + ".00";
            lbl_overtimerate.Text = salary.rate.ToString() + ".00";
            salary.PayValues();
            lbl_absents.Text = salary.total_absent.ToString() + " Days";

            refresh();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_overtimepayment.Text = "= " + salary.overtime_payment.ToString() + ".00";
            lbl_nopay.Text = "= " + salary.nopay.ToString() + ".00";
            lbl_basepay.Text = "= " + salary.basepay.ToString() + ".00";
            lbl_grosspay.Text = "= " + salary.grosspay.ToString() + ".00";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void lbl_absents_Click(object sender, EventArgs e)
        {

        }

        private void lbl_leaves_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            refresh();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            salary.UpdateData();
            refresh();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            salary.DeleteDate();
            Firstrun();
        }
    }
}
