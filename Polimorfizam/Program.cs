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
            Console.WriteLine("U (D)atoteku, na (E)kran ili (O)ba");
            var izbor = Console.ReadKey();
            switch(izbor.KeyChar)
            {
                case 'e':
                    logger = new ConsoleLog();
                    break;
                case 'd':
                    logger = new FileLog();
                    break;
                case 'o':
                    logger = new CompositeLogger();
                    break;
            }

            logger.Output("Start in main");
            metoda1(1);
            metoda1(4);
            logger.Output("End in main");
            Console.ReadKey();
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

        static bool toFile;
        static Log logger = new ConsoleLog();
    }
}
