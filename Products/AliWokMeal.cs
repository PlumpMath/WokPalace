using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace.Products
{
    class AliWokMeal : Meal
    {
        public override void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Ali Wok");
        }

        public override void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Ali Wok");
        }

        public override int calculatePrice()
        {
            return 5;
        }
    }
}
