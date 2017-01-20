using System;
using System.Windows.Forms;
using System.Linq;
using System.Net.Mail;

namespace CTLogistics
{
    public partial class ClientsLogin : Form
    {
        SmtpClient mailClient = new SmtpClient("smtp.gmail.com");
        public ClientsLogin()
        {
            InitializeComponent();
            Password.PasswordChar = '*'; // To Hide Password while typing
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btRegister_Click(object sender, EventArgs e)
        {
            Registration display = new Registration();
            display.Show();
            this.Hide();
        }
        private void SendEmail(string emailBody)  
        {
            string tbEmail = Convert.ToString(Password.Text);
            MailMessage mailMessage = new MailMessage("mbukuthierry@gmail.com", tbEmail); //1) From 2) to Email in Password Textbox
            mailMessage.Subject = "Forgot Password";
            mailMessage.Body = emailBody;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Send(mailMessage);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Converting string to int
            string userid = IDNumber.Text;
            int useridToint = Convert.ToInt32(userid);

            string passw = Password.Text;
            using (var db = new CTLogisticsEntities())
            {
                // verified userid and password
                var existinguser = db.Clients.FirstOrDefault(x => x.IDNumber == useridToint && x.Password == passw);
                // verified userid and Email address
                var forgetpassword = db.Clients.FirstOrDefault(x => x.IDNumber == useridToint && x.EmailAddress == passw);

                if (existinguser != null)
                {
                    LoggedInPage display = new LoggedInPage(existinguser);
                    display.Show();
                    this.Hide();
                }
                else
                {
                    this.Focus();
                    MessageBox.Show("Wrong Credentials");
                }
                if (existinguser == null && forgetpassword != null)
                {
                    string forgettenpassword = forgetpassword.Password;
                    SendEmail("Your Password is: " + forgettenpassword);
                    MessageBox.Show("Email Sent, Thank you");
                }
            }
        }
    }
  }

