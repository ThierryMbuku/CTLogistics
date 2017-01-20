using System;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static CTLogistics.Enums;

namespace CTLogistics
{
    public partial class LoggedInPage : Form
    {
        private Client existinguser;
        private int quantity;
        public LoggedInPage(Client existinguser)
        {
            InitializeComponent();

            this.existinguser = existinguser;

            lbSubTotal.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }
        private void btLogout_Click(object sender, EventArgs e)
        {
            ClientsLogin display = new ClientsLogin();
            display.Show();
            this.Hide();
        }
        public void PopulateUserData(int userid)
        {
            using (var db = new CTLogisticsEntities())
            {
                var query = db.Clients.FirstOrDefault(x => x.Id == userid);
                try
                {
                    if (query == null)
                    {
                        MessageBox.Show("Error while retrieving data");
                    }
                    else
                    {
                        tbFirstNames.Text = query.FirstName;
                        tbLastName.Text = query.LastName;
                        tbIdNumber.Text = Convert.ToString(query.IDNumber);
                        timePickerDOB.Text = Convert.ToString(query.DatOfBirth);
                        tbCellPhone.Text = Convert.ToString(query.CellPhone);
                        tbEmailAddress.Text = query.EmailAddress;
                        tbPostAddress.Text = query.PostalAddress;
                        tbPassword.Text = query.Password;
                        cmbCUserRoles.Text = Convert.ToString(query.UserRole.Description);
                    }
                }
                catch (DbEntityValidationException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private void LoggedInPage_Load_1(object sender, EventArgs e)
        {
            PopulateProductData();
            PopulateUserData(existinguser.Id);
        }

        private void PopulateProductData()
        {
            this.productsTableAdapter1.Fill(this.cTLogisticsDataSet1.Products);
        }

        // Update User data
        private void btUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new CTLogisticsEntities())
            {
                var query = db.Clients.FirstOrDefault(x => x.Id == existinguser.Id);

                if (query != null)
                {
                    query.FirstName = tbFirstNames.Text;
                    query.LastName = tbLastName.Text;
                    query.IDNumber = Convert.ToInt32(tbIdNumber.Text);
                    query.DatOfBirth = Convert.ToDateTime(timePickerDOB.Text);
                    query.EmailAddress = tbEmailAddress.Text;
                    query.PostalAddress = tbPostAddress.Text;
                    query.UserRole.Description = cmbCUserRoles.Text;
                    query.CellPhone = Convert.ToInt32(tbCellPhone.Text);
                    query.Password = tbPassword.Text;
                    query.Comments = tbCommentPersoInfo.Text;

                    try
                    {
                        db.SaveChanges();
                        MessageBox.Show("Data successfully updated!");
                    }
                    catch (DbEntityValidationException ex)
                    {
                        Console.WriteLine(ex.EntityValidationErrors);
                    }
                }
                else
                {
                    MessageBox.Show("Error while updating the user, Please try again");
                }
            }
        }
        // Cancel Order
        private void btCancelProducts_Click(object sender, EventArgs e)
        {
            LoggedInPage display = new LoggedInPage(existinguser);
            display.Show();
            this.Hide();
        }
        // Submit Order
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (var db = new CTLogisticsEntities())
            {
                try
                {
                    int totalrows = dgInvoice.Rows.Count;
                    string total = label20.Text.Replace("R", "");

                    var item = new OrderHistory();
                    var order = new Order
                    {
                        OrderNumber = 1234567,
                        InvoiceNumber = 099909,
                        Total = Convert.ToDecimal(total)
                    };

                    db.Orders.Add(order);
                    db.SaveChanges();

                    foreach (DataGridViewRow row in dgInvoice.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[5].Value) == true)
                        {
                            item.ProductId = Convert.ToInt32(row.Cells[0].Value);
                            item.OrderId = order.Id;
                            item.Quantity = Convert.ToInt32(row.Cells[2].Value);
                            item.UnitPrice = Convert.ToDecimal(row.Cells[3].Value);
                            item.Id = existinguser.Id;
                            item.Amount = Convert.ToDecimal(row.Cells[4].Value);
                            db.OrderHistories.Add(item);
                        }
                    }

                    db.SaveChanges();
                    MessageBox.Show("Order submitted!");

                }
                catch (DbEntityValidationException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        private void dgInvoice_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var cellValue = dgInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            quantity = (cellValue == null || cellValue == "") ? 0 : Convert.ToInt32(cellValue);
        }

        private void dgInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal total = 0;
            double tot = 0;
            double vat = 0.14;
            decimal subtotal = 0;
            decimal sustracttotal = 0;
            decimal Calvat = 0;
            bool isClient = false;

            isClient = existinguser.UserRoleId == (int)UserRoles.Client;

            foreach (DataGridViewRow rows in dgInvoice.Rows)
            {
                tot = 0;

                bool checkbox = Convert.ToBoolean(rows.Cells[e.ColumnIndex].EditedFormattedValue);
                if (checkbox == true)
                {
                    tot = Convert.ToDouble(rows.Cells[4].Value);
                    subtotal += Convert.ToDecimal(tot, CultureInfo.CurrentCulture);
                    label18.Text = subtotal.ToString("C0");
                    label18.Visible = true;

                    // VAT (14 % if Client)
                    using (var db = new CTLogisticsEntities())
                    {
                        if (isClient)
                        {
                            Calvat = ((subtotal * Convert.ToDecimal(vat, CultureInfo.CurrentCulture)));
                            label19.Text = Calvat.ToString("C0");
                        }
                        else
                        {
                            label19.Text = "Not Applicable";
                        }
                        label19.Visible = true;
                    }
                    //TOTAL is equal to subtoal if Government.Else Amount x 14 %
                    using (var db = new CTLogisticsEntities())
                    {
                        if (isClient)
                        {
                            total = Convert.ToDecimal((subtotal + Calvat), CultureInfo.CurrentCulture);
                            label20.Text = total.ToString("C0");
                        }
                        else
                        {
                            total = Convert.ToDecimal(subtotal, CultureInfo.CurrentCulture);
                            label20.Text = total.ToString("C0");
                        }
                        label20.Visible = true;
                    }
                }
                else
                {
                    // sub
                    sustracttotal = subtotal - Convert.ToDecimal(tot, CultureInfo.CurrentCulture);
                    label18.Text = sustracttotal.ToString("C0");
                    // vat
                    if (isClient)
                    {
                        Calvat = (subtotal * Convert.ToDecimal(vat, CultureInfo.CurrentCulture));
                        label19.Text = Calvat.ToString("C0");
                    }
                    else
                    {
                        label19.Text = "Not Applicable";
                    }
                    // total
                    if (isClient)
                    {
                        total = Convert.ToDecimal((subtotal + Calvat), CultureInfo.CurrentCulture); ;
                        label20.Text = total.ToString("C0");
                    }
                    else
                    {
                        total = Convert.ToDecimal(subtotal);
                        label20.Text = total.ToString("C0");
                    }
                }
            }
        }

        private void dgInvoice_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            decimal amt = 0;
            int quantity = 0;
            decimal unitprice = 0;
            bool isClient = false;

            isClient = existinguser.UserRoleId == (int)UserRoles.Client;

            if (e.ColumnIndex == 2)
            {
                var cellValue = dgInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var quantityB = (cellValue == null || cellValue == "") ? 0 : Convert.ToInt32(cellValue);

                if (quantity == quantityB)
                {
                    return;
                }
                else
                {
                    foreach (DataGridViewRow rows in dgInvoice.Rows)
                    {
                        quantity = ((rows.Cells[2].Value == null) || (rows.Cells[2].Value == "")) ? 0 : Convert.ToInt32(rows.Cells[2].Value);
                        unitprice = Convert.ToDecimal(rows.Cells[3].Value);

                        amt = quantity * unitprice;
                        rows.Cells[4].Value = amt;
                    }
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                productsTableAdapter.Fill(cTLogisticsDataSet.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter1.Fill(this.cTLogisticsDataSet1.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}

