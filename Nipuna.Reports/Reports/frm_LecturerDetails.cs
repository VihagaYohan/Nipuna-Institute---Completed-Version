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
    public partial class frm_LecturerDetails : Form
    {
        public frm_LecturerDetails()
        {
            InitializeComponent();
        }

        private void frm_LecturerDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lectuerDetailsDataSet.Lecturers' table. You can move, or remove it, as needed.
            this.lecturersTableAdapter.Fill(this.lectuerDetailsDataSet.Lecturers);

            this.reportViewer1.RefreshReport();
        }
    }
}
