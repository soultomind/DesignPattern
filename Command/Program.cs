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
            Form form = designer.NewForm();

            Console.WriteLine("현재 " + form.Name + " 문서에");
            FormButton buton = new FormButton(
                "버튼1", new Point(100, 100), new Point(600, 300))
            {
                Text = "클릭"
            };
            form.AddControl(buton);

            FormTextBox textBox = new FormTextBox(
                "텍스트1", new Point(500, 100), new Point(100, 800))
            {
                Text = ""
            };
            form.AddControl(textBox);

            form.Undo();
            form.Undo();

            form.Redo();
            form.Redo();
        }
    }
}
