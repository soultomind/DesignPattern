using System;
using System.Text;

namespace Facade
{
    internal class DocumentPageWriter
    {
        private DocumentPageHeaderWriter documentPageHeaderWriter;
        private DocumentPageBodyWriter documentPageBodyWriter;
        private DocumentPageFooterWriter documentPageFooterWriter;

        public DocumentPageWriter()
        {
            documentPageHeaderWriter = new DocumentPageHeaderWriter();
            documentPageBodyWriter = new DocumentPageBodyWriter();
            documentPageFooterWriter = new DocumentPageFooterWriter();
        }

        internal void Write(DocumentPage documentPage, StringBuilder builder)
        {
            documentPageHeaderWriter.Write(documentPage, builder);
            documentPageBodyWriter.Write(documentPage, builder);
            documentPageFooterWriter.Write(documentPage, builder);
        }
    }
}
