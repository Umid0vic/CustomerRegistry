// Osman Said 23/05/2024

namespace CustomerRegistry.Models;

/// <summary>
/// Represents a contact with first name, last name, address, phone, and email.
/// </summary>
public class Contact
{
    private string firstName;
    private string lastName;
    private Address address;
    private Phone phone;
    private Email email;

    /// <summary>
    /// Default constructor - calls another constructor in this class
    /// </summary>
    public Contact()
    {
    }

    /// <summary>
    /// Constructor with one parameter - calls the constructor with 
    /// five parameters, using default values as the other arguments.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    public Contact(string firstName) : this(firstName, string.Empty, new Address(), new Phone(), new Email())
    {
    }

    /// <summary>
    /// Copy constructor returning copy
    /// </summary>
    public Contact(Contact theOther)
    {
        this.firstName = theOther.firstName;
        this.lastName = theOther.lastName;
        this.address = new Address(theOther.address);
        this.phone = new Phone(theOther.phone);
        this.email = new Email(theOther.email);
    }

    /// <summary>
    /// Constructor with five parameters.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="address">The address.</param>
    /// <param name="phone">The phone numbers.</param>
    /// <param name="email">The email addresses.</param>
    public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.phone = phone;
        this.email = email;
    }

    /// <summary>
    /// Property related to the firstName field.
    /// </summary>
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    /// <summary>
    /// Property related to the lastName field.
    /// </summary>
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    /// <summary>
    /// Property related to the address field.
    /// </summary>
    public Address Address
    {
        get { return address; }
        set { address = value; }
    }

    /// <summary>
    /// Property related to the phone field.
    /// </summary>
    public Phone Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    /// <summary>
    /// Property related to the email field.
    /// </summary>
    public Email Email
    {
        get { return email; }
        set { email = value; }
    }

    /// <summary>
    /// Checks if the contact data is valid.
    /// </summary>
    public bool CheckData()
    {
        return !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) &&
               !string.IsNullOrEmpty(address.City) && !string.IsNullOrEmpty(address.Country);
    }
}