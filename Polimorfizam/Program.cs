using System;
using System.Text;

namespace Polimorfizam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TODO: DZ napravi json writer
            //var writer = new PlainTextWriter();
            var writer = new HtmlWriter();
            StoryTeller st = new StoryTeller(writer);
            st.WriteHeading1("Priče iz davnine");
            st.WriteHeading2("Šuma Striborova");
            st.WriteParagraph("Zašao neki momak u šumu Striborovu, a nije znao da je ono šuma začarana i da se u njoj svakojaka čuda zbivaju.");

            Console.ReadKey(false);
        }
    }
}
