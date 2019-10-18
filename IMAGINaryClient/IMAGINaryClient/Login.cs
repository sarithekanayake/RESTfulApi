using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMAGINaryClient
{
    public partial class Login : Form
    {
        Thread manager;
        Thread developer;
        int empid = 0;
        SqlConnection conn = new SqlConnection();
        bool username = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server=(local)\\SQLExpress;database=imaginary;Integrated Security=TRUE;MultipleActiveResultSets=TRUE";
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtUserName.Text, out dig);
            if ((isNum) && (txtUserName.Text.Length == 9))
            {
                epUserName.Clear();
                username = true;
            }
            else
            {
                epUserName.SetError(txtUserName, "Check User Name!");
                username = false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (username && !(string.IsNullOrEmpty(txtUserName.Text)))
            {
                epUserName.Clear();
                try
                {
                    conn.Open();
                    string sql = "Select EMP_ID,EMP_Password,Privilage_Level from employees where EMP_UserName = " + txtUserName.Text;
                    SqlCommand cmd = new SqlCommand(sql,conn);
                    SqlDataReader empReader = cmd.ExecuteReader();
                    if (empReader.Read())
                    {
                        empid = empReader.GetInt32(0);
                        if (empReader.GetString(1) == txtPass.Text)
                        {
                            if (empReader.GetInt32(2) == 500)
                            {
                                this.Close();
                                developer = new Thread(OpenDeveloper);
                                developer.SetApartmentState(ApartmentState.STA);
                                developer.Start();
                            }
                            else if (empReader.GetInt32(2) == 1000)
                            {
                                this.Close();
                                manager = new Thread(OpenManager);
                                manager.SetApartmentState(ApartmentState.STA);
                                manager.Start();
                            }
                            else
                            {
                                MessageBox.Show("Not authenticated User!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Check username and password!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Check username and password!");
                    }
                }
                catch (Exception Login)
                {
                    MessageBox.Show(Login.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                epPassword.SetError(txtUserName, "Check Password!");
            }
        }

        private void OpenManager(Object obj)
        {
            Application.Run(new ManagerUI(empid));
        }
        private void OpenDeveloper(Object obj)
        {
            Application.Run(new DeveloperUI(empid));
        }

        private void lblForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetpass = new ResetPassword();
            resetpass.Show();
        }
    }
}
