using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class JsonWritter : IFormatWritter
    {
        public void WriteParagraph(string text)
        {
            Console.WriteLine($"\t\"p\": \"{text}\"");
            Console.WriteLine("}");
        }
        public void WriteHeading1(string caption)
        {
            Console.WriteLine("{");
            Console.WriteLine($"\t\"h1\": \"{caption}\"");
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine($"\t\"h2\": \"{caption}\"");
        }
    }
}
