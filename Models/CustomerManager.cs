namespace CustomerRegistry.Models;

public class CustomerManager
{
    private List<Customer> customers;
    private HashSet<string> customerIds; // To ensure unique IDs
    private Random random;

    public CustomerManager()
    {
        this.customers = new List<Customer>();
        this.customerIds = new HashSet<string>();
        this.random = new Random();
    }

    private string GenerateUniqueId()
    {
        string newId;
        do
        {
            newId = this.random.Next(1000, 10000).ToString(); // Generates a 4-digit ID
        } while (this.customerIds.Contains(newId));

        this.customerIds.Add(newId);
        return newId;
    }

    public void AddCustomer(Contact contact)
    {
        string id = GenerateUniqueId();
        Customer customer = new Customer(id, contact);
        this.customers.Add(customer);
    }

    public void ChangeCustomer(Customer customer, int index)
    {
        if (index >= 0 && index < this.customers.Count)
        {
            this.customers[index] = customer;
        }
    }

    public void RemoveCustomer(int index)
    {
        if (index >= 0 && index <= this.customers.Count)
        {
            this.customerIds.Remove(customers[index].ID);
            this.customers.RemoveAt(index);
        }
    }

    public Customer GetCustomer(int index)
    {
        if (index >= 0 && index < customers.Count)
        {
            return customers[index];
        }

        return null;
    }

    public List<Customer> GetCustomers()
    {
        return customers;
    }
}