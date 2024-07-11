namespace SuperMarketHesabat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperMarket superMarket = new SuperMarket();
            superMarket.NumOfMarket = 12;
            superMarket.TotalIncome = 0;
            Market market = new Market();  
            superMarket.AddMarket(market);
        }
    }
}
