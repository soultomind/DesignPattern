using System;

namespace Facade
{
    internal class DocumentPageHeaderReader
    {
        internal void Read(DocumentPage documentPage)
        {
            Console.WriteLine("서식의 헤더(머리말)를 읽습니다.");
            Console.WriteLine(documentPage.Header);
        }
    }
}
