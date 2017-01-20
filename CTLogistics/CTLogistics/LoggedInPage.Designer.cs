namespace CTLogistics
{
    partial class LoggedInPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabInvoice = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbVAT = new System.Windows.Forms.Label();
            this.lbSubTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgInvoice = new System.Windows.Forms.DataGridView();
            this.btCancelProducts = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPersonalInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPostAddress = new System.Windows.Forms.TextBox();
            this.tbFirstNames = new System.Windows.Forms.TextBox();
            this.tbCommentPersoInfo = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbIdNumber = new System.Windows.Forms.TextBox();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.tbCellPhone = new System.Windows.Forms.TextBox();
            this.tbPostalAddress1 = new System.Windows.Forms.TextBox();
            this.timePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbCUserRoles = new System.Windows.Forms.ComboBox();
            this.TitleCmbBox = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
            this.Tabbss = new System.Windows.Forms.TabControl();
            this.cTLogisticsDataSet1 = new CTLogistics.CTLogisticsDataSet1();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new CTLogistics.CTLogisticsDataSet1TableAdapters.ProductsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddRemove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabInvoice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).BeginInit();
            this.tbPersonalInfo.SuspendLayout();
            this.Tabbss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTLogisticsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabInvoice
            // 
            this.tabInvoice.AutoScroll = true;
            this.tabInvoice.Controls.Add(this.label7);
            this.tabInvoice.Controls.Add(this.groupBox1);
            this.tabInvoice.Controls.Add(this.dgInvoice);
            this.tabInvoice.Controls.Add(this.btCancelProducts);
            this.tabInvoice.Controls.Add(this.button2);
            this.tabInvoice.Controls.Add(this.label2);
            this.tabInvoice.Controls.Add(this.label3);
            this.tabInvoice.Location = new System.Drawing.Point(4, 22);
            this.tabInvoice.Name = "tabInvoice";
            this.tabInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoice.Size = new System.Drawing.Size(729, 514);
            this.tabInvoice.TabIndex = 3;
            this.tabInvoice.Text = "Invoice";
            this.tabInvoice.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(391, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Vat @14%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lbVAT);
            this.groupBox1.Controls.Add(this.lbSubTotal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(371, 332);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 117);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(109, 94);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "label20";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(108, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 7;
            this.label19.Text = "label19";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(108, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "label18";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(102, 94);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 5;
            // 
            // lbVAT
            // 
            this.lbVAT.AutoSize = true;
            this.lbVAT.Location = new System.Drawing.Point(102, 60);
            this.lbVAT.Name = "lbVAT";
            this.lbVAT.Size = new System.Drawing.Size(0, 13);
            this.lbVAT.TabIndex = 4;
            // 
            // lbSubTotal
            // 
            this.lbSubTotal.AutoSize = true;
            this.lbSubTotal.Location = new System.Drawing.Point(102, 25);
            this.lbSubTotal.Name = "lbSubTotal";
            this.lbSubTotal.Size = new System.Drawing.Size(0, 13);
            this.lbSubTotal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "VAT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subtotal";
            // 
            // dgInvoice
            // 
            this.dgInvoice.AllowUserToAddRows = false;
            this.dgInvoice.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.colQuantity,
            this.unitPriceDataGridViewTextBoxColumn,
            this.colTotal,
            this.AddRemove});
            this.dgInvoice.DataSource = this.productsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgInvoice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgInvoice.Location = new System.Drawing.Point(24, 118);
            this.dgInvoice.Name = "dgInvoice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgInvoice.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgInvoice.Size = new System.Drawing.Size(643, 175);
            this.dgInvoice.TabIndex = 20;
            this.dgInvoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoice_CellContentClick);
            this.dgInvoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgInvoice_CellEndEdit_1);
            // 
            // btCancelProducts
            // 
            this.btCancelProducts.Location = new System.Drawing.Point(367, 480);
            this.btCancelProducts.Name = "btCancelProducts";
            this.btCancelProducts.Size = new System.Drawing.Size(105, 23);
            this.btCancelProducts.TabIndex = 19;
            this.btCancelProducts.Text = "Cancel Order";
            this.btCancelProducts.UseVisualStyleBackColor = true;
            this.btCancelProducts.Click += new System.EventHandler(this.btCancelProducts_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(492, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Submit Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Invoice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Please select list of products";
            // 
            // tbPersonalInfo
            // 
            this.tbPersonalInfo.Controls.Add(this.label1);
            this.tbPersonalInfo.Controls.Add(this.label17);
            this.tbPersonalInfo.Controls.Add(this.label16);
            this.tbPersonalInfo.Controls.Add(this.label15);
            this.tbPersonalInfo.Controls.Add(this.label14);
            this.tbPersonalInfo.Controls.Add(this.label13);
            this.tbPersonalInfo.Controls.Add(this.label12);
            this.tbPersonalInfo.Controls.Add(this.label11);
            this.tbPersonalInfo.Controls.Add(this.label10);
            this.tbPersonalInfo.Controls.Add(this.label9);
            this.tbPersonalInfo.Controls.Add(this.label8);
            this.tbPersonalInfo.Controls.Add(this.tbPostAddress);
            this.tbPersonalInfo.Controls.Add(this.tbFirstNames);
            this.tbPersonalInfo.Controls.Add(this.tbCommentPersoInfo);
            this.tbPersonalInfo.Controls.Add(this.tbLastName);
            this.tbPersonalInfo.Controls.Add(this.tbPassword);
            this.tbPersonalInfo.Controls.Add(this.tbFirstName);
            this.tbPersonalInfo.Controls.Add(this.tbIdNumber);
            this.tbPersonalInfo.Controls.Add(this.tbEmailAddress);
            this.tbPersonalInfo.Controls.Add(this.tbCellPhone);
            this.tbPersonalInfo.Controls.Add(this.tbPostalAddress1);
            this.tbPersonalInfo.Controls.Add(this.timePickerDOB);
            this.tbPersonalInfo.Controls.Add(this.cmbCUserRoles);
            this.tbPersonalInfo.Controls.Add(this.TitleCmbBox);
            this.tbPersonalInfo.Controls.Add(this.btUpdate);
            this.tbPersonalInfo.Controls.Add(this.btLogout);
            this.tbPersonalInfo.Location = new System.Drawing.Point(4, 22);
            this.tbPersonalInfo.Name = "tbPersonalInfo";
            this.tbPersonalInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonalInfo.Size = new System.Drawing.Size(729, 514);
            this.tbPersonalInfo.TabIndex = 0;
            this.tbPersonalInfo.Text = "Personal Information";
            this.tbPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Comments";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 396);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Password";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 337);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "CellPhone";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 164);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Date of Bairth";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-308, -53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "label10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "ID Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Postal Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Client Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "First Name";
            // 
            // tbPostAddress
            // 
            this.tbPostAddress.Location = new System.Drawing.Point(124, 253);
            this.tbPostAddress.Name = "tbPostAddress";
            this.tbPostAddress.Size = new System.Drawing.Size(121, 20);
            this.tbPostAddress.TabIndex = 24;
            // 
            // tbFirstNames
            // 
            this.tbFirstNames.Location = new System.Drawing.Point(124, 26);
            this.tbFirstNames.Name = "tbFirstNames";
            this.tbFirstNames.Size = new System.Drawing.Size(121, 20);
            this.tbFirstNames.TabIndex = 23;
            // 
            // tbCommentPersoInfo
            // 
            this.tbCommentPersoInfo.Location = new System.Drawing.Point(376, 281);
            this.tbCommentPersoInfo.Multiline = true;
            this.tbCommentPersoInfo.Name = "tbCommentPersoInfo";
            this.tbCommentPersoInfo.Size = new System.Drawing.Size(208, 122);
            this.tbCommentPersoInfo.TabIndex = 22;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(124, 72);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(121, 20);
            this.tbLastName.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(124, 393);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(121, 20);
            this.tbPassword.TabIndex = 19;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(-15, -40);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(121, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Text = "First Name";
            // 
            // tbIdNumber
            // 
            this.tbIdNumber.Location = new System.Drawing.Point(124, 114);
            this.tbIdNumber.Name = "tbIdNumber";
            this.tbIdNumber.Size = new System.Drawing.Size(121, 20);
            this.tbIdNumber.TabIndex = 2;
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(124, 218);
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(121, 20);
            this.tbEmailAddress.TabIndex = 3;
            // 
            // tbCellPhone
            // 
            this.tbCellPhone.Location = new System.Drawing.Point(124, 337);
            this.tbCellPhone.Name = "tbCellPhone";
            this.tbCellPhone.Size = new System.Drawing.Size(121, 20);
            this.tbCellPhone.TabIndex = 9;
            // 
            // tbPostalAddress1
            // 
            this.tbPostalAddress1.Location = new System.Drawing.Point(153, -40);
            this.tbPostalAddress1.Name = "tbPostalAddress1";
            this.tbPostalAddress1.Size = new System.Drawing.Size(215, 20);
            this.tbPostalAddress1.TabIndex = 4;
            this.tbPostalAddress1.Text = "Postal Address 1";
            // 
            // timePickerDOB
            // 
            this.timePickerDOB.Location = new System.Drawing.Point(124, 164);
            this.timePickerDOB.Name = "timePickerDOB";
            this.timePickerDOB.Size = new System.Drawing.Size(121, 20);
            this.timePickerDOB.TabIndex = 18;
            // 
            // cmbCUserRoles
            // 
            this.cmbCUserRoles.FormattingEnabled = true;
            this.cmbCUserRoles.Items.AddRange(new object[] {
            "Client",
            "Government"});
            this.cmbCUserRoles.Location = new System.Drawing.Point(124, 291);
            this.cmbCUserRoles.Name = "cmbCUserRoles";
            this.cmbCUserRoles.Size = new System.Drawing.Size(121, 21);
            this.cmbCUserRoles.TabIndex = 17;
            // 
            // TitleCmbBox
            // 
            this.TitleCmbBox.FormattingEnabled = true;
            this.TitleCmbBox.Location = new System.Drawing.Point(-134, -40);
            this.TitleCmbBox.Name = "TitleCmbBox";
            this.TitleCmbBox.Size = new System.Drawing.Size(66, 21);
            this.TitleCmbBox.TabIndex = 15;
            this.TitleCmbBox.Text = "Title";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(376, 476);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 10;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(482, 476);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(75, 23);
            this.btLogout.TabIndex = 11;
            this.btLogout.Text = "Back";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // Tabbss
            // 
            this.Tabbss.AccessibleName = "";
            this.Tabbss.Controls.Add(this.tbPersonalInfo);
            this.Tabbss.Controls.Add(this.tabInvoice);
            this.Tabbss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabbss.Location = new System.Drawing.Point(11, 22);
            this.Tabbss.Name = "Tabbss";
            this.Tabbss.SelectedIndex = 0;
            this.Tabbss.Size = new System.Drawing.Size(737, 540);
            this.Tabbss.TabIndex = 21;
            this.Tabbss.Tag = "";
            // 
            // cTLogisticsDataSet1
            // 
            this.cTLogisticsDataSet1.DataSetName = "CTLogisticsDataSet1";
            this.cTLogisticsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.cTLogisticsDataSet1;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // colTotal
            // 
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            // 
            // AddRemove
            // 
            this.AddRemove.HeaderText = "Add/Remove";
            this.AddRemove.Name = "AddRemove";
            // 
            // LoggedInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 567);
            this.Controls.Add(this.Tabbss);
            this.Name = "LoggedInPage";
            this.Text = "UserPage";
            this.Load += new System.EventHandler(this.LoggedInPage_Load_1);
            this.tabInvoice.ResumeLayout(false);
            this.tabInvoice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvoice)).EndInit();
            this.tbPersonalInfo.ResumeLayout(false);
            this.tbPersonalInfo.PerformLayout();
            this.Tabbss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTLogisticsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabInvoice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbVAT;
        private System.Windows.Forms.Label lbSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgInvoice;
        private System.Windows.Forms.Button btCancelProducts;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tbPersonalInfo;
        private System.Windows.Forms.TextBox tbPostAddress;
        private System.Windows.Forms.TextBox tbFirstNames;
        private System.Windows.Forms.TextBox tbCommentPersoInfo;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbIdNumber;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.TextBox tbCellPhone;
        private System.Windows.Forms.TextBox tbPostalAddress1;
        private System.Windows.Forms.DateTimePicker timePickerDOB;
        private System.Windows.Forms.ComboBox cmbCUserRoles;
        private System.Windows.Forms.ComboBox TitleCmbBox;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.TabControl Tabbss;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private CTLogisticsDataSet cTLogisticsDataSet;
        private CTLogisticsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private CTLogisticsDataSet1 cTLogisticsDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private CTLogisticsDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AddRemove;
    }
}