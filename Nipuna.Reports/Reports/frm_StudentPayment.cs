﻿using System;
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
    public partial class frm_StudentPayment : Form
    {
        public frm_StudentPayment()
        {
            InitializeComponent();
        }

        private void frm_StudentPayment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'paymentDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.paymentDataSet.Payments);
            // TODO: This line of code loads data into the 'paymentDataSet.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.paymentDataSet.Payments);

            this.reportViewer1.RefreshReport();
        }
    }
}
