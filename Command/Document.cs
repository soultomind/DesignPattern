using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Document
    {
        public string Name { get; set; }
        public Size Size { get; set; }

        public Stack<IDocumentControlCommand> UnDoDocumentControls { get; set; } = new Stack<IDocumentControlCommand>();
        public Stack<IDocumentControlCommand> ReDoDocumentControls { get; set; } = new Stack<IDocumentControlCommand>();

        public Document()
            : this("NewForm1")
        {

        }

        public Document(string name)
            : this(name, new Size(2100, 2970))
        {

        }

        public Document(string name, Size size)
        {
            Name = name;
            Size = size;
        }

        public void Redraw()
        {
            Console.WriteLine("현재 문서를 다시 그립니다.");
            Console.WriteLine("모든 컨트롤을 다시 그립니다.");
            foreach (IDocumentControlCommand command in UnDoDocumentControls)
            {
                command.Draw();
            }
        }

        private IDocumentControlCommand CreateDocumentControlCommand(IDocumentControl control)
        {
            Assembly assembly = Assembly.GetEntryAssembly();
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsClass && type.GetInterfaces().Contains(typeof(IDocumentControlCommand)))
                {
                    foreach (var constructor in type.GetConstructors())
                    {
                        if (constructor.GetParameters() != null && constructor.GetParameters().Length == 1)
                        {
                            // DocumentButton, DocumentTextBox 타입별로 Command 를 생성해야 될 경우
                            foreach (var parameter in constructor.GetParameters())
                            {
                                if (parameter.ParameterType.Equals(control.GetType()))
                                {
                                    return (IDocumentControlCommand) Activator.CreateInstance(type, new object[] { control });
                                }
                            }
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// 디자이너에서 특정 컨트롤(버튼, 텍스트박스 .. 등) 마우스를 통하여 그린 컨트롤
        /// </summary>
        /// <param name="control"></param>
        /// <param name="pt1"></param>
        /// <param name="pt2"></param>
        public void AddControl(IDocumentControl control)
        {
            // 해당 컨트롤에 알맞는 커맨드를 생성하여 추가한다.
            IDocumentControlCommand command = CreateDocumentControlCommand(control);
            UnDoDocumentControls.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            // Remove
            IDocumentControlCommand command = UnDoDocumentControls.Pop();
            ReDoDocumentControls.Push(command);

            Console.WriteLine("Undo........ Press any key");
            Console.ReadKey();
            Redraw();
        }

        public void Redo()
        {
            // Execute
            IDocumentControlCommand command = ReDoDocumentControls.Pop();
            UnDoDocumentControls.Push(command);

            Console.WriteLine("Redo........ Press any key");
            Console.ReadKey();
            Redraw();
        }
    }
}
