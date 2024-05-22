namespace CustomerRegistry.Models;

public class Email
{
    public string BusinessEmail { get; private set; }
    public string PrivateEmail { get; private set; }

    public Email(string businessEmail, string privateEmail)
    {
        this.BusinessEmail = businessEmail;
        this.PrivateEmail = privateEmail;
    }

    public override string ToString()
    {
        return $"Emails:\n  Private: {PrivateEmail} \n  Office: {BusinessEmail}";
    }
}