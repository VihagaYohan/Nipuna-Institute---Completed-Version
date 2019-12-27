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
    public partial class frm_PaymentsByDate : Form
    {
        public frm_PaymentsByDate()
        {
            InitializeComponent();
        }

        private void frm_Sample_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentDataSet.Payments' table. You can move, or remove it, as needed.
            //this.paymentsTableAdapter.Fill(this.paymentDataSet.Payments);
            // TODO: This line of code loads data into the 'paymentDataSet.Payments' table. You can move, or remove it, as needed.
            //this.paymentsTableAdapter.Fill(this.paymentDataSet.Payments);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            var From = Convert.ToDateTime(date_From.Text);
            var To = Convert.ToDateTime(date_To.Text);

            this.paymentsTableAdapter.Fill(this.paymentsByDateDataSet.Payments, From, To);
            this.reportViewer1.RefreshReport();
        }
    }
}
