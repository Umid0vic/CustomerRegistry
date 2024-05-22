namespace CustomerRegistry.Models;

public class Contact
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Address Address { get; private set; }
    public Phone Phone { get; private set; }
    public Email Email { get; private set; }

    public Contact(string firstName, string lastName, Address address, Phone phone, Email email)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        Phone = phone;
        Email = email;
    }

    public bool CheckData()
    {
        // Basic validation for required fields
        return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName) &&
               !string.IsNullOrEmpty(Address.City) && !string.IsNullOrEmpty(Address.Country);
    }
}