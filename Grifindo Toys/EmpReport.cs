using Grifindo_Toys.CommonClasses;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grifindo_Toys
{
    public partial class EmpReport : Form
    {
        filloperation fill  = new filloperation();
        dbconnection con = new dbconnection();

        int emp_id;
        string startDate;
        string endDate;

        public EmpReport()
        {
            InitializeComponent();
        }

        private void EmpReport_Load(object sender, EventArgs e)
        {
            fill.combobox("SELECT * FROM tbl_employee", cmb_empid, "full_name", "emp_id");   
            cmb_empid.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void loadAtStart()
        {
            SqlCommand cmd = new SqlCommand("select * from tbl_salary where emp_id = '" + emp_id + "'", con.mycon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.Refresh();
        }

        private void cmb_empid_SelectedIndexChanged(object sender, EventArgs e)
        {
            emp_id = cmb_empid.SelectedIndex;


        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            loadAtStart();
        }
    }
}
