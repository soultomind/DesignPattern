using System;
using System.Text;

namespace Facade
{
    public class DocumentManager
    {
        private DocumentPageReader documentPageReader;
        private DocumentPageWriter documentPageWriter;
        public DocumentManager()
        {
            documentPageReader = new DocumentPageReader();
            documentPageWriter = new DocumentPageWriter();
        }

        public DocumentPage GetPage(Document document, int index)
        {
            if (document.Pages.Count > index && index > -1)
            {
                return document.Pages[index];
            }
            return null;
        }

        public void SetPage(Document document, int index, string header, string body, string footer)
        {
            DocumentPage documentPage = GetPage(document, index);
            if (documentPage != null)
            {
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
            StringBuilder builder = new StringBuilder(1024);
            builder.Append("Title=" + document.Title).AppendLine();
            for (int i = 0; i < document.Pages.Count; i++)
            {
                builder.AppendFormat("{0}. Page======================", i + 1).AppendLine();
                DocumentPage documentPage = document.Pages[i];
                documentPageWriter.Write(documentPage, builder);
                builder.AppendLine("============================");
            }

            System.IO.File.WriteAllText(path, builder.ToString());
        }
    }
}
