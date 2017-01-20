using System;
using System.Windows.Forms;
using CTLogistics.Properties;
using System.Linq;

namespace CTLogistics
{
    public partial class ClientsLogin : Form 
    {
        public ClientsLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string userid = IDNumber.Text;
            string passw = Password.Text;

            using (var db = new CTLogisticsEntities())
            {
                // verify userid and passord
               var existinguserid = db.Clients.FirstOrDefault(x => x.IDNumber == Convert.ToInt32(userid));
               var existinguserpassw = db.Clients.FirstOrDefault(x => x.Password == passw);

                if (existinguserid !=null)
                {
                    LoggedInPage display = new LoggedInPage();
                    display.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Pease enter correct credentials!");
                }
                
            }

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
    }
}
