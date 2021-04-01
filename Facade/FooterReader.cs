using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class FooterReader
    {
        public void Read(DocumentPage documentPage)
        {
            Console.WriteLine("서식의 푸터(꼬리말)을 읽습니다.");
            Console.WriteLine(documentPage.Footer);
        }
    }
}
