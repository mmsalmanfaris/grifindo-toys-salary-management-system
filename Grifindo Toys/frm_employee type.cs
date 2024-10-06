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
    public partial class frm_emp_type : Form
    {   
        cls_employeetype clsemptype = new cls_employeetype();
        filloperation fill = new filloperation();

        public frm_emp_type()
        {
            InitializeComponent();
        }

        void firstRun()
        {
            txt_emp_type.Text = "";
            txt_overtime.Text = "0.00";
            txt_annualleave.Text = "00";

            fill.FillDataGridView("SELECT * FROM tbl_employeetype", dgv_emp_type);
            dgv_emp_type.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv_emp_type.Columns[0].HeaderText = "ID";
            dgv_emp_type.Columns[1].HeaderText = "Employee Type";
            dgv_emp_type.Columns[2].HeaderText = "Over Time Rate";
            dgv_emp_type.Columns[3].HeaderText = "Annual Leave";
        }

        private void dgv_emp_type_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsemptype.emptype_id = Convert.ToInt32(dgv_emp_type.Rows[e.RowIndex].Cells[0].Value);
            clsemptype.Getdata();
            txt_emp_type.Text = clsemptype.emptype.ToString();
            txt_overtime.Text = clsemptype.Overtimerate.ToString();
            txt_annualleave.Text = clsemptype.Annualleaves.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_emp_type_Load(object sender, EventArgs e)
        {
            firstRun();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            firstRun();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btn_save_Click(object sender, EventArgs e)
        {
            clsemptype.Inserdata();
            firstRun();
            txt_emp_type.Focus();
        }
        void myFillGridDetail()
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            clsemptype.UpdateData();
            firstRun();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clsemptype.DeleteDate();
            firstRun();
        }

        private void txt_emp_type_TextChanged(object sender, EventArgs e)
        {
            clsemptype.emptype = txt_emp_type.Text;
        }

        private void txt_overtime_TextChanged(object sender, EventArgs e)
        {
            clsemptype.Overtimerate = Convert.ToDecimal(txt_overtime.Text);
        }

        private void txt_annualleave_TextChanged(object sender, EventArgs e)
        {
            clsemptype.Annualleaves = Convert.ToInt32(txt_annualleave.Text);
        }

        private void txt_overtime_Click(object sender, EventArgs e)
        {
            txt_overtime.SelectAll();
        }

        private void txt_annualleave_Click(object sender, EventArgs e)
        {
            txt_annualleave.SelectAll();
        }
    }   
}
