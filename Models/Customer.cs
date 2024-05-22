namespace CustomerRegistry.Models;

public class Customer
{
    public string ID { get; private set; }
    public Contact Contact { get; set; }

    public Customer(Contact contact)
    {
        ID = Guid.NewGuid().ToString();
        Contact = contact;
    }

    public override string ToString()
    {
        return
            $"{ID}: {Contact.FirstName} {Contact.LastName} {Contact.Phone.OfficePhone} {Contact.Email.BusinessEmail}";
    }
}