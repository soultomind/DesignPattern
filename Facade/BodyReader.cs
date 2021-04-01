using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class BodyReader
    {
        public void Read(DocumentPage documentPage)
        {
            Console.WriteLine("서식의 본문을 읽습니다.");
            String text = String.Format(documentPage.Body, documentPage.Number);
            Console.WriteLine(text);
        }
    }
}
