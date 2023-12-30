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
            txt_overtime.Text = "";
            txt_annualleave.Text = "";

            fill.FillDataGridView("SELECT * FROM tbl_employeetype", dgv_emp_type);
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

        private void dgv_emp_type_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsemptype.emptype_id = Convert.ToInt32(dgv_emp_type.Rows[e.RowIndex].Cells[0].Value);
            clsemptype.FillEmployeTypeToField();
            txt_emp_type.Text = clsemptype.emptype;
            txt_overtime.Text = clsemptype.Overtimerate.ToString();
            txt_annualleave.Text = clsemptype.Annualleaves;
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
            if (int.TryParse(txt_overtime.Text, out int overtime))
            {
                clsemptype.Overtimerate = overtime;
            }
            else
            {
                clsemptype.Overtimerate = 0;
            }
        }

        private void txt_annualleave_TextChanged(object sender, EventArgs e)
        {
            clsemptype.Annualleaves = txt_annualleave.Text.Trim();
        }
    }   
}
