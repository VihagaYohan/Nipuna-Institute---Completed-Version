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
    public partial class frm_LecturerDetailsFilterLecturerId : Form
    {
        public frm_LecturerDetailsFilterLecturerId()
        {
            InitializeComponent();
        }

        private void frm_LecturerDetailsFilterLecturerId_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            this.lecturersTableAdapter.Fill(this.lecturerDetailsFilterLectuerId.Lecturers, txt_LecturerId.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
