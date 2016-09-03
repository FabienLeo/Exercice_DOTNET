using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLibrary
{
    public class Menu
    {
        public string[] boisson = { "Coca", "biere", "Eau", "Limonade" };

     
        public string this[int index]
        {
            get { return this.boisson[index]; }
            //set { this.boisson[index] = value; }
        }


    }
}
