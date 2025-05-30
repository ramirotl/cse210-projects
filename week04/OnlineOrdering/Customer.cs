
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress() //Calls the method from Address class
    {
        return _address.GetFullAddress();
    }
    public bool LivesInUSA() //Calls the method from Address class
    {
        return _address.IsInUSA();
    }
}