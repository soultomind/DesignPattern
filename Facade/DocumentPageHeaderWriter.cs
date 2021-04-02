using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class DocumentPageHeaderWriter
    {
        internal void Write(DocumentPage documentPage, StringBuilder builder)
        {
            builder.Append("Header=").Append(documentPage.Header).AppendLine();
        }
    }
}
