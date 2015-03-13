using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokPalace.Products;
using WokPalace.WokPalace_Abstract_Factory;

namespace WokPalace.Client
{
    public abstract class Kitchen
    {

        Meal meal;

        public Meal orderMeal(String type){

        meal = createMeal(type);
        meal.prepare();
        meal.deliver();
            
        return meal;

        }

        public abstract Meal createMeal(String type);

     }
       
}


