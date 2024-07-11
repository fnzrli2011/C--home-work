using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketHesabat;

public class SuperMarket : Market   
{
    public int NumOfMarket;
    public double TotalIncome=0;
    public int say = 0;

    public void AddMarket(Market market)
    {

        market.Name = "BolMarket";
        market.FullStock = 12;
        market.EmptyStock = 12;
        market.ProductCostPrice = 3;
        market.AddingProduct = 15;
        market.AddProduct(AddingProduct);
        TotalIncome += Income;
        market.SoldProduct = 12;
        market.Sell(SoldProduct);
        TotalIncome -= market.Income;
        Console.WriteLine(TotalIncome);
    }
}
