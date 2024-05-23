namespace CustomerRegistry.Models;

/// <summary>
/// Represents a contact with first name, last name, address, phone, and email.
/// </summary>
public class Contact
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Address Address { get; private set; }
    public Phone Phone { get; private set; }
    public Email Email { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Contact"/> class with the specified details.
    /// </summary>
    /// <param name="firstName">The first name.</param>
    /// <param name="lastName">The last name.</param>
    /// <param name="address">The address.</param>
    /// <param name="phone">The phone numbers.</param>
    /// <param name="email">The email addresses.</param>
    public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Phone = phone;
        Email = email;
    }

    /// <summary>
    /// Checks if the contact data is valid.
    /// </summary>
    /// <returns>True if the data is valid; otherwise, false.</returns>
    public bool CheckData()
    {
        // Basic validation for required fields
        return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) &&
               !string.IsNullOrEmpty(Address.City) && !string.IsNullOrEmpty(Address.Country);
    }
}