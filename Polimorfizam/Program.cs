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
            Console.WriteLine("Želite li log u (D)atoteku ili na (E)kran ili (O)ba?");
            var izbor = Console.ReadLine().ToUpper();
            switch (izbor[0])
            {
                case 'E':
                    { 
                        logger = new ConsoleLog();
                        break;
                    }
                case 'D':
                    {
                        logger = new FileLog();
                        break;
                    }
                case 'O':
                    {
                        logger = new CompositeLogger();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nope");
                        break;
                    }
            }
            logger.Output("Start in main");
            Metoda1(1);
            Metoda1(2);
            logger.Output("End in main");
        }
        private static void Metoda1(int a)
        {
            logger.Output("Start in Metoda1");
            if (a % 2 == 0)
            {
                MetodaParna();
                return;
            }
            MetodaNeparna();
        }
        private static void MetodaParna()
        {
            logger.Output("Start in Parna");
        }
        private static void MetodaNeparna()
        {
            logger.Output("Start in Neparna");
        }
        static Log logger;
    }
}
