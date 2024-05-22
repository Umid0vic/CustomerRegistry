namespace CustomerRegistry
{
    partial class ContactForm
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
            grpBoxName = new GroupBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            grpBoxEmailAndPhone = new GroupBox();
            txtEmailPrivate = new TextBox();
            txtEmailBusiness = new TextBox();
            lblEmailPrivate = new Label();
            lblEmailBusiness = new Label();
            txtCellPhone = new TextBox();
            txtHomePhone = new TextBox();
            lblPrivatePhone = new Label();
            lblOfficePhone = new Label();
            grpBoxAddress = new GroupBox();
            cmbCountry = new ComboBox();
            txtZipCode = new TextBox();
            lblCountry = new Label();
            lblZipCode = new Label();
            txtCity = new TextBox();
            txtStreet = new TextBox();
            lblCity = new Label();
            lblStreet = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            grpBoxName.SuspendLayout();
            grpBoxEmailAndPhone.SuspendLayout();
            grpBoxAddress.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxName
            // 
            grpBoxName.Controls.Add(txtLastName);
            grpBoxName.Controls.Add(txtFirstName);
            grpBoxName.Controls.Add(lblLastName);
            grpBoxName.Controls.Add(lblFirstName);
            grpBoxName.Location = new Point(12, 12);
            grpBoxName.Name = "grpBoxName";
            grpBoxName.Size = new Size(380, 100);
            grpBoxName.TabIndex = 0;
            grpBoxName.TabStop = false;
            grpBoxName.Text = "Name";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(103, 60);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(271, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(103, 27);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(271, 23);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(6, 60);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(6, 30);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // grpBoxEmailAndPhone
            // 
            grpBoxEmailAndPhone.Controls.Add(txtEmailPrivate);
            grpBoxEmailAndPhone.Controls.Add(txtEmailBusiness);
            grpBoxEmailAndPhone.Controls.Add(lblEmailPrivate);
            grpBoxEmailAndPhone.Controls.Add(lblEmailBusiness);
            grpBoxEmailAndPhone.Controls.Add(txtCellPhone);
            grpBoxEmailAndPhone.Controls.Add(txtHomePhone);
            grpBoxEmailAndPhone.Controls.Add(lblPrivatePhone);
            grpBoxEmailAndPhone.Controls.Add(lblOfficePhone);
            grpBoxEmailAndPhone.Location = new Point(12, 118);
            grpBoxEmailAndPhone.Name = "grpBoxEmailAndPhone";
            grpBoxEmailAndPhone.Size = new Size(380, 175);
            grpBoxEmailAndPhone.TabIndex = 4;
            grpBoxEmailAndPhone.TabStop = false;
            grpBoxEmailAndPhone.Text = "Email and Phone";
            // 
            // txtEmailPrivate
            // 
            txtEmailPrivate.Location = new Point(103, 122);
            txtEmailPrivate.Name = "txtEmailPrivate";
            txtEmailPrivate.Size = new Size(271, 23);
            txtEmailPrivate.TabIndex = 7;
            // 
            // txtEmailBusiness
            // 
            txtEmailBusiness.Location = new Point(103, 89);
            txtEmailBusiness.Name = "txtEmailBusiness";
            txtEmailBusiness.Size = new Size(271, 23);
            txtEmailBusiness.TabIndex = 6;
            // 
            // lblEmailPrivate
            // 
            lblEmailPrivate.AutoSize = true;
            lblEmailPrivate.Location = new Point(6, 122);
            lblEmailPrivate.Name = "lblEmailPrivate";
            lblEmailPrivate.Size = new Size(78, 15);
            lblEmailPrivate.TabIndex = 5;
            lblEmailPrivate.Text = "Email, private";
            // 
            // lblEmailBusiness
            // 
            lblEmailBusiness.AutoSize = true;
            lblEmailBusiness.Location = new Point(6, 92);
            lblEmailBusiness.Name = "lblEmailBusiness";
            lblEmailBusiness.Size = new Size(87, 15);
            lblEmailBusiness.TabIndex = 4;
            lblEmailBusiness.Text = "Email, business";
            // 
            // txtCellPhone
            // 
            txtCellPhone.Location = new Point(103, 60);
            txtCellPhone.Name = "txtCellPhone";
            txtCellPhone.Size = new Size(271, 23);
            txtCellPhone.TabIndex = 3;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(103, 27);
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(271, 23);
            txtHomePhone.TabIndex = 2;
            // 
            // lblPrivatePhone
            // 
            lblPrivatePhone.AutoSize = true;
            lblPrivatePhone.Location = new Point(6, 60);
            lblPrivatePhone.Name = "lblPrivatePhone";
            lblPrivatePhone.Size = new Size(80, 15);
            lblPrivatePhone.TabIndex = 1;
            lblPrivatePhone.Text = "Private phone";
            // 
            // lblOfficePhone
            // 
            lblOfficePhone.AutoSize = true;
            lblOfficePhone.Location = new Point(6, 30);
            lblOfficePhone.Name = "lblOfficePhone";
            lblOfficePhone.Size = new Size(76, 15);
            lblOfficePhone.TabIndex = 0;
            lblOfficePhone.Text = "Office phone";
            // 
            // grpBoxAddress
            // 
            grpBoxAddress.Controls.Add(cmbCountry);
            grpBoxAddress.Controls.Add(txtZipCode);
            grpBoxAddress.Controls.Add(lblCountry);
            grpBoxAddress.Controls.Add(lblZipCode);
            grpBoxAddress.Controls.Add(txtCity);
            grpBoxAddress.Controls.Add(txtStreet);
            grpBoxAddress.Controls.Add(lblCity);
            grpBoxAddress.Controls.Add(lblStreet);
            grpBoxAddress.Location = new Point(12, 299);
            grpBoxAddress.Name = "grpBoxAddress";
            grpBoxAddress.Size = new Size(380, 175);
            grpBoxAddress.TabIndex = 8;
            grpBoxAddress.TabStop = false;
            grpBoxAddress.Text = "Address";
            // 
            // cmbCountry
            // 
            cmbCountry.BackColor = SystemColors.ControlDark;
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(103, 118);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(271, 23);
            cmbCountry.TabIndex = 7;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(103, 89);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(271, 23);
            txtZipCode.TabIndex = 6;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(6, 122);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(50, 15);
            lblCountry.TabIndex = 5;
            lblCountry.Text = "Country";
            // 
            // lblZipCode
            // 
            lblZipCode.AutoSize = true;
            lblZipCode.Location = new Point(6, 92);
            lblZipCode.Name = "lblZipCode";
            lblZipCode.Size = new Size(53, 15);
            lblZipCode.TabIndex = 4;
            lblZipCode.Text = "Zip code";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(103, 60);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(271, 23);
            txtCity.TabIndex = 3;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(103, 27);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(271, 23);
            txtStreet.TabIndex = 2;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(6, 60);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(28, 15);
            lblCity.TabIndex = 1;
            lblCity.Text = "City";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Location = new Point(6, 30);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(37, 15);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Street";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(55, 480);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 30);
            btnOk.TabIndex = 9;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(226, 480);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 30);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 515);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(grpBoxAddress);
            Controls.Add(grpBoxEmailAndPhone);
            Controls.Add(grpBoxName);
            Name = "ContactForm";
            Text = "ContactForm";
            grpBoxName.ResumeLayout(false);
            grpBoxName.PerformLayout();
            grpBoxEmailAndPhone.ResumeLayout(false);
            grpBoxEmailAndPhone.PerformLayout();
            grpBoxAddress.ResumeLayout(false);
            grpBoxAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxName;
        private Label lblFirstName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private GroupBox grpBoxEmailAndPhone;
        private TextBox txtCellPhone;
        private TextBox txtHomePhone;
        private Label lblPrivatePhone;
        private Label lblOfficePhone;
        private TextBox txtEmailPrivate;
        private TextBox txtEmailBusiness;
        private Label lblEmailPrivate;
        private Label lblEmailBusiness;
        private GroupBox grpBoxAddress;
        private TextBox txtZipCode;
        private Label lblCountry;
        private Label lblZipCode;
        private TextBox txtCity;
        private TextBox txtStreet;
        private Label lblCity;
        private Label lblStreet;
        private ComboBox cmbCountry;
        private Button btnOk;
        private Button btnCancel;
    }
}