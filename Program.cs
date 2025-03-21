using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_31_1
{
    class Program
    {
        static void Main(string[] args)
        {






            List<Magazine> magazines = new List<Magazine>(); // Список журналов
            List<Newspaper> newspapers = new List<Newspaper>(); // Список газет

            // Пример заранее созданного журнала
            magazines.Add(new Magazine("Маркер", 400, 600.1));

            // Пример заранее созданной газеты
            newspapers.Add(new Newspaper("Аура", 60, 50, 5));

            // Ввод данных для нового журнала
            Console.Write("Введите название журнала: ");
            string magName = Console.ReadLine();

            Console.Write("Введите тираж журнала: ");
            int magCirculation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цену одного экземпляра журнала: ");
            double magPrice = Convert.ToDouble(Console.ReadLine());

            magazines.Add(new Magazine(magName, magCirculation, magPrice)); // Создание объекта

            // Ввод данных для новой газеты
            Console.Write("Введите название газеты: ");
            string newsName = Console.ReadLine();

            Console.Write("Введите тираж газеты: ");
            int newsCirculation = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите цену одного экземпляра газеты: ");
            double newsPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество листов в газете: ");
            int newsSheets = Convert.ToInt32(Console.ReadLine());

            newspapers.Add(new Newspaper(newsName, newsCirculation, newsPrice, newsSheets)); // Создание объекта

            Console.WriteLine("\n==== ЖУРНАЛЫ ====");
            foreach (Magazine mag in magazines)
            {
                mag.Print();
                mag.Cost();
                Console.WriteLine();
            }

            Console.WriteLine("==== ГАЗЕТЫ ====");
            foreach (Newspaper np in newspapers)
            {
                np.Print();
                np.Cost();
                Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}    
