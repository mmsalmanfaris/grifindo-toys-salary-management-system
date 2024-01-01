using Grifindo_Toys.AppClasses;
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
    public partial class Holidays : Form
    {
        cls_holiday clsholiday = new cls_holiday();
        filloperation fill = new filloperation();

        public Holidays()
        {
            InitializeComponent();
        }

        void firstrun()
        {
            txt_name.Text = string.Empty;
            dtp_date.Value = DateTime.Now;

            fill.FillDataGridView("SELECT * FROM tbl_holidays", dgv_holiday);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            clsholiday.UpdateData();
            firstrun();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            clsholiday.Insertdata();
            firstrun();
        }

        private void Holidays_Load(object sender, EventArgs e)
        {
            firstrun();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            clsholiday.DeleteData();
            firstrun();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            clsholiday.name= txt_name.Text;
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            clsholiday.date = dtp_date.Value.ToString();
        }
    }
}
