using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class StoryTeller
    {
        // konstruktor kojem ćemo prosijediti writter
        // ctor tab tab
        public StoryTeller(IFormatWritter writter) // u konstruktoru prosljeđujemo konkretnu klasu koja implementira interface IFormatWritter
        {
            this.writter = writter;
        }
        IFormatWritter writter;

        // StroyTeller se više ne mijenja
        //WriteParagraph, WriteHeading1 i WriteHeading2 su polimorfne
        //kroz pzive istoimenih metoda na različitim lkasama dobivati različite implementacije
        public void WriteParagraph(string text)
        {
            writter.WriteParagraph(text);
        }

        public void WriteHeading1(string caption)
        {
            writter.WriteHeading1(caption);
            //Console.WriteLine(new string('=', caption.Length));
        }

        public void WriteHeading2(string caption)
        {
            writter.WriteHeading2(caption);
            //Console.WriteLine(new string('-', caption.Length));
        }
    }
}
