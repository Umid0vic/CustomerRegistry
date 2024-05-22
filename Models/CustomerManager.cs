namespace CustomerRegistry.Models;

public class CustomerManager
{
    private List<Customer> customers;

    public CustomerManager()
    {
        this.customers = new List<Customer>();
    }

    public void AddCustomer(Customer customer)
    {
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