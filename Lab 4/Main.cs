using Lab_4;

class main
{
    static void Main()
    {
        // 1. A SandwichCart that sells sandwiches for cash.
        var sandwichCart = new SandwichCart();
        var sandwich = sandwichCart.SellFood(new Cash());
        Console.WriteLine($"SandwichCart sells: {sandwich.GetType().Name}");
        
        // 2. A VietnameseCart that sells Bahn mi for cash.
        var vietnameseCart = new VietnameseCart();
        var bahnMi = vietnameseCart.SellFood(new Cash());
        Console.WriteLine($"VietnameseCart sells: {bahnMi.GetType().Name}");
        
        // 3. A SwedensVietnameseCart that sells Bahn mi for Swedish Kronor.
        var swedensVietnameseCart = new SwedensVietnameseCart();
        var swedishBahnMi = swedensVietnameseCart.SellFood(new SEK());
        Console.WriteLine($"SwedensVietnameseCart sells: {swedishBahnMi.GetType().Name} for Swedish Kronor");
        
        // 10. An IceCreamCart that sells ice cream for cash.
        var iceCreamCart = new IceCreamCart();
        var iceCream = iceCreamCart.SellFood(new Cash());
        Console.WriteLine($"IceCreamCart sells: {iceCream.GetType().Name}");
        
        // 11. An IceCreamCart that sells ice cream for EUR.
        var euroIceCreamCart = new EuroIceCreamCart();
        var euroIceCream = euroIceCreamCart.SellFood(new EUR());
        Console.WriteLine($"EuroIceCreamCart sells: {euroIceCream.GetType().Name} for Euros");

        Console.ReadLine();
    }
}