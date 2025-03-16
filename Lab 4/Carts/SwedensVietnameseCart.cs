namespace Lab_4;

public class SwedensVietnameseCart : StreetCartBase
{
    public override BahnMi SellFood(Cash payment)
    {
        if (payment is SEK)
        {
            Console.WriteLine("Received Swedish Kronor payment");
        }
        return new BahnMi();
    }
}