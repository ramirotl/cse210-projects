
public class Product
{
    private string _productName;
    private string _productID;
    private double _unitPrice;
    private int _quantity;

    public Product(string productName, string productID, double unitPrice, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return _unitPrice * _quantity;
    }
    public string GetPackingLabel()
    {
        return $"Product Name: {_productName} - Product ID: {_productID}";
    }
}
