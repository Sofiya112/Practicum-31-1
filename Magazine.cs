using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_31_1
{
    class Magazine : PrintedProducts
    {
        private int circulation; //Тираж
        private double price; //Цена


        public Magazine() //Конструтор без параметров
        {
            
        }
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="circulation"></param>
        /// <param name="price"></param>
        public Magazine(string name, int circulation, double price) : base(name) 
        {
            Circulation = circulation;
            Price = price;
        }
        /// <summary>
        /// Свойста для доступа к Circulation
        /// </summary>
        public int Circulation 
        {
            get { return circulation; }
            set { circulation = value; }
        }
        /// <summary>
        /// Свойства для доступа к Price
        /// </summary>
        public double Price 
        {
            get { return price; }
            set { price = value; }
        }
        /// <summary>
        /// Метод для вывода
        /// </summary>
        public override void Print()
        {
            Console.WriteLine($"Магазин: {Name}");
            Console.WriteLine($"Тираж: {circulation}");
            Console.WriteLine($"Цена: {price} USD");

        }

        /// <summary>
        /// Метод для вывода общей стоимости
        /// </summary>
        public override void Cost()
        {
            double totalCost = circulation * price;
            Console.WriteLine($"Общая стоимость: {totalCost} ");
        }



    }
}
