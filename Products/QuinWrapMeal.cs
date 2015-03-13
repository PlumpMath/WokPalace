using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace.Products
{
    class QuinWrapMeal : Meal
    {
        public override void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Quin Wrap");
        }

        public override void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Quin Wrap");
        }

        public override int calculatePrice()
        {
            return 5;
        }
    }
}
