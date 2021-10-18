using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    abstract class Log
    {
        public abstract void OutputString(string message);
    }

    class ConsoleLog : Log
    {
        public override void OutputString(string message)
        {
            Console.WriteLine(message);
        }
    }

    class FileLogger : Log
    {
        public FileLogger()
        {
            writer.AutoFlush = true;
        }
        public override void OutputString(string message)
        {
            writer.WriteLine(message);
        }

        StreamWriter writer = new StreamWriter("Log.txt");
    }

    class CompositeLogger : Log
    {
        List<Log>loggers = new List<Log>();

        public CompositeLogger()
        {
            loggers.Add(new ConsoleLog());
            loggers.Add(new FileLogger());
        }

        public void AddLogger(Log logger)
        {
            loggers.Add(logger);
        }

        public override void OutputString(string message)
        {
            foreach(Log logger in loggers)
            {
                logger.OutputString(message);
            }   
        }
    }
}
