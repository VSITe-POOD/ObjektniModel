using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    interface IFormatWriter
    {
        void WriteParagraph(string text);

        void WriteHeading1(string caption);

        void WriteHeading2(string caption);

    }
}
