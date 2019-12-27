using Nipuna.DataAccess;
using Nipuna.Main;
using Nipuna.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SplashScreen;

namespace Nipuna
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            InitializeComponent();

            // loading data
            string str = string.Empty;
            for (int i = 0; i < 100000; i++) 
            {
                str += i.ToString(); // Init data
            }
            // complete
            t.Abort();
        }

        void Splash()
        {
            //SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            //frm.AppName = "Nipuna Institute";
            //Application.Run(frm);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter login credentials", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    var user = new User();
                    user.UserName = txtUsername.Text;
                    user.Password = txtPassword.Text;

                    var record = UserDataAccess.findByUserId(user);

                    if (record == null)
                    {
                        MessageBox.Show("User-ID not found.Please enter login credentials", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        // check if user profile is inactive
                        if (record.IsRemoved == true)
                        {
                            MessageBox.Show("Inactive user profile", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                        else
                        {
                            // check for the password
                            if (record.Password == txtPassword.Text)
                            {
                                // show home form
                                var role = record.Role;
                                var userName = record.UserName;

                                var main = new frm_Main(userName, role);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password.Please enter login credentials", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            // close application
            Application.Exit();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // close application
            Application.Exit();
        }
    }
}
