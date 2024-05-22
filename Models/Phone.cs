namespace CustomerRegistry.Models;

public class Phone
{
    public string HomePhone { get; private set; }
    public string CellPhone { get; private set; }

    public Phone(string phone, string cellPhone)
    {
        this.HomePhone = phone;
        this.CellPhone = cellPhone;
    }

    public override string ToString()
    {
        return $"Phone numbers:\n  Home: {HomePhone},\n  Cell: {CellPhone}";
    }
}