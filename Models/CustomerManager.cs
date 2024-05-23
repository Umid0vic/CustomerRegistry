// Osman Said 23/05/2024

namespace CustomerRegistry.Models;

/// <summary>
/// Manages a collection of customers.
/// </summary>
public class CustomerManager
{
    private List<Customer> customers;
    private HashSet<string> customerIds; // To ensure unique IDs
    private Random random;

    /// <summary>
    /// Initializes a new instance of the <see cref="CustomerManager"/> class.
    /// </summary>
    public CustomerManager()
    {
        this.customers = new List<Customer>();
        this.customerIds = new HashSet<string>();
        this.random = new Random();
    }

    /// <summary>
    /// Generates a unique 4-digit ID.
    /// </summary>
    /// <returns>A unique 4-digit ID.</returns>
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

    /// <summary>
    /// Adds a new customer with the specified contact details.
    /// </summary>
    /// <param name="contact">The contact details of the customer.</param>
    public void AddCustomer(Contact contact)
    {
        string id = GenerateUniqueId();
        Customer customer = new Customer(id, contact);
        this.customers.Add(customer);
    }

    /// <summary>
    /// Changes the details of an existing customer at the specified index.
    /// </summary>
    /// <param name="customer">The customer with updated details.</param>
    /// <param name="index">The index of the customer to update.</param>
    public void ChangeCustomer(Customer customer, int index)
    {
        if (index >= 0 && index < this.customers.Count)
        {
            this.customers[index] = customer;
        }
    }

    /// <summary>
    /// Removes the customer at the specified index.
    /// </summary>
    /// <param name="index">The index of the customer to remove.</param>
    public void RemoveCustomer(int index)
    {
        if (index >= 0 && index <= this.customers.Count)
        {
            this.customerIds.Remove(customers[index].ID);
            this.customers.RemoveAt(index);
        }
    }

    /// <summary>
    /// Gets the customer at the specified index.
    /// </summary>
    /// <param name="index">The index of the customer to retrieve.</param>
    /// <returns>The customer at the specified index.</returns>
    public Customer GetCustomer(int index)
    {
        if (index >= 0 && index < customers.Count)
        {
            return customers[index];
        }

        return null;
    }

    /// <summary>
    /// Gets the list of all customers.
    /// </summary>
    /// <returns>A list of all customers.</returns>
    public List<Customer> GetCustomers()
    {
        return customers;
    }
}