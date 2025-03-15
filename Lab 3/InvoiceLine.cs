namespace Lab_3;

public class InvoiceLine
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    
    public InvoiceLine(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }
    
    public decimal GetTotal() => Product.UnitPrice * Quantity;
    
    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}