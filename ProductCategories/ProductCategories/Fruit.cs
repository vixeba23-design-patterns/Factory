using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories
{
    internal class Fruit : Category
    {
        public override void SelectCategory()
        {
            Console.WriteLine("Fruit Selected");
        }
    }
}
