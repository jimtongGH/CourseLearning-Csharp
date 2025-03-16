namespace Lab_4;

public class SandwichCart : StreetCartBase
{
    public override Food SellFood(Cash payment)
    {
        return new Sandwich();
    }
}