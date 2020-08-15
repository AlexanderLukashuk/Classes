using System;

namespace ClassesPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            Money cash = new Money{ denominationOfTheNote = 1000, numberOfNotes = 15 };
            cash.GetInfo();
            cash.Buy(4000);
            cash.Buy(40000);
            cash.AllMoneyPurchase(2000);
            cash.DenominationOfTheNote = 2000;
            cash.NumberOfNotes = 3;
            Console.WriteLine($"Denomination of the note: {cash.DenominationOfTheNote}");
            Console.WriteLine($"Number of notes: {cash.NumberOfNotes}");
            Console.WriteLine($"Amount of money = {cash.AmountOfMoney}");
        }
    }
}
