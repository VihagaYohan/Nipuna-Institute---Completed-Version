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
    public partial class frm_Users : Form
    {
        public frm_Users()
        {
            InitializeComponent();
        }

        private void frm_Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'usersDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.usersDataSet.Users);

            this.reportViewer1.RefreshReport();
        }
    }
}
