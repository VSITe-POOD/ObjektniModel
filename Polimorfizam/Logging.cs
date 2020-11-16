using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    abstract class Logging
    {
        public abstract void Log(string text);
    }


    class ConsoleLogger : Logging
    {
        public override void Log(string text)
        {
            Console.WriteLine(text);
        }
    }

    class FileLogger : Logging
    {
        public override void Log(string text)
        {
            writer.WriteLine(text);
            writer.Flush();
        }

        StreamWriter writer = new StreamWriter("Log.txt");
    }

    class CompositeLogger : Logging
    {
        public void AddLogger(Logging log)
        {
            loggers.Add(log);
        }
        public override void Log(string text)
        {
            foreach(var logger in loggers)
            {
                logger.Log(text);
            }
        }

        List<Logging> loggers = new List<Logging>();
    }

}
