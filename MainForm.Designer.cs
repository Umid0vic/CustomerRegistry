namespace CustomerRegistry
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstboxCustomers = new ListBox();
            grpBoxCustomerDetails = new GroupBox();
            btnAdd = new Button();
            btnEdit = new Button();
            Delete = new Button();
            lblID = new Label();
            lblName = new Label();
            lnlOfficePhone = new Label();
            lblOfficeEmail = new Label();
            SuspendLayout();
            // 
            // lstboxCustomers
            // 
            lstboxCustomers.FormattingEnabled = true;
            lstboxCustomers.ItemHeight = 15;
            lstboxCustomers.Location = new Point(10, 40);
            lstboxCustomers.Name = "lstboxCustomers";
            lstboxCustomers.Size = new Size(596, 349);
            lstboxCustomers.TabIndex = 0;
            // 
            // grpBoxCustomerDetails
            // 
            grpBoxCustomerDetails.Location = new Point(612, 31);
            grpBoxCustomerDetails.Name = "grpBoxCustomerDetails";
            grpBoxCustomerDetails.Size = new Size(280, 358);
            grpBoxCustomerDetails.TabIndex = 1;
            grpBoxCustomerDetails.TabStop = false;
            grpBoxCustomerDetails.Text = "Customer Details";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 408);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(220, 408);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            Delete.Location = new Point(383, 408);
            Delete.Name = "Delete";
            Delete.Size = new Size(120, 30);
            Delete.TabIndex = 4;
            Delete.Text = "btnDelete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(15, 20);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 5;
            lblID.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(70, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(161, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name (Surename, Firstname)";
            // 
            // lnlOfficePhone
            // 
            lnlOfficePhone.AutoSize = true;
            lnlOfficePhone.Location = new Point(294, 20);
            lnlOfficePhone.Name = "lnlOfficePhone";
            lnlOfficePhone.Size = new Size(76, 15);
            lnlOfficePhone.TabIndex = 7;
            lnlOfficePhone.Text = "Office Phone";
            // 
            // lblOfficeEmail
            // 
            lblOfficeEmail.AutoSize = true;
            lblOfficeEmail.Location = new Point(473, 20);
            lblOfficeEmail.Name = "lblOfficeEmail";
            lblOfficeEmail.Size = new Size(76, 15);
            lblOfficeEmail.TabIndex = 8;
            lblOfficeEmail.Text = "Office E-Mail";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 450);
            Controls.Add(lblOfficeEmail);
            Controls.Add(lnlOfficePhone);
            Controls.Add(lblName);
            Controls.Add(lblID);
            Controls.Add(Delete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(grpBoxCustomerDetails);
            Controls.Add(lstboxCustomers);
            Name = "MainForm";
            Text = "Customer Registry by Osman";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstboxCustomers;
        private GroupBox grpBoxCustomerDetails;
        private Button btnAdd;
        private Button btnEdit;
        private Button Delete;
        private Label lblID;
        private Label lblName;
        private Label lnlOfficePhone;
        private Label lblOfficeEmail;
    }
}
