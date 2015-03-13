using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace.Products
{
    class FizzWrapMeal : Meal
    {
        public override void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Fizz Wrap");
        }

        public override void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Fizz Wrap");
        }

        public override int calculatePrice()
        {
            return 5;
        }
    }
}
