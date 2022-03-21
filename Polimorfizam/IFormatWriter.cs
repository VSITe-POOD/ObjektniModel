namespace Polimorfizam
{
    internal interface IFormatWriter
    {
        void WriteParagraph(string text);

        void WriteHeading1(string caption);

        void WriteHeading2(string caption);
    }
}