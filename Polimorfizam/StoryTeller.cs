﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            writer.WriteParagraph(text);
        }

        public void WriteHeading1(string caption)
        {
            writer.WriteHeading1(caption);
        }

        public void WriteHeading2(string caption)
        {
            writer.WriteHeading2(caption);
        }
    }
}
