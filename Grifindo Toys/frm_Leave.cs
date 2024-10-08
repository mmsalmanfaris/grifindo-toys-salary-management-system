﻿using Grifindo_Toys.AppClasses;
using Grifindo_Toys.CommonClasses;
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
    public partial class Leave : Form
    {
        cls_leave clsleave = new cls_leave();
        filloperation fill = new filloperation();

        public Leave()
        {
            InitializeComponent();
        }


       


        private void label7_Click(object sender, EventArgs e)
        {

        }

        void FirstRun()
        {
            cmb_empid.SelectedIndex = 0;
            dtp_leave_start.Value = DateTime.Now;
            dtp_leave_end.Value = DateTime.Now;
            lbl_total_days.Text = "0";
            txt_reason.Text = "";

            fill.FillDataGridView("SELECT * FROM tbl_leave", dgv_leave);
            dgv_leave.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_leave.Columns[0].HeaderText = "ID";
            dgv_leave.Columns[1].HeaderText = "Emp ID";
            dgv_leave.Columns[2].HeaderText = "Start Date";
            dgv_leave.Columns[3].HeaderText = "End Date";
            dgv_leave.Columns[4].HeaderText = "Days";
            dgv_leave.Columns[5].HeaderText = "Reason";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            clsleave.Insertdata();
            FirstRun();
        }

        private void Leave_Load(object sender, EventArgs e)
        {
            fill.combobox("SELECT * FROM tbl_employee", cmb_empid, "full_name", "emp_id");
            FirstRun();
        }

        private void dgv_leave_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsleave.emp_id = Convert.ToInt32(cmb_empid.SelectedValue.ToString());
            getavailableleave();
            
        }

        private void dtp_leave_start_ValueChanged(object sender, EventArgs e)
        {
            clsleave.start = dtp_leave_start.Value.ToString();

            lbl_total_days_Click(sender, e);
        }

        private void dtp_leave_end_ValueChanged(object sender, EventArgs e)
        {
            clsleave.end = dtp_leave_end.Value.ToString();

            lbl_total_days_Click(sender, e);
        }

        private void lbl_total_days_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtp_leave_start.Value;
            DateTime endDate = dtp_leave_end.Value;

            TimeSpan difference = (startDate <= endDate) ? endDate - startDate : TimeSpan.Zero;
            int daysDifference = difference.Days + 1;

            lbl_total_days.Text = daysDifference.ToString();

            clsleave.days = lbl_total_days.Text;
        }

        public void getavailableleave()
        {
            lbl_available_leaves.Text = Convert.ToString((int)fill.total_leaves(clsleave.emp_id) - (int)fill.Completed_leaves(clsleave.emp_id));
        }

        private void txt_reason_TextChanged(object sender, EventArgs e)
        {
            clsleave.reason = txt_reason.Text;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            FirstRun();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            clsleave.UpdateData();
            FirstRun();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clsleave.DeleteData();
            FirstRun();
        }

        private void dgv_leave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsleave.leaveid = Convert.ToInt32(dgv_leave.Rows[e.RowIndex].Cells[0].Value);
            clsleave.Getdata();
            cmb_empid.Text = clsleave.emp_id.ToString();
            dtp_leave_start.Text = clsleave.start;
            dtp_leave_end.Text = clsleave.end;
            lbl_total_days.Text = clsleave.days;
            txt_reason.Text = clsleave.reason;
        }

        private void lbl_available_leaves_Click(object sender, EventArgs e)
        {
        }
    }
}
