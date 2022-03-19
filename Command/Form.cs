using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Form
    {
        public string Name { get; set; }
        public Size Size { get; set; }

        public Stack<IFormControlCommand> UnDoFormControls { get; set; } = new Stack<IFormControlCommand>();
        public Stack<IFormControlCommand> ReDoFormControls { get; set; } = new Stack<IFormControlCommand>();

        public Form()
            : this("NewForm1")
        {

        }

        public Form(string name)
            : this(name, new Size(2100, 2970))
        {

        }

        public Form(string name, Size size)
        {
            Name = name;
            Size = size;
        }

        public void Redraw()
        {
            Console.WriteLine("현재 폼을 다시 그립니다.");
            Console.WriteLine("모든 컨트롤을 다시 그립니다.");
            foreach (IFormControlCommand command in UnDoFormControls)
            {
                command.Draw();
            }
        }

        private IFormControlCommand CreateFormControlCommand(IFormControl control)
        {
            Assembly assembly = Assembly.GetEntryAssembly();
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsClass && type.GetInterfaces().Contains(typeof(IFormControlCommand)))
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
                                    return (IFormControlCommand) Activator.CreateInstance(type, new object[] { control });
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
        public void AddControl(IFormControl control)
        {
            // 해당 컨트롤에 알맞는 커맨드를 생성하여 추가한다.
            IFormControlCommand command = CreateFormControlCommand(control);
            UnDoFormControls.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            if (UnDoFormControls.Count > 0)
            {
                IFormControlCommand command = UnDoFormControls.Pop();
                ReDoFormControls.Push(command);

                Console.WriteLine("Undo........ Press any key");
                Console.ReadKey();
                Redraw();
            }
        }

        public void Redo()
        {
            if (ReDoFormControls.Count > 0)
            {
                IFormControlCommand command = ReDoFormControls.Pop();
                UnDoFormControls.Push(command);

                Console.WriteLine("Redo........ Press any key");
                Console.ReadKey();
                Redraw();
            }
        }
    }
}
