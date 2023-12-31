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
    public partial class frm_setting : Form
    {
        cls_setting clssetting = new cls_setting();
        filloperation fill = new filloperation();

        public frm_setting()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            clssetting.Insertdata();
            FirstRun();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            FirstRun();
        }

        void FirstRun()
        {
            txt_gov_tax.Text = "0";
            dtp_salary_begin.Value = DateTime.Now;
            dtp_salary_end.Value = DateTime.Now;
            lbl_range.Text = "";

            fill.FillDataGridView("SELECT * FROM tbl_setting", dgv_salary_setting);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            FirstRun();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            clssetting.UpdateData();
            FirstRun();
        }

        private void dgv_salary_setting_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clssetting.seting_id = Convert.ToInt32(dgv_salary_setting.Rows[e.RowIndex].Cells[0].Value);
            clssetting.FillEmployeTypeToField();
            txt_gov_tax.Text = clssetting.gov_tax.ToString();
            dtp_salary_begin.Text = clssetting.begindate.ToString();
            dtp_salary_end.Text = clssetting.endDate.ToString();
            lbl_range.Text = clssetting.range;
        }

        private void dgv_salary_setting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clssetting.DeleteData();
            FirstRun();
        }

        private void txt_gov_tax_TextChanged(object sender, EventArgs e)
        {
            clssetting.gov_tax = (int)Convert.ToDecimal(txt_gov_tax.Text);
        }

        private void dtp_salary_begin_ValueChanged(object sender, EventArgs e)
        {
            clssetting.begindate = dtp_salary_begin.Value.ToString();

            lbl_range_Click(sender, e);
        }

        private void dtp_salary_end_ValueChanged(object sender, EventArgs e)
        {
            clssetting.endDate = dtp_salary_begin.Value.ToString();

            lbl_range_Click(sender, e);
        }

        void lbl_range_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtp_salary_begin.Value;
            DateTime endDate = dtp_salary_end.Value;

            TimeSpan difference = (startDate <= endDate) ? endDate - startDate : TimeSpan.Zero;
            int daysDifference = difference.Days;

            lbl_range.Text = daysDifference.ToString();

            clssetting.range = lbl_range.Text;
        }


        private void txt_gov_tax_Click(object sender, EventArgs e)
        {
            txt_gov_tax.SelectAll();
        }
    }
}
