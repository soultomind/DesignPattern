using System;

namespace Facade
{
    internal class DocumentPageFooterReader
    {
        internal void Read(DocumentPage documentPage)
        {
            Console.WriteLine("서식의 푸터(꼬리말)을 읽습니다.");
            Console.WriteLine(documentPage.Footer);
        }
    }
}
