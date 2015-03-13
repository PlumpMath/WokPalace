using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokPalace.Client;
using WokPalace.Products;

namespace WokPalace.WokPalace_Abstract_Factory
{
    class SushiMealFactory : Kitchen
    {

        public override Meal createMeal(String type)
        {

            if (type == "fizz")
            {
                return new FizzSushiMeal();
            }

            if (type == "ali")
            {
                return new AliSushiMeal();
            }

            if (type == "quin")
            {
                return new QuinSushiMeal();
            }
            else
            {
                return new AliSushiMeal();
            }
        }

    }
}
