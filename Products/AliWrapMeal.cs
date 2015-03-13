using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace.Products
{
    class AliWrapMeal : Meal
    {

        public override void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Ali Wrap");
        }

        public override void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Ali Wrap");
        }

        public override int calculatePrice()
        {
            return 5;
        }
    
    }
}
