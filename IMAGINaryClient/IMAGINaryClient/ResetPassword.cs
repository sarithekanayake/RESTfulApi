using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;

namespace IMAGINaryClient
{
    public partial class ResetPassword : Form
    { 
        
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd;
        Random rnd = new Random();
        int code;
        DataSet email = new DataSet();
        string sendmail = string.Empty;
        string sqlString = string.Empty;
        bool username ,verifycode = false;


        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server=(local)\\SQLExpress;database=imaginary;Integrated Security=TRUE;MultipleActiveResultSets=TRUE";
            conn.Open();
            code = 0;
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

        private void txtCode_Leave(object sender, EventArgs e)
        {
            int dig = 0;
            bool isNum = Int32.TryParse(txtCode.Text, out dig);
            if ((isNum)&&(txtCode.Text.Length == 5))
            {
                epCode.Clear();
                verifycode = true;
            }
            else
            {
                epCode.SetError(txtCode, "Check Vefication Code!");
                verifycode = false;
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && (username))
            {
                epUserName.Clear();
                try
                {
                    SqlDataReader email = null;
                    sqlString = "Select EMP_Email from employees where EMP_UserName = " + txtUserName.Text + " ";
                    cmd = new SqlCommand(sqlString, conn);
                    email = cmd.ExecuteReader();
                    if (email.Read())
                    {
                        sendmail = email.GetString(0);
                        code = rnd.Next(11111, 99999);

                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("imaginaryincapi@gmail.com");
                        mail.To.Add(sendmail);
                        mail.Subject = "Verification Code";
                        mail.Body = "Verification Code : " + code;

                        SmtpServer.Port = 587;
                        SmtpServer.UseDefaultCredentials = true;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("imaginaryincapi@gmail.com", "imaginary123");
                        SmtpServer.EnableSsl = true;
                        SmtpServer.Send(mail);

                        MessageBox.Show("Check Your Email for Verification Code!");
                    }
                    else
                    {
                        MessageBox.Show("Check Your User Name and try again!");
                    }
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                epUserName.SetError(txtUserName, "Enter User Name!");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && (username) && (verifycode) && (code !=0))
            {
                try
                {
                    epUserName.Clear();
                    if (txtNewPass.Text == txtRePass.Text)
                    {
                        sqlString = "Update employees set EMP_Password = '" + txtNewPass.Text + "' where EMP_UserName = " + txtUserName.Text;
                        cmd = new SqlCommand(sqlString, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Password Updated!");
                        txtUserName.Clear();
                        txtCode.Clear();
                        txtNewPass.Clear();
                        txtRePass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Password Mismatch!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                epUserName.SetError(txtUserName, "Enter User Name\nGenerate new  verification code");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtCode.Clear();
            txtNewPass.Clear();
            txtRePass.Clear();
        }
    }
}
