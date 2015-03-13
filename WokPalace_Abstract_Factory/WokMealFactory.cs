using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokPalace.Client;
using WokPalace.Products;

namespace WokPalace.WokPalace_Abstract_Factory
{
    class WokMealFactory : Kitchen
    {

        public override Meal createMeal(String type)
        {

            if (type == "fizz")
            {
                return new FizzWokMeal();
            }

            if (type == "ali")
            {
                return new AliWokMeal();
            }

            if (type == "quin")
            {
                return new QuinWokMeal();
            }
            else
            {
                return new AliWokMeal();
            }
        }
       
    
    }
}
