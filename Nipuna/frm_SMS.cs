using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Nipuna
{
    public partial class frm_SMS : Form
    {
        public frm_SMS()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = new SerialPort();
                sp.PortName = txtPort.Text; // modem port no.
                sp.Open(); // open port
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGF=1"+Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CSCS=\"GSM\""+Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS=\"" + txtNumber.Text + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine(txtMessage.Text + Environment.NewLine);
                Thread.Sleep(100);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);
                var response = sp.ReadExisting();
                if (response.Contains("Error"))
                    MessageBox.Show("Send failed !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    MessageBox.Show("SMS sent !","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                sp.Close(); // close port
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed : "+ ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
