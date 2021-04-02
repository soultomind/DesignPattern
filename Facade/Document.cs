using System;
using System.Collections.Generic;

namespace Facade
{
    public class Document
    {
        private string title;

        private List<DocumentPage> pages;

        public Document(String title)
        {
            this.title = title;
            pages = new List<DocumentPage>();
        }

        public string Title
        {
            get { return title; }
        }

        public List<DocumentPage> Pages
        {
            get { return pages; }
        }

        public void addPage(string header, string body, string footer)
        {
            DocumentPage page = new DocumentPage(header, body, footer);
            int size = pages.Count;
            page.Number = size + 1;
            pages.Add(page);
        }
    }
}
