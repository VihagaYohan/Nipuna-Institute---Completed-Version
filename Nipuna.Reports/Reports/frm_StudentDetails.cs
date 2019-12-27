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
    public partial class frm_StudentDetails : Form
    {
        public frm_StudentDetails()
        {
            InitializeComponent();
        }

        private void frm_StatudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDetailsDataSet.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.studentDetailsDataSet.Students);

            this.reportViewer1.RefreshReport();
        }
    }
}
