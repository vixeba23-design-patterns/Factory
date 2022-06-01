using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories
{
    public class Bread : Category
    {
        public override void SelectCategory()
        {
            Console.WriteLine("Breat Selected");
        }
    }
}
