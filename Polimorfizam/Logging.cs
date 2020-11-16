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
        public abstract void Log(String Text);
    }
    class ConsoleLogger : Logging
    {
        public override void Log(string Text)
        {
            Console.WriteLine(Text);
        }
    }
    class FileLogger : Logging
    {
        public override void Log(string Text)
        {
            writer.WriteLine(Text);
            writer.Flush();
        }
        StreamWriter writer = new StreamWriter("Log.txt");
    }
    class CompositeLogger : Logging
    {
        public override void Log(string Text)
        {
           foreach(var logger in loggers)
            {
                logger.Log(Text);
            }
        }
        public void AddLogger(Logging log)
        {
            loggers.Add(log);
        }
        List<Logging> loggers = new List<Logging>();
    }
}
