using System;

public class Market
{
    public string Name;
    public int FullStock;
    public int EmptyStock;
    public int SoldProduct;
    public double ProductCostPrice;
    public int AddingProduct;
    public double Income;
    public double Outcome;
    public double Budget;
    public int SatilaBilmeyenProduct;
    public int QebulEdilmeyenProduct;

    public Market(string name)
    {
        Name = name;
    }
    public void Sell(int SoldProduct)
    {
        if (FullStock > SoldProduct)
        {
            EmptyStock += SoldProduct;
            FullStock -= SoldProduct;
            Income = ProductCostPrice * SoldProduct;
            Budget += Income;
        }
        else if (FullStock <= SoldProduct)
        {
            SatilaBilmeyenProduct = SoldProduct - FullStock;
            EmptyStock += FullStock;
            SoldProduct = FullStock;
            FullStock = 0;
            Income = SoldProduct * ProductCostPrice;
            Budget += Income;
            Console.WriteLine("Stock Yoxdur!!!!!");
        }
        Console.WriteLine($"Bos yer {EmptyStock} Dolu Yer {FullStock}  Satila bilmeyen Erzaq: {SatilaBilmeyenProduct} Gelir {Income} Budce {Budget}");
    }

    public void AddProduct(int AddingProduct)
    {
        if (EmptyStock > AddingProduct)
        {
            FullStock += AddingProduct;
            EmptyStock -= AddingProduct;
            Outcome = ProductCostPrice * AddingProduct;
            Budget -= Outcome;
        }
        else if (EmptyStock <= AddingProduct)
        {
            QebulEdilmeyenProduct = AddingProduct - EmptyStock;
            FullStock += EmptyStock;
            AddingProduct = EmptyStock;
            EmptyStock = 0;
            Outcome = AddingProduct * ProductCostPrice;
            Budget -= Outcome;
            Console.WriteLine("Bos yer Yoxdur!!!!!");
        }
        Console.WriteLine($"Bos yer {EmptyStock} Dolu Yer {FullStock}  Qebul  edile bilmeyen Erzaq: {QebulEdilmeyenProduct} Xerc {Outcome} Budce {Budget}");
    }
}

