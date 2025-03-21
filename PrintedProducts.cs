using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_31_1
{
    abstract class PrintedProducts
    {
        private string name;
        public PrintedProducts() //Конструктор без параметров
        {

        }
        public PrintedProducts(string name)
        {
            Name = name;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void Print();

        public abstract void Cost();
        


    }
}
