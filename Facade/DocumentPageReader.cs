using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DocumentPageReader
    {
        private HeaderReader headerReader;
        private BodyReader bodyReader;
        private FooterReader footerReader;

        public DocumentPageReader()
        {
            headerReader = new HeaderReader();
            bodyReader = new BodyReader();
            footerReader = new FooterReader();
        }

        public void Read(Document document, DocumentPage documentPage)
        {
            Console.WriteLine(documentPage.Number + ". 페이지를 읽습니다.");
            headerReader.Read(documentPage);
            bodyReader.Read(documentPage);
            footerReader.Read(documentPage);
        }
    }
}
