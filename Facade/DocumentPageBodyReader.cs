using System;

namespace Facade
{
    internal class DocumentPageBodyReader
    {
        internal void Read(DocumentPage documentPage)
        {
            Console.WriteLine("서식의 본문을 읽습니다.");
            String text = String.Format(documentPage.Body, documentPage.Number);
            Console.WriteLine(text);
        }
    }
}
