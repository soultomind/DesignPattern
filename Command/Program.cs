using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DesignPattern Command Pattern");

            Designer designer = new Designer();
            Document document = designer.NewDocument();

            Console.WriteLine("현재 문서에");
            DocumentButton buton = new DocumentButton(
                "버튼1", new Point(10, 10), new Point(60, 30))
            {
                Text = "클릭"
            };
            document.AddControl(buton);

            DocumentTextBox textBox = new DocumentTextBox(
                "텍스트1", new Point(10, 10), new Point(60, 30))
            {
                Text = ""
            };
            document.AddControl(textBox);

            document.Undo();
            document.Undo();

            document.Redo();
            document.Redo();
        }
    }
}
