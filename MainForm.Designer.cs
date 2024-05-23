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
            grpBoxCustomerDetails = new GroupBox();
            lblCustomerDetails = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            listViewCustomers = new ListView();
            columnID = new ColumnHeader();
            columnName = new ColumnHeader();
            columnOfficePhone = new ColumnHeader();
            columnOfficeEmail = new ColumnHeader();
            grpBoxCustomerDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxCustomerDetails
            // 
            grpBoxCustomerDetails.BackColor = SystemColors.Control;
            grpBoxCustomerDetails.Controls.Add(lblCustomerDetails);
            grpBoxCustomerDetails.Location = new Point(616, 22);
            grpBoxCustomerDetails.Name = "grpBoxCustomerDetails";
            grpBoxCustomerDetails.Size = new Size(276, 367);
            grpBoxCustomerDetails.TabIndex = 1;
            grpBoxCustomerDetails.TabStop = false;
            grpBoxCustomerDetails.Text = "Customer Details";
            // 
            // lblCustomerDetails
            // 
            lblCustomerDetails.AutoSize = true;
            lblCustomerDetails.Location = new Point(6, 19);
            lblCustomerDetails.Name = "lblCustomerDetails";
            lblCustomerDetails.Size = new Size(194, 15);
            lblCustomerDetails.TabIndex = 0;
            lblCustomerDetails.Text = "Select a customer to display details.";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 408);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 30);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(220, 408);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 30);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(383, 408);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 30);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listViewCustomers
            // 
            listViewCustomers.Columns.AddRange(new ColumnHeader[] { columnID, columnName, columnOfficePhone, columnOfficeEmail });
            listViewCustomers.FullRowSelect = true;
            listViewCustomers.GridLines = true;
            listViewCustomers.Location = new Point(10, 22);
            listViewCustomers.Name = "listViewCustomers";
            listViewCustomers.Size = new Size(600, 367);
            listViewCustomers.TabIndex = 1;
            listViewCustomers.UseCompatibleStateImageBehavior = false;
            listViewCustomers.View = View.Details;
            listViewCustomers.SelectedIndexChanged += listViewCustomers_SelectedIndexChanged;
            // 
            // columnID
            // 
            columnID.Text = "ID";
            // 
            // columnName
            // 
            columnName.Text = "Name";
            columnName.Width = 180;
            // 
            // columnOfficePhone
            // 
            columnOfficePhone.Text = "Office Phone";
            columnOfficePhone.Width = 180;
            // 
            // columnOfficeEmail
            // 
            columnOfficeEmail.Text = "Office Email";
            columnOfficeEmail.Width = 180;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(904, 450);
            Controls.Add(listViewCustomers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(grpBoxCustomerDetails);
            Name = "MainForm";
            Text = "Customer Registry by Osman";
            grpBoxCustomerDetails.ResumeLayout(false);
            grpBoxCustomerDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpBoxCustomerDetails;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblCustomerDetails;
        private ListView listViewCustomers;
        private ColumnHeader columnID;
        private ColumnHeader columnName;
        private ColumnHeader columnOfficePhone;
        private ColumnHeader columnOfficeEmail;
    }
}