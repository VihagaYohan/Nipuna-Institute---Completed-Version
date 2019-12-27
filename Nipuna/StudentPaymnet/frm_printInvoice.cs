using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nipuna.Model;

namespace Nipuna.StudentPaymnet
{
    public partial class frm_printInvoice : Form
    {
        public frm_printInvoice()
        {
            InitializeComponent();

            
        }

        public frm_printInvoice(Payment payment)
        {
            InitializeComponent();
            PaymentBindingSource.DataSource = payment;
            //paymentsBindingSource.DataSource = payment;
            this.viewer_Invoice.RefreshReport();
        }

        private void frm_printInvoice_Load(object sender, EventArgs e)
        {

            this.viewer_Invoice.RefreshReport();

        }

        private void frm_printInvoice_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbInvoice1.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter1.Fill(this.dbInvoice1.Payments);

            this.viewer_Invoice.RefreshReport();
        }
    }
}
