using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HerbalProduct product = new HerbalProduct(1, "Herbal Tea", 100, "Tea, Milk", DateTime.Now, DateTime.Now.AddDays(30));
            product.ShowDetails();
            Console.ReadKey();
        }
    }
}
