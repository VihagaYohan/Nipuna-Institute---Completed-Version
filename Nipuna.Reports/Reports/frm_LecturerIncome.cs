using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nipuna.Reports.Reports
{
    public partial class frm_LecturerIncome : Form
    {
        public frm_LecturerIncome()
        {
            InitializeComponent();
        }

        private void frm_LecturerIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lecturerPaymentDataSet.Payments' table. You can move, or remove it, as needed.
            //this.paymentsTableAdapter.Fill(this.lecturerPaymentDataSet.Payments);
            // TODO: This line of code loads data into the 'lecturerIncomeDataSet.Payments' table. You can move, or remove it, as needed.
            //this.paymentsTableAdapter.Fill(this.lecturerIncomeDataSet.Payments);
            // TODO: This line of code loads data into the 'incomeDataSet.Payments' table. You can move, or remove it, as needed.
            //this.paymentsTableAdapter.Fill(this.incomeDataSet.Payments);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            //this.attendancesTableAdapter.Fill(this.attendanceRecord.Attendances, date_From.Text, date_To.Text);
            
            this.reportViewer1.RefreshReport();
        }
    }
}
