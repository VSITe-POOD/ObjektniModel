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
            Console.WriteLine("U datoteku (D), na ekran (E) ili oboje (O)?");
            var outputStream = Console.ReadKey();
            Console.WriteLine("\n");
            switch (outputStream.KeyChar)
            {
                case 'd':
                    logger = new FileLogger();
                    break;
                case 'e':
                    logger = new ConsoleLog();
                    break;
                case 'o':
                    logger = new CompositeLogger();
                    break;
                default:
                    break;
            }
            logger.OutputString("Start in Main()");
            metoda1(1);
            metoda1(16);
            logger.OutputString("End in Main()");
            Console.ReadKey();
        }

        private static void metoda1(int a)
        {
            logger.OutputString("Start in metoda1()");
            if (a % 2 == 0) metodaParna();
            else metodaNeparna();
        }

        private static void metodaParna()
        {
            logger.OutputString("Start in metodaParna");
        }

        private static void metodaNeparna()
        {
            logger.OutputString("Start in metodaNeparna");
        }

        static Log logger = new ConsoleLog();
    }
}
