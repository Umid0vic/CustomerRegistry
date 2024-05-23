namespace CustomerRegistry.Models;

/// <summary>
/// Represents email addresses for business and private use.
/// </summary>
public class Email
{
    public string BusinessEmail { get; private set; }
    public string PrivateEmail { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Email"/> class with the specified email addresses.
    /// </summary>
    /// <param name="businessEmail">The business email address.</param>
    /// <param name="privateEmail">The private email address.</param>
    public Email(string businessEmail, string privateEmail)
    {
        this.BusinessEmail = businessEmail;
        this.PrivateEmail = privateEmail;
    }
}