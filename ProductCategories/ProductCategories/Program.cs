using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var categoryFactory = new CategoryFactory();

            var fruit = categoryFactory.CreateCategory(CategoryType.Fruit);

            fruit.SelectCategory();

            Console.ReadKey();
        }
    }
}
