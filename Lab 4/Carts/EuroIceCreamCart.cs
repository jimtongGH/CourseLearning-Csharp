namespace Lab_4;

public class EuroIceCreamCart : StreetCartBase
{
    public override IceCream SellFood(Cash payment)
    {
        if (payment is EUR)
        {
            Console.WriteLine("Received Euros payment");
        }
        return new IceCream();
    }
}