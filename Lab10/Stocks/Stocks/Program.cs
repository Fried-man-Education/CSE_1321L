/*
    Class:	    CSE 1321L
    Section:    16  
    Term:		Fall 2019 
    Instructor:	Rehnuma Afrin
    Name:		Andrew Friedman   
    Lab#:		10
*/

using System;

namespace Stocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock Google = new Stock("Google", "GOG");
            Google.setClosingPrice(134.67);
            Google.setCurrentPrice(131.98);

            Stock Microsoft = new Stock("Microsoft", "MSF");
            Microsoft.setClosingPrice(156.52);
            Microsoft.setCurrentPrice(161.22);

            Console.WriteLine(Google.getName() + " stock:");
            Console.WriteLine("Symbol: " + Google.getSymbol());
            Console.WriteLine("Closing price: " + Google.previousClosingPrice);
            Console.WriteLine("Current price: " + Google.currentPrice);
            Console.WriteLine("Change percent: " + Google.getChangePercent() + "%");
            Google.toString();
            Console.WriteLine();

            Console.WriteLine(Microsoft.getName() + " stock:");
            Console.WriteLine("Symbol: " + Microsoft.getSymbol());
            Console.WriteLine("Closing price: " + Microsoft.previousClosingPrice);
            Console.WriteLine("Current price: " + Microsoft.currentPrice);
            Console.WriteLine("Change percent: " + Microsoft.getChangePercent() + "%");
            Microsoft.toString();
        }
    }

    class Stock
    {
        string Symbol;
        string Name;
        public double previousClosingPrice;
        public double currentPrice;
        public Stock(string newName, string newSymbol)
        {
            Name = newName;
            Symbol = newSymbol;
        }
        public string getName()
        {
            return Name;
        }
        public string getSymbol()
        {
            return Symbol;
        }
        public void setClosingPrice(double currentClosingPrice)
        {
            previousClosingPrice = currentClosingPrice;
        }
        public void setCurrentPrice(double newPrice)
        {
            currentPrice = newPrice;
        }
        public double getChangePercent()
        {
            return (currentPrice - previousClosingPrice) / currentPrice * 100;
        }
        public void toString()
        {
            Console.WriteLine(Name + " stock closing price is $" + currentPrice);
        }
    }
}