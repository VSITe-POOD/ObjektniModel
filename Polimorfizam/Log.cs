using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam {
    abstract class Log {
        public abstract void Output(string message);
    }

    class ConsoleLog : Log {
        public override void Output(string message) {
            Console.WriteLine(message);
        }
    }

    class FileLog : Log {

        public FileLog() {
            writer.AutoFlush = true;
        }
        public override void Output(string message) {
            writer.WriteLine(message);
        }

        StreamWriter writer = new StreamWriter("Log.txt");
    }

    class CompositeLog : Log {
        public CompositeLog() {
            loggers.Add(new FileLog());
            loggers.Add(new ConsoleLog());
        }
        public void AddLogger(Log logger) {
            loggers.Add(logger);
        }
        public override void Output(string message) {
            foreach(var logger in loggers) {
                logger.Output(message);
            }
        }

        List<Log> loggers = new List<Log>();
    }
}
