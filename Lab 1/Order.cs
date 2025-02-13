namespace Lab_1;

public class Order
{
    private string _state;
    
    public Product OrderedProduct { get; }

    public string State
    {
        get => _state;
        set
        {
            string[] validStates = ["Ordered", "Packed", "Dispatched", "Delivered"];
            _state = Array.Exists(validStates, s => s == value) ? value : "Ordered";
        }
    }

    public Order(Product product)
    {
        OrderedProduct = product ?? throw new ArgumentNullException(nameof(product));
        State = "Ordered";
    }
}