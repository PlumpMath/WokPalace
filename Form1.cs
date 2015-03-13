using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokPalace.Client;
using WokPalace.WokPalace_Abstract_Factory;

namespace WokPalace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Kitchen wokPalace = new WokMealFactory();

            wokPalace.orderMeal("quin");

            wokPalace = new SushiMealFactory();

            wokPalace.orderMeal("alistar");

        }
    }
}
