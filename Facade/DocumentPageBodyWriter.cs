using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class DocumentPageBodyWriter
    {
        internal void Write(DocumentPage documentPage, StringBuilder builder)
        {
            string text = String.Format(documentPage.Body, documentPage.Number);
            builder.Append("Body=").Append(text).AppendLine();
        }
    }
}
