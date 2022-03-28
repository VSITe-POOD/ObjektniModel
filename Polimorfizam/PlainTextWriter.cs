using System;

namespace Polimorfizam
{
    class PlainTextWriter : IFormatWriter
    {

        public void WriteParagraph(string text)
        {
            Console.WriteLine(text);

        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine(caption);

        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine(caption);

        }
    }
}
