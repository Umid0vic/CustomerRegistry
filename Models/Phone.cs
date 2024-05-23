namespace CustomerRegistry.Models;

/// <summary>
/// Represents phone numbers for office and private use.
/// </summary>
public class Phone
{
    public string OfficePhone { get; private set; }
    public string PrivatePhone { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Phone"/> class with the specified phone numbers.
    /// </summary>
    /// <param name="officePhone">The office phone number.</param>
    /// <param name="privatePhone">The private phone number.</param>
    public Phone(string phone, string cellPhone)
    {
        this.OfficePhone = phone;
        this.PrivatePhone = cellPhone;
    }
}