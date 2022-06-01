using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCategories
{
    public class CategoryFactory
    {

        public Category CreateCategory(CategoryType type)
        {
            switch (type)
            {
                case CategoryType.Fruit:
                    return new Fruit();
                case CategoryType.Vegetable:
                    return new Vegetable();
                case CategoryType.Bread:
                    return new Bread();
                default:
                    throw new Exception($"Category {type} is not handled");
            }
        }

    }
}
