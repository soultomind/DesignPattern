using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DocumentManager
    {
        private DocumentPageReader documentPageReader;

        public DocumentManager()
        {
            documentPageReader = new DocumentPageReader();
        }

        public void SetPage(Document document, int index, string header, string body, string footer)
        {
            if (document.Pages.Count > index && index > -1)
            {
                DocumentPage documentPage = document.Pages[index];
                documentPage.Header = header;
                documentPage.Body = body;
                documentPage.Footer = footer;
            }
        }

        public void Read(Document document)
        {
            Console.WriteLine("==============================");
            ReadTitme(document);
            ReadPage(document);
            Console.WriteLine("==============================");
        }

        private void ReadTitme(Document document)
        {
            Console.WriteLine("타이틀 : " + document.Title);
        }

        private void ReadPage(Document document)
        {
            for (int i = 0; i < document.Pages.Count; i++)
            {
                DocumentPage documentPage = document.Pages[i];
                documentPageReader.Read(document, documentPage);
            }
        }

        public void Write(Document document, string path)
        {
            StringBuilder builder = new StringBuilder(512);
            builder.Append("Title=" + document.Title).AppendLine();
            for (int i = 0; i < document.Pages.Count; i++)
            {
                DocumentPage documentPage = document.Pages[i];
                documentPage.Write(builder);
            }

            System.IO.File.WriteAllText(path, builder.ToString());
        }
    }
}
