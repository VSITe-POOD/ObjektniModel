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
            //logger = new ConsoleLogger();
            //logger = new FileLogger();
            logger = new CompositeLogger();
            ((CompositeLogger)logger).AddLogger(new ConsoleLogger());
            ((CompositeLogger)logger).AddLogger(new FileLogger());
            int a = 5;
            Method1(a);

            a = -1;
            Method1(a);
        }
        static void Method1(int a)
        {
            logger.Log("I am in Method1");
            if (a > 0)
            {
                Method2();
            }
            else
            {
                Method3();
            }
            logger.Log("I am leaving Method1");

        }
        static void Method2()
        {
            logger.Log("I am in Method2");
        }
        static void Method3()
        {
            logger.Log("I am in Method3");
        }

        static Logging logger;
    }
}
