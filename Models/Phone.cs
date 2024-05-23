// Osman Said 23/05/2024

namespace CustomerRegistry.Models;

/// <summary>
/// Represents phone numbers for office and private use.
/// </summary>
public class Phone
{
    private string officePhone;
    private string privatePhone;

    /// <summary>
    /// Default constructor - calls another constructor in this class
    /// </summary>
    public Phone()
    {
    }

    /// <summary>
    /// Constructor with one parameter - calls the constructor with 
    /// two parameters, using a default value as the second argument.
    /// </summary>
    /// <param name="officePhone">The office phone number.</param>
    public Phone(string officePhone) : this(officePhone, string.Empty)
    {
    }

    /// <summary>
    /// Copy constructor returning copy
    /// </summary>
    public Phone(Phone theOther)
    {
        this.officePhone = theOther.officePhone;
        this.privatePhone = theOther.privatePhone;
    }

    /// <summary>
    /// Constructor with two parameters.
    /// </summary>
    /// <param name="officePhone">The office phone number.</param>
    /// <param name="privatePhone">The private phone number.</param>
    public Phone(string officePhone, string privatePhone)
    {
        this.officePhone = officePhone;
        this.privatePhone = privatePhone;
    }

    /// <summary>
    /// Property related to the officePhone field.
    /// </summary>
    public string OfficePhone
    {
        get { return officePhone; }
        set { officePhone = value; }
    }

    /// <summary>
    /// Property related to the privatePhone field.
    /// </summary>
    public string PrivatePhone
    {
        get { return privatePhone; }
        set { privatePhone = value; }
    }
}