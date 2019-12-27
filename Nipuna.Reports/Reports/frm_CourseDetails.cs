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
    public partial class frm_CourseDetails : Form
    {
        public frm_CourseDetails()
        {
            InitializeComponent();
        }

        private void frm_CourseDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseDetailsDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.courseDetailsDataSet.Courses);

            this.reportViewer1.RefreshReport();
        }
    }
}
