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
            Console.WriteLine("Želite li log u (D)atoteku ili (E)kran ili (O)ba");
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
                        logger = new CompositeLog();
                        break;
                    }
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

        static Log logger;
    }
}
