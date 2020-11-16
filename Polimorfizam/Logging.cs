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
        public abstract void Log(string v);
    }

    class ConsoleLogger : Logging
    {
        public override void Log(string v)
        {
            Console.WriteLine(v);
        }
    }

    class FileLogger : Logging
    {
        public override void Log(string v)
        {
            writer.WriteLine(v);
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
        public override void Log(string v)
        {
            foreach (var logger in loggers)
            {
                logger.Log(v);
            }
        }

        List<Logging> loggers = new List<Logging>();
    }
}
