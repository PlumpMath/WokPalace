using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WokPalace
{
    public abstract class Meal
    {

        public String name { get; set; }
        public Meat meat;
        public iSideDish sideDish;
        public iSauce sauce;
        public List<iVegtable> Vegetable; 

        public abstract void prepare();
        public abstract void deliver();
        public abstract int calculatePrice();
    
    }
}
