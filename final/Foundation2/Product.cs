public class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productID, decimal price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetProductTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} (ID: {_productID}) - ${_price:F2} x {_quantity}";
    }
}