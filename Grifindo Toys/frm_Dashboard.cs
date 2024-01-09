using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class frm_dashboard : Form
    {
        public frm_dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_emp_type_Click(object sender, EventArgs e)
        {
            frm_emp_type emp_type_frm = new frm_emp_type();
            emp_type_frm.ShowDialog();
        }

        private void btn_emp_Click(object sender, EventArgs e)
        {
            frm_emp emp_frm = new frm_emp();
            emp_frm.ShowDialog();
        }

        private void btn_salary_Click(object sender, EventArgs e)
        {
            frm_salary salary_frm = new frm_salary();
            salary_frm.ShowDialog();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            frm_setting setting_frm = new frm_setting();
            setting_frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_login login_frm = new frm_login();
            login_frm.ShowDialog();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Leave leave_frm = new Leave();
            leave_frm.ShowDialog();
        }

        private void btn_attendance_Click(object sender, EventArgs e)
        {
            frm_attendance attendance_frm = new frm_attendance();
            attendance_frm.ShowDialog();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

        }

        private void btn_holiday_Click(object sender, EventArgs e)
        {
            Holidays holiday_frm = new Holidays();
            holiday_frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_admin admin_frm = new frm_admin();
            admin_frm.ShowDialog();
        }
    }
}
