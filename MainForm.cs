using CustomerRegistry.Models;

namespace CustomerRegistry;

/// <summary>
/// Represents the main form for managing the customer registry.
/// </summary>
public partial class MainForm : Form
{
    private CustomerManager customerMngr;

    /// <summary>
    /// Initializes a new instance of the <see cref="MainForm"/> class.
    /// </summary>
    public MainForm()
    {
        InitializeComponent();
        customerMngr = new CustomerManager();
        UpdateCustomerList();
    }

    /// <summary>
    /// Handles the Add button click event to add a new customer.
    /// </summary>
    private void btnAdd_Click(object sender, EventArgs e)
    {
        ContactForm contactForm = new ContactForm();
        if (contactForm.ShowDialog() == DialogResult.OK)
        {
            Contact contact = contactForm.ContactData;
            customerMngr.AddCustomer(contact);
            UpdateCustomerList();
        }
    }

    /// <summary>
    /// Handles the Edit button click event to edit an existing customer.
    /// </summary>
    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (listViewCustomers.SelectedIndices.Count > 0)
        {
            int selectedIndex = listViewCustomers.SelectedIndices[0];
            Customer selectedCustomer = customerMngr.GetCustomer(selectedIndex);
            ContactForm contactForm = new ContactForm(selectedCustomer.Contact);
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                selectedCustomer.Contact = contactForm.ContactData;
                customerMngr.ChangeCustomer(selectedCustomer, selectedIndex);
                UpdateCustomerList();
            }
        }
        else
        {
            MessageBox.Show("Please select a customer to edit.");
        }
    }

    /// <summary>
    /// Handles the Delete button click event to delete a customer.
    /// </summary>
    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (listViewCustomers.SelectedIndices.Count > 0)
        {
            int selectedIndex = listViewCustomers.SelectedIndices[0];
            customerMngr.RemoveCustomer(selectedIndex);
            UpdateCustomerList();
        }
        else
        {
            MessageBox.Show("Please select a customer to delete.");
        }
    }

    /// <summary>
    /// Handles the ListView selected index change event to display customer details.
    /// </summary>
    private void listViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (listViewCustomers.SelectedIndices.Count > 0)
        {
            int selectedIndex = listViewCustomers.SelectedIndices[0];
            Customer selectedCustomer = customerMngr.GetCustomer(selectedIndex);
            Contact contact = selectedCustomer.Contact;

            lblCustomerDetails.Text = $"{contact.FirstName} {contact.LastName}\n" +
                                      $"{contact.Address.Street}\n" +
                                      $"{contact.Address.ZipCode} {contact.Address.City}\n" +
                                      $"{contact.Address.Country}\n\n" +
                                      "Emails\n" +
                                      $"    Private:   {contact.Email.Personal}\n" +
                                      $"    Office:    {contact.Email.Work}\n\n" +
                                      "Phone numbers\n" +
                                      $"    Private:   {contact.Phone.PrivatePhone}\n" +
                                      $"    Office:    {contact.Phone.OfficePhone}";
        }
    }


    /// <summary>
    /// Updates the customer list in the ListView.
    /// </summary>
    private void UpdateCustomerList()
    {
        listViewCustomers.Items.Clear();
        foreach (Customer customer in customerMngr.GetCustomers())
        {
            ListViewItem item = new ListViewItem(customer.ID);
            item.SubItems.Add(customer.Contact.FirstName + " " + customer.Contact.LastName);
            item.SubItems.Add(customer.Contact.Phone.OfficePhone);
            item.SubItems.Add(customer.Contact.Email.BusinessEmail);
            listViewCustomers.Items.Add(item);
        }
    }
}