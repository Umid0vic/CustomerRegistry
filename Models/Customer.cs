// Osman Said 23/05/2024

namespace CustomerRegistry.Models;

/// <summary>
/// Represents a customer with an ID and contact details.
/// </summary>
public class Customer
{
    private string id;
    private Contact contact;

    /// <summary>
    /// Default constructor - calls another constructor in this class
    /// </summary>
    public Customer()
    {
    }

    /// <summary>
    /// Constructor with one parameter - calls the constructor with 
    /// two parameters, using a default value as the second argument.
    /// </summary>
    /// <param name="id">The customer ID.</param>
    public Customer(string id) : this(id, new Contact())
    {
    }

    /// <summary>
    /// Copy constructor returning copy
    /// </summary>
    public Customer(Customer theOther)
    {
        this.id = theOther.id;
        this.contact = new Contact(theOther.contact);
    }

    /// <summary>
    /// Constructor with two parameters.
    /// </summary>
    /// <param name="id">The customer ID.</param>
    /// <param name="contact">The contact details.</param>
    public Customer(string id, Contact contact)
    {
        this.id = id;
        this.contact = contact;
    }

    /// <summary>
    /// Property related to the id field.
    /// </summary>
    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    /// <summary>
    /// Property related to the contact field.
    /// </summary>
    public Contact Contact
    {
        get { return contact; }
        set { contact = value; }
    }
}