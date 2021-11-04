using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prakt3
{
    class Product
    {   //Змінні
        private string Name = "Невідома Назва";
        private ushort Price = 0;
        private string Cost = "Невідома";//назва валюти
        private ushort Quanity = 0;
        private string Producer = "Невідомий";
        private double Weight = 0;

        private bool f;
        //КОНСТРУКТОРИ
        public Product() { 
            
        }
        public Product(string Name,ushort Price,string Cost,ushort Quanity,string Producer,double Weight)
        {
            this.Name=Name;
            this.Price = Price;
            this.Cost = Cost;
            this.Quanity = Quanity;
            this.Producer = Producer;
            this.Weight = Weight;
        }
        public Product(string Name, ushort Price, string Cost, ushort Quanity, string Producer)
        {
            this.Name = Name;
            this.Price = Price;
            this.Cost = Cost;
            this.Quanity = Quanity;
            this.Producer = Producer;
        }
        public Product(string Name, ushort Price, string Cost, ushort Quanity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Cost = Cost;
            this.Quanity = Quanity;
        }
        //Методи ОТРИМАННЯ(GET)
        public void GetInfo() {
            Console.WriteLine("Назва товару:\t"+Name);
            Console.WriteLine("Ціна:\t\t" + Price);
            Console.WriteLine("Валюта:\t\t" + Cost);
            Console.WriteLine("Кількість:\t" + Quanity);
            Console.WriteLine("Виробник:\t" + Producer);
            Console.WriteLine("Вага(кг):\t" + Weight+"\n");
        }
        public void GetInfoName() {
            Console.WriteLine("Назва товару:\t" + Name);
        }
        public void GetInfoPrice()
        {
            Console.WriteLine("Ціна:\t\t" + Price);
        }
        public void GetInfoCost()
        {
            Console.WriteLine("Валюта:\t\t" + Cost);
        }
        public void GetInfoQuanity()
        {
            Console.WriteLine("Кількість:\t" + Quanity);
        }
        public void GetInfoProducer()
        {
            Console.WriteLine("Виробник:\t" + Producer);
        }
        public void GetInfoWeight()
        {
            Console.WriteLine("Вага(кг):\t" + Weight + "\n");
        }
        public void GetTotalPrice() {
            Console.WriteLine("Ціна:\t\t"+Price+"\nКількість:\t"+ Quanity+"\nЗагальна сума:\t"+Price*Quanity);
        }
        public void GetTotalWeight() {
            Console.WriteLine("Вага:\t\t" + Weight + "\nКількість:\t" + Quanity + "\nЗагальна вага:\t" + Weight * Quanity);
        }
        //Методи ВВЕДЕННЯ/змінення(SET)
        public void SetInfo() {
            Console.Write("Введіть назву товару: ");
            Name=Console.ReadLine();
           // bool f;
            do
            {
                Console.Write("Ціна: ");
                f = ushort.TryParse(Console.ReadLine(), out Price);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
            } while (!f);
            Console.Write("Валюта: ");
            Cost = Console.ReadLine();
            do
            {
                Console.Write("Кількість: ");
                f = ushort.TryParse(Console.ReadLine(), out Quanity);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
            } while (!f);
            Console.Write("Виробник: ");
            Producer = Console.ReadLine();
            do
            {
                Console.Write("Вага(кг): ");
                f = double.TryParse(Console.ReadLine(), out Weight);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
            } while (!f);
            Console.WriteLine();
        }//Ввід всієї інформації
        public void SetInfoName() {
            Console.Write("Введіть нову назву товару: ");
            Name = Console.ReadLine();
        }
        public void SetInfoPrice()
        {
            do
            {
                Console.Write("Нова ціна: ");
                f = ushort.TryParse(Console.ReadLine(), out Price);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
            } while (!f);
        }
        public void SetInfoCost() {
            Console.Write("Нова валюта: ");
            Cost = Console.ReadLine();
        }
        public void SetInfoQuanity() {
            do
            {
                Console.Write("Нова кількість: ");
                f = ushort.TryParse(Console.ReadLine(), out Quanity);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
            } while (!f);
        }
        public void SetInfoProducer() {
            Console.Write("Новий виробник: ");
            Producer = Console.ReadLine();
        }
        public void SetInfoWeight() {
            do
            {
                Console.Write("Нова вага(кг): ");
                f = double.TryParse(Console.ReadLine(), out Weight);
                if (f == false)
                {
                    Console.WriteLine("Помилка! Введіть ще раз");
                }
            } while (!f);
        }

        //&&&&&
        public int GetInfoPriceInt()
        {
            return Price;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Product apple = new Product("Яблуко",12,"Гривня",456,"ЯблукоІндастріс",0.2);
            apple.GetInfo();
            PrintProduct(apple);
            Product nomer2 = new Product();
            /*nomer2.SetInfo();
            nomer2.GetInfo();
            apple.GetTotalWeight();
            apple.GetTotalPrice();*/
            Product[] info = { apple, nomer2};

            //PrintProducts(info);

            SortProductsByPrice(info);
        }
        //Статичні методи
        private static void PrintProduct(Product a)
        {
            a.GetInfoName();
            Console.WriteLine();
        }
        private static void PrintProducts(Product []products)
        {
            for (int i = 0; i <products.Length; i++){
                products[i].GetInfoName();
            }
            Console.WriteLine();
        }
        private static void SortProductsByPrice(Product[] products) {
            int i = 0;
            products[i].GetInfoCost();
        }
    }
}
