using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokPalace.Products;

namespace WokPalace.WokPalace_Abstract_Factory
{
    class WrapMealFactory
    {

        public Meal createMeal(String type)
        {

            if (type == "fizz")
            {
                return new FizzWrapMeal();
            }

            if (type == "ali")
            {
                return new AliWrapMeal();
            }

            if (type == "quin")
            {
                return new QuinWrapMeal();
            }
            else
            {
                return new AliWrapMeal();
            }
        }
    
    }
}
