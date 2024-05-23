using CustomerRegistry.Models;

namespace CustomerRegistry;

public partial class ContactForm : Form
{
    public Contact ContactData { get; private set; }

    public ContactForm()
    {
        InitializeComponent();
    }

    public ContactForm(Contact contact) : this()
    {
        txtFirstName.Text = contact.FirstName;
        txtLastName.Text = contact.LastName;
        txtPrivatePhone.Text = contact.Phone.PrivatePhone;
        txtOfficePhone.Text = contact.Phone.OfficePhone;
        txtEmailBusiness.Text = contact.Email.BusinessEmail;
        txtEmailPrivate.Text = contact.Email.PrivateEmail;
        txtStreet.Text = contact.Address.Street;
        txtCity.Text = contact.Address.City;
        txtZipCode.Text = contact.Address.ZipCode;
        cmbCountry.Text = contact.Address.Country;
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
        ContactData = new Contact(
            txtFirstName.Text,
            txtLastName.Text,
            new Address(txtStreet.Text, txtCity.Text, txtZipCode.Text, cmbCountry.Text),
            new Phone(txtPrivatePhone.Text, txtOfficePhone.Text),
            new Email(txtEmailBusiness.Text, txtEmailPrivate.Text)
        );

        if (ContactData.CheckData())
        {
            this.DialogResult = DialogResult.OK;
        }
        else
        {
            MessageBox.Show("Please fill in all required fields.");
            this.DialogResult = DialogResult.None;
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo) ==
            DialogResult.Yes)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}