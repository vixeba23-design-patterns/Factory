using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories
{
    public abstract class Category
    {
        private int Id { get; }
        private string Name { get; set; }
        private string Description { get; set; }

        public abstract void SelectCategory();
        

    }
}
