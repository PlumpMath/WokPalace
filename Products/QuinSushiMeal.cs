using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace.Products
{
    class QuinSushiMeal : Meal
    {
        public override void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Quin sushi");
        }

        public override void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Quin Sushi");
        }

        public override int calculatePrice()
        {
            return 5;
        }
    }
}
