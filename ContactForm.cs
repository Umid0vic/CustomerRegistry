using CustomerRegistry.Models;

namespace CustomerRegistry;

/// <summary>
/// Represents a form for managing contact details.
/// </summary>
public partial class ContactForm : Form
{
    /// <summary>
    /// Gets the contact data entered in the form.
    /// </summary>
    public Contact ContactData { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactForm"/> class.
    /// </summary>
    public ContactForm()
    {
        InitializeComponent();
        PopulateCountryComboBox();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContactForm"/> class with existing contact data.
    /// </summary>
    /// <param name="contact">The contact data to initialize the form with.</param>
    public ContactForm(Contact contact) : this()
    {
        txtFirstName.Text = contact.FirstName;
        txtLastName.Text = contact.LastName;
        txtPrivatePhone.Text = contact.Phone.PrivatePhone;
        txtOfficePhone.Text = contact.Phone.OfficePhone;
        txtEmailBusiness.Text = contact.Email.Work;
        txtEmailPrivate.Text = contact.Email.Personal;
        txtStreet.Text = contact.Address.Street;
        txtCity.Text = contact.Address.City;
        txtZipCode.Text = contact.Address.ZipCode;
        cmbCountry.Text = contact.Address.Country;
    }

    public void PopulateCountryComboBox()
    {
        cmbCountry.Items.AddRange(Enum.GetNames(typeof(Countries)).ToArray());
    }

    /// <summary>
    /// Handles the OK button click event to save contact data.
    /// </summary>
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

    /// <summary>
    /// Handles the Cancel button click event to cancel the operation.
    /// </summary>
    private void btnCancel_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to cancel?", "Confirm", MessageBoxButtons.YesNo) ==
            DialogResult.Yes)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}