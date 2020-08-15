using System;

namespace ClassesPractical
{
    public class Money
    {
        public int denominationOfTheNote;
        public int numberOfNotes;

        public Money()
        {
            denominationOfTheNote = 0;
            numberOfNotes = 0;
        }
        public Money(int denominationOfTheNote, int numberOfNotes)
        {
            this.denominationOfTheNote = denominationOfTheNote;
            this.numberOfNotes = numberOfNotes;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Denomination of the note: {denominationOfTheNote}");
            Console.WriteLine($"Number of notes: {numberOfNotes}");
        }

        public void Buy(int price)
        {
            int moneyAmount = denominationOfTheNote * numberOfNotes;
            if (moneyAmount >= price)
            {
                moneyAmount -= price;
                numberOfNotes = moneyAmount / denominationOfTheNote;
                Console.WriteLine("Thanks for purchase");
            }
            else
            {
                Console.WriteLine("Sorry. You do not have enough funds for purchase");
            }
        }

        public void AllMoneyPurchase(int price)
        {
            int moneyAmount = denominationOfTheNote * numberOfNotes;
            int quantityOfProduct = 0;
            while ((moneyAmount - price) > 0)
            {
                quantityOfProduct++;
                moneyAmount -= price;
            }
        }

        public int DenominationOfTheNote
        {
            get
            {
                return denominationOfTheNote;
            }
            set
            {
                denominationOfTheNote = value;
            }
        }

        public int NumberOfNotes
        {
            get
            {
                return numberOfNotes;
            }
            set
            {
                numberOfNotes = value;
            }
        }

        public int AmountOfMoney
        {
            get
            {
                return denominationOfTheNote * numberOfNotes;
            }
        }
    }
}