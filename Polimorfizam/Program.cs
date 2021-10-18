using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class Program
    {
        static void Main(string[] args)
        {
            logger.Output("Start in main");
            metoda1(1);
            metoda1(4);
            logger.Output("End in main");
        }

        private static void metoda1(int a)
        {
            logger.Output("Start in metoda1");
            if (a % 2 != 0)
                metodaNeparna();
            else
                metodaParna();
        }

        private static void metodaParna()
        {
            logger.Output("Start in metodaParna");
        }

        private static void metodaNeparna()
        {
            logger.Output("Start in metodaNeparna");
        }

        static Log logger = new Log();
    }
}
