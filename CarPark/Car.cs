using System;

namespace CarPark
{
    public partial class Car
    {
        public static int numberOfCars;
        public static string manufacturer;
        private string brand;
        private string model;
        private string color;
        private int speed;
        private int productionYear;
        private int price;
        public void GetInfo()
        {
            Console.WriteLine($"Brand: {brand}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Manufacturer: {manufacturer}");
            Console.WriteLine($"Production year: {productionYear}");
            Console.WriteLine($"Price: {price}");
        }

        public void BuyCar()
        {
            Console.WriteLine("This car costs: {price}");
            Console.WriteLine("Thanks for purchase");
        }

        public void ChangeColor(string newColor)
        {
            color = newColor;
        }
        public void ChangePrice(ref int newPrice)
        {
            price = newPrice;
        }

        public void IncreaseTheValue(ref int price)
        {
            this.price += price;
        }

        public Car()
        {
            brand = "not know";
            model = "not know";
            color = "black";
            speed = 200;
            productionYear = 1989;
            price = 0;
        }

        public Car(string brand, string model, string color, int speed, int productionYear, int price)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            this.speed = speed;
            this.productionYear = productionYear;
            this.price = price;
        }

        static Car()
        {
            numberOfCars = 0;
            manufacturer = "Bill Gates";
        }

        partial void TestCar();

    }
}