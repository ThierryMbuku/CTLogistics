using System;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace CTLogistics
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void btSubmit_Click(object sender, EventArgs e)
        {
            // Add info to database
            using (var db = new CTLogisticsEntities())
            {
                try
                {
                    var client = new Client
                    {
                        FirstName = tbFirstNames.Text,
                        LastName = tbLastName.Text,
                        IDNumber = Convert.ToInt32(tbIdNumber.Text),
                        DatOfBirth = Convert.ToDateTime(timePickerDOB.Text),
                        EmailAddress = tbEmailAddress.Text,
                        PostalAddress = tbPostAddress.Text,
                        CellPhone = Convert.ToInt32(tbCellPhone.Text),
                        Password = tbPassword.Text,
                        Comments = tbCommentPersoInfo.Text,
                        UserRoleId = Convert.ToInt32(cmbCUserRoles.SelectedIndex)
                    };
                    db.Clients.Add(client);
                    db.SaveChanges();
                    MessageBox.Show("User succesfully created!");
                }
                catch (DbEntityValidationException ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                tbPostAddress.Clear();
                tbFirstNames.Clear();
                tbCellPhone.Clear();
                tbEmailAddress.Clear();
                tbIdNumber.Clear();
                tbFirstName.Clear();
                tbLastName.Clear();
                cmbCUserRoles.ResetText();
                cmbTitle.ResetText();
                timePickerDOB.ResetText();
                tbPassword.Clear();
                tbCommentPersoInfo.Clear();

                ClientsLogin ss = new ClientsLogin();
                ss.Show();
                this.Hide();
            }
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            // Cancel Registration
            ClientsLogin display = new ClientsLogin();
            display.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            cmbTitle.SelectedIndex = 0;
            cmbCUserRoles.SelectedIndex = 0;
        }
    }
}

