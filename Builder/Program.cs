using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DesignPattern Builder Pattern");

            Document document = new Document.DocumentBuilder()
                                .SetTitle("휴가계획서")
                                .SetAuthor("이바우")
                                .SetText(DateTime.Now.ToString("yyyy.MM.dd") + " 개인사유로 연차를 사용합니다.")
                                .Build();

            Console.WriteLine(document);
        }
    }
}
