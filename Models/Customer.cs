namespace CustomerRegistry.Models;

public class Customer
{
    public string ID { get; private set; }
    public Contact Contact { get; set; }

    public Customer(string id, Contact contact)
    {
        this.ID = id;
        this.Contact = contact;
    }
}