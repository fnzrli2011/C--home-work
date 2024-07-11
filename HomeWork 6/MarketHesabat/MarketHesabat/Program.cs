using System;
using System.Security.Cryptography;

class HomeWork6
{
    static void Main(string[] args)
    {
        Market market = new Market("BolMart");
        Console.WriteLine("Dolu Stoku Yazin:");
        market.FullStock = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bos Stoku Yazin:");
        market.EmptyStock = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Marketin Budcesi:");
        market.Budget = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Mehsul Satilir(Y/N)");
        string c1=Console.ReadLine();
        if (c1 == "Y")
        {
            Console.WriteLine("Mehsulun Deyeri:");
            market.ProductCostPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gun erzinde satilan mehsul:");
            market.SoldProduct = Convert.ToInt32(Console.ReadLine());
            market.Sell(market.SoldProduct);
        }
        Console.WriteLine("Mehsul Alinir(Y/N)");
        string c2=Console.ReadLine();
        if (c2 == "Y")
        {
            Console.WriteLine("Mehsulun Deyeri:");
            market.ProductCostPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Elave olunan Mehsul:");
            market.AddingProduct = Convert.ToInt32(Console.ReadLine());
            market.AddProduct(market.AddingProduct);
        }
    }
}

