namespace CustomerRegistry.Models;

public class Phone
{
    public string OfficePhone { get; private set; }
    public string PrivatePhone { get; private set; }

    public Phone(string phone, string cellPhone)
    {
        this.OfficePhone = phone;
        this.PrivatePhone = cellPhone;
    }
}