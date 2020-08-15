using System;
using System.Collections;

namespace CarPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            string brand;
            string model;
            string color;
            string input;
            int speed;
            int prodctionYear;
            int price;
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write("Enter brand: ");
                brand = Console.ReadLine();
                Console.Write("Enter model: ");
                model = Console.ReadLine();
                Console.Write("Enter color: ");
                color = Console.ReadLine();
                Console.Write("Enter speed: ");
                input = Console.ReadLine();
                speed = int.Parse(input);
                Console.Write("Enter production year: ");
                input = Console.ReadLine();
                prodctionYear = int.Parse(input);
                Console.Write("Enter price: ");
                input = Console.ReadLine();
                price = int.Parse(input);
                cars[i] = new Car(brand, model, color, speed, prodctionYear, price);
            }
        }
    }
}
