﻿namespace StockInventoryManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stock Account Management");

            string path = "C:\\Users\\91788\\source\\repos\\StockInventoryManagement\\StockInventoryManagement\\Stocks.json";
            FetchStocks fetchStock = new FetchStocks();
            StockDetails data = fetchStock.Read(path);

            Console.WriteLine("\nSTOCK VALUE: ");

            for (int i = 0; i < data.stocks.Count; i++)
            {
                Console.WriteLine(data.stocks[i].StockName);
                Console.WriteLine("shares: " + data.stocks[i].shares);
                Console.WriteLine("price: " + data.stocks[i].Price);

                int TotalValue = data.stocks[i].shares * data.stocks[i].Price;
                Console.WriteLine("\nThe Total Value of {0} for {1} shares is: {2} ", data.stocks[i].StockName, data.stocks[i].shares, TotalValue);
                Console.WriteLine("-------------------------------");
            
            }
        }
    }
}