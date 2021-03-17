using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Document
    {
        public Document()
            : this(String.Empty, String.Empty, String.Empty)
        {

        }
        public Document(string title, string author, string text)
        {
            Title = title;
            Author = author;
            Text = text;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                .Append("Title=").AppendLine(Title)
                .Append("Author=").AppendLine(Author)
                .Append("Text=").AppendLine(Text)
                .ToString();
        }

        public class DocumentBuilder
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Text { get; set; }

            public DocumentBuilder SetTitle(string title)
            {
                Title = title;
                return this;
            }

            public DocumentBuilder SetAuthor(string author)
            {
                Author = author;
                return this;
            }

            public DocumentBuilder SetText(string text)
            {
                Text = text;
                return this;
            }

            public Document Build()
            {
                return new Document(this);
            }
        }

        private Document(DocumentBuilder builder)
        {
            Title = builder.Title;
            Author = builder.Author;
            Text = builder.Text;
        }
    }
}
