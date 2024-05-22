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

    public override string ToString()
    {
        return $"Phone numbers:\n  Home: {OfficePhone},\n  Cell: {PrivatePhone}";
    }
}