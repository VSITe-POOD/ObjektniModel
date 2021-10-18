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
            Console.WriteLine("U (D)atoteku, (E)kran ili (O)ba?");
            var izbor = Console.ReadKey();
            switch (izbor.KeyChar)
            {
                case 'e':
                    logger = new ConsoleLog();
                    break;
                case 'd':
                    logger = new FileLogger();
                    break;
                case 'o':
                    logger = new CompositeLogger();
                    break;
            }
            logger.Output("Start in Main");
            Metoda1(1);
            Metoda1(4);
            logger.Output("End in Main");

        }
        private static void Metoda1(int a)
        {
            logger.Output("Start in Metoda1");
            if (a % 2 != 0)
                MetodaNeparna();
            else
                MetodaParna();
        }
        private static void MetodaParna()
        {
            logger.Output("Start in MetodaParna");
        }
        private static void MetodaNeparna()
        {
            logger.Output("Start in MetodaNeparna");
        }

       
        static Log logger = new ConsoleLog();
    }
}
