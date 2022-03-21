using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class JsonWriter : IFormatWriter
    {
        public void WriteParagraph(string text)
        {
            Console.WriteLine(" \"paragraf\": " + text + " \n}");
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine("{\n \"heading1\": " + caption + ",");
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine(" \"heading2\": " + caption + ",");
        }
    }
}
