namespace Lab_3;

public class Product
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    
    public Product(string name, decimal unitPrice)
    {
        Name = name;
        UnitPrice = unitPrice;
    }
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}