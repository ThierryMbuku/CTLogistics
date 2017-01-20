namespace CTLogistics
{
    partial class ClientsLogin
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDNumber = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 25);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // IDNumber
            // 
            this.IDNumber.Location = new System.Drawing.Point(188, 94);
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.Size = new System.Drawing.Size(186, 20);
            this.IDNumber.TabIndex = 4;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(188, 145);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(186, 20);
            this.Password.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(50, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 25);
            this.button3.TabIndex = 6;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(335, 332);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(109, 23);
            this.btRegister.TabIndex = 7;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // ClientsLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 399);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.IDNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "ClientsLogin";
            this.Text = "ClientsLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDNumber;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btRegister;
    }
}