namespace Lab_1;

public class Product
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrEmpty(value) ? "Product Name" : value;
    }
    
    public Product(string name)
    {
        Name = name;
    }
}