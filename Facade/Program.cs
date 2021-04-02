using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Facade Pattern");

            Document document = new Document("디자인 패턴");
            document.addPage("퍼사드 패턴", "{0}. 페이지 내용입니다.", "Facade DesignPattern");
            document.addPage("빌더 패턴", "{0}. 페이지 내용입니다.", "Builder DesignPattern");

            DocumentManager documentManager = new DocumentManager();
            documentManager.SetPage(document, 0, "전략 패턴", "{0}. 페이지 내용입니다.", "Strategy DesignPattern");

            documentManager.Read(document);

            documentManager.Write(document, "Facade.txt");
        }
    }
}
