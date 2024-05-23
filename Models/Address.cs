namespace CustomerRegistry.Models;

/// <summary>
/// Represents an address with street, city, zip code, and country.
/// </summary>
public class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string ZipCode { get; private set; }
    public string Country { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Address"/>.
    /// </summary>
    /// <param name="street">The street address.</param>
    /// <param name="city">The city.</param>
    /// <param name="zipCode">The zip code.</param>
    /// <param name="country">The country.</param>
    public Address(string street, string city, string zipCode, string country)
    {
        this.Street = street;
        this.City = city;
        this.ZipCode = zipCode;
        this.Country = country;
    }
}