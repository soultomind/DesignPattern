using System;
using System.Text;

namespace Facade
{
    public class DocumentPage
    {
        private string header;
        private string body;
        private string footer;
        private int number;

        public DocumentPage(string header, string body, string footer)
        {
            this.header = header;
            this.body = body;
            this.footer = footer;
        }

        public string Header
        {
            get { return header; }
            set { header = value; }
        }

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        public string Footer
        {
            get { return footer; }
            set { footer = value; }
        }

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
