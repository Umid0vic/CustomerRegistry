namespace CustomerRegistry.Models;

/// <summary>
/// Represents a customer with an ID and contact details.
/// </summary>
public class Customer
{
    public string ID { get; private set; }
    public Contact Contact { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Customer"/> class with the specified ID and contact details.
    /// </summary>
    /// <param name="id">The customer ID.</param>
    /// <param name="contact">The contact details.</param>
    public Customer(string id, Contact contact)
    {
        this.ID = id;
        this.Contact = contact;
    }
}