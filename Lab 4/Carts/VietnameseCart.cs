namespace Lab_4;

public class VietnameseCart : StreetCartBase
{
    public override BahnMi SellFood(Cash payment)
    {
        return new BahnMi();
    }
}