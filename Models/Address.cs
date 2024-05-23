// Osman Said 23/05/2024

namespace CustomerRegistry.Models;

/// <summary>
/// Represents an address with street, city, zip code, and country.
/// </summary>
public class Address
{
    private string street;
    private string city;
    private string zipCode;
    private string country;

    /// <summary>
    /// Default constructor - calls another constructor in this class
    /// </summary>
    public Address()
    {
    }

    /// <summary>
    /// Constructor with one parameter - calls the constructor with 
    /// four parameters, using default values as the other arguments.
    /// </summary>
    /// <param name="street">The street address.</param>
    public Address(string street) : this(street, string.Empty, string.Empty, string.Empty)
    {
    }

    /// <summary>
    /// Copy constructor returning copy
    /// </summary>
    public Address(Address theOther)
    {
        this.street = theOther.street;
        this.city = theOther.city;
        this.zipCode = theOther.zipCode;
        this.country = theOther.country;
    }

    /// <summary>
    /// Constructor with four parameters.
    /// </summary>
    /// <param name="street">The street address.</param>
    /// <param name="city">The city.</param>
    /// <param name="zipCode">The zip code.</param>
    /// <param name="country">The country.</param>
    public Address(string street, string city, string zipCode, string country)
    {
        this.street = street;
        this.city = city;
        this.zipCode = zipCode;
        this.country = country;
    }

    /// <summary>
    /// Property related to the street field.
    /// </summary>
    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    /// <summary>
    /// Property related to the city field.
    /// </summary>
    public string City
    {
        get { return city; }
        set { city = value; }
    }

    /// <summary>
    /// Property related to the zipCode field.
    /// </summary>
    public string ZipCode
    {
        get { return zipCode; }
        set { zipCode = value; }
    }

    /// <summary>
    /// Property related to the country field.
    /// </summary>
    public string Country
    {
        get { return country; }
        set { country = value; }
    }
}