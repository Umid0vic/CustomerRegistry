using CustomerRegistry.Models;

namespace CustomerRegistry;

public partial class MainForm : Form
{
    private CustomerManager customerMngr;

    public MainForm()
    {
        InitializeComponent();
        customerMngr = new CustomerManager();
        UpdateCustomerList();
    }

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
                                      $"    Private: \t{contact.Email.PrivateEmail}\n" +
                                      $"    Office: \t{contact.Email.BusinessEmail}\n\n" +
                                      "Phone numbers\n" +
                                      $"    Private: \t{contact.Phone.PrivatePhone}\n" +
                                      $"    Office: \t{contact.Phone.OfficePhone}";
        }
    }

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