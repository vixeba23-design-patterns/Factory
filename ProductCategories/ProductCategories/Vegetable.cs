using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories
{
    public class Vegetable : Category
    {
        public override void SelectCategory()
        {
            Console.WriteLine("Vegetable Selected");
        }
    }
}
