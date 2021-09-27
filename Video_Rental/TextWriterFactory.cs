using System;
using System.IO;

namespace Video_Rental
{
    public static class TextWriterFactory
    {
        static TextWriter textWriter;
        internal static TextWriter GetTextWriter(string path)
        {
            if (textWriter != null)
                return textWriter;
            return new StreamWriter(path, true);
        }

        public static void SetTextWriter(TextWriter mockWriter)
        {
            textWriter = mockWriter;
        }
    }
}