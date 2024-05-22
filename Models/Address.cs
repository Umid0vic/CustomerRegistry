namespace CustomerRegistry.Models;

public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string ZipCode { get; private set; }
    public string Country { get; private set; }

    public Address(string street, string city, string zipCode, string country)
    {
        this.Street = street;
        this.City = city;
        this.ZipCode = zipCode;
        this.Country = country;
    }

    public Address(string city, string zipCode, string country)
        : this("", city, zipCode, country)
    {
    }

    public Address(string country)
        : this("", "", "", country)
    {
    }

    public override string ToString()
    {
        return $"{Street}, {City}, {ZipCode}, {Country}";
    }
}