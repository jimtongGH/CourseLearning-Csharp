namespace Lab_4;

public class IceCreamCart : StreetCartBase
{
    public override IceCream SellFood(Cash payment)
    {
        return new IceCream();
    }
}