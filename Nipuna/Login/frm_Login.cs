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
using Nipuna.Model;
using Nipuna.DataAccess;
using Nipuna.Main;
using Nipuna.Login;


namespace Nipuna.Main
{
    public partial class frm_Login : MaterialSkin.Controls.MaterialForm
    {
        public frm_Login()
        {
            //// splash screen
            //var t = new Thread(new ThreadStart(Splash));

            Thread thread = new Thread(new ThreadStart(formRun));
            thread.Start();
            Thread.Sleep(5000);

            InitializeComponent();

            thread.Abort();

            // Loading data
            //string str = string.Empty;
            //for (int i = 0; i < 100000; i++) 
            //{
            //    str += i.ToString(); //Init data
            //}

            //// complete
            //t.Abort(); 
        }

        private void formRun() 
        {
            Application.Run(new frm_Splash());
        }

        //public void Splash() 
        //{
        //    SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
        //    frm.AppName = "Nipuna Institute";
        //    Application.Run(frm);
        //}

        private void frm_Login_Load(object sender, EventArgs e)
        {
            // material skin
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
