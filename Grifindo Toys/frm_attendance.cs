using Grifindo_Toys.AppClasses;
using Grifindo_Toys.CommonClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class frm_attendance : Form
    {
        filloperation fill = new filloperation();
        cls_attrndance clsattendace = new cls_attrndance();

        public frm_attendance()
        {
            InitializeComponent();
        }

        private void attendance_Load(object sender, EventArgs e)
        {
            fill.combobox("SELECT * FROM tbl_employee", cmb_empid, "full_name", "emp_id");
            firstrun();
        }

        void firstrun()
        {
            cmb_empid.SelectedIndex = 0;
            dtp_date.Value = DateTime.Now;
            dtp_intime.Value = DateTime.Now;
            dtp_outime.Value = DateTime.Now;
            lbl_totalminutes.Text = "";

            fill.FillDataGridView("SELECT * FROM tbl_attendance", dgv_attendance);
            dgv_attendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_attendance.Columns[0].HeaderText = "ID";
            dgv_attendance.Columns[1].HeaderText = "Emp ID";
            dgv_attendance.Columns[2].HeaderText = "Date";
            dgv_attendance.Columns[3].HeaderText = "In Time";
            dgv_attendance.Columns[4].HeaderText = "Out Time";
            dgv_attendance.Columns[5].HeaderText = "Total Min";


        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }
        void GridDetail()
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv_attendance_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsattendace.attendanceid = Convert.ToInt32(dgv_attendance.Rows[e.RowIndex].Cells[0].Value);
            clsattendace.Getdata();
            cmb_empid.Text = clsattendace.empid.ToString();
            dtp_date.Text = clsattendace.date.ToShortDateString();
            dtp_intime.Text = clsattendace.intime.ToShortDateString();
            dtp_outime.Text = clsattendace.outime.ToShortDateString();
            lbl_totalminutes.Text = clsattendace.minutes.ToString();
        }

        private void cmb_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsattendace.empid = Convert.ToInt32(cmb_empid.SelectedValue);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            clsattendace.Insertdata();
            firstrun();
        }

        private void lbl_totalhours_Click(object sender, EventArgs e)
        {
            DateTime intime = dtp_intime.Value;
            DateTime outtime = dtp_outime.Value;

            TimeSpan difference = (outtime >= intime) ? outtime - intime : TimeSpan.Zero;

            int totalMinutes = (int)difference.TotalMinutes;

            lbl_totalminutes.Text = $"{difference.Hours} hours, {difference.Minutes} minutes";

            clsattendace.minutes = totalMinutes;
        }

        private void dtp_intime_ValueChanged(object sender, EventArgs e)
        {
            dtp_intime.Format = DateTimePickerFormat.Time;
            dtp_intime.ShowUpDown = true;
            clsattendace.intime = dtp_intime.Value;

            lbl_totalhours_Click(sender, e);
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            clsattendace.date = dtp_date.Value.Date;
        }

        
        private void dtp_outime_ValueChanged(object sender, EventArgs e)
        {
            dtp_outime.Format = DateTimePickerFormat.Time;
            dtp_outime.ShowUpDown = true;
            clsattendace.outime = dtp_outime.Value;

            lbl_totalhours_Click(sender, e);
        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            firstrun();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            clsattendace.UpdateData();
            firstrun();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            clsattendace.DeleteData();
            firstrun();
        }
    }
}
