using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nipuna.Login
{
    public partial class frm_Splash : Form
    {
        int move = 2;
        public frm_Splash()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            panelSlide.Width += 2;

            if (panelSlide.Width > 250)
            {
                panelSlide.Width = 0;
            }
            if (panelSlide.Width <0) 
            {
               move = 2;
            }
        }

        private void frm_Splash_Load(object sender, EventArgs e)
        {
            timerLoading.Start(); // start timer
        }
    }
}
