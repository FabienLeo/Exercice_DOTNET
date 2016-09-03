using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuLibrary;

namespace Menu_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var MonMenu = new Menu();// creation objet

            string BoissonTest0 = MonMenu.boisson[1];


            string BoissonTest = MonMenu[1];

            Console.WriteLine(BoissonTest0 + " +++++ " +BoissonTest);
            Console.ReadKey();
        }
    }
}
