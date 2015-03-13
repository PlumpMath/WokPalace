using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace.Products
{
    class QuinWokMeal : Meal
    {
        public override void prepare()
        {
            System.Diagnostics.Debug.WriteLine("Preparing Quin Wok");
        }

        public override void deliver()
        {
            System.Diagnostics.Debug.WriteLine("Delivering Quin Wok");
        }

        public override int calculatePrice()
        {
            return 5;
        }
    }
}
