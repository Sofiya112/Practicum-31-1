using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_31_1
{
    class Newspaper : PrintedProducts //Газета
    {
        private int numberSheets; //Кол-во листов
        private int circulation; //Тираж
        private double price; //Цена

        public int NumberSheets
        {
            get { return numberSheets; }
            set { numberSheets = value; }
        }
        public int Circulation
        {
            get { return circulation; }
            set { circulation = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Newspaper()
        {
            
        }
        public Newspaper(string name, int circulation, double price, int numberSheets) : base (name)
        {
            NumberSheets = numberSheets;
            Circulation = circulation;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine($"Газета: {Name}");
            Console.WriteLine($"Цена: {price}");
            Console.WriteLine($"Тираж: {circulation}");
            Console.WriteLine($"Кол-во листов: {numberSheets}");
        }
        public override void Cost()
        {
            // Допустим, стоимость одной газеты = количество листов * 1.5
            double pricePerSheet = 1.5;
            double totalCost = numberSheets * pricePerSheet;
            Console.WriteLine($"Стоимость газеты: {totalCost} USD");
        }



    }
}
