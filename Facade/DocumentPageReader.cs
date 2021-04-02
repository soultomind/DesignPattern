using System;

namespace Facade
{
    internal class DocumentPageReader
    {
        private DocumentPageHeaderReader documentPageHeaderReader;
        private DocumentPageBodyReader documentPageBodyReader;
        private DocumentPageFooterReader documentPageFooterReader;

        public DocumentPageReader()
        {
            documentPageHeaderReader = new DocumentPageHeaderReader();
            documentPageBodyReader = new DocumentPageBodyReader();
            documentPageFooterReader = new DocumentPageFooterReader();
        }

        public void Read(Document document, DocumentPage documentPage)
        {
            Console.WriteLine(documentPage.Number + ". 페이지를 읽습니다.");
            documentPageHeaderReader.Read(documentPage);
            documentPageBodyReader.Read(documentPage);
            documentPageFooterReader.Read(documentPage);
        }
    }
}
