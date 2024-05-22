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
        return $"Home: {HomePhone}, Cell: {CellPhone}";
    }
}