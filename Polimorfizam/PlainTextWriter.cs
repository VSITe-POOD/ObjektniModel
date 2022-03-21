namespace Polimorfizam
{
    class PlainTextWriter : IFormatWriter
    {

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
