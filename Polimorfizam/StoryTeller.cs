using System;

namespace Polimorfizam
{
    class StoryTeller
    {
        IFormatWriter writer;

        public StoryTeller(IFormatWriter writer)
        {
            this.writer = writer;
        }

        public void WriteParagraph(string text)
        {
            Console.WriteLine(text);
        }

        public void WriteHeading1(string caption)
        {
            Console.WriteLine(caption);
            Console.WriteLine(new string('=', caption.Length));
        }

        public void WriteHeading2(string caption)
        {
            Console.WriteLine(caption);
            Console.WriteLine(new string('-', caption.Length));
        }
    }
}
