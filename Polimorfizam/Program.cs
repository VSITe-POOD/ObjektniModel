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
        static Log logger = new Log();
    }
}
