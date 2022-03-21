﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class StoryTeller
    {
        private IFormatWriter writer;
        public StoryTeller(IFormatWriter writer)
        {
            this.writer = writer;
        }

        public void WriteParagraph(string text)
        {
            this.writer.WriteParagraph(text);
        }

        public void WriteHeading1(string caption)
        {
            this.writer.WriteHeading1(caption);
        }

        public void WriteHeading2(string caption)
        {
            this.writer.WriteHeading2(caption);
        }
    }
}
