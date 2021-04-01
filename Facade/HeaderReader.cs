using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class HeaderReader
    {
        public void Read(DocumentPage documentPage)
        {
            Console.WriteLine("서식의 헤더(머리말)를 읽습니다.");
            Console.WriteLine(documentPage.Header);
        }
    }
}
