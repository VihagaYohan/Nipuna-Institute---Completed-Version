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
    public partial class frm_LecturerEnrollment : Form
    {
        public frm_LecturerEnrollment()
        {
            InitializeComponent();
        }

        private void frm_LecturerEnrollment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lecturerCourseEnrollmentDataSet.LecturerCourses' table. You can move, or remove it, as needed.
            this.lecturerCoursesTableAdapter.Fill(this.lecturerCourseEnrollmentDataSet.LecturerCourses);

            this.reportViewer1.RefreshReport();
        }
    }
}
