using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class FormTextBoxCommand : FormControlCommand
    {
        public FormTextBoxCommand(FormTextBox control) 
            : base(control)
        {

        }

        public override void Execute()
        {
            Console.WriteLine("{0} 컨트롤이 생성되었습니다. 이름:{1}", Control.GetType(), Control.Name);
            Draw();
        }

        public override void Draw()
        {
            Console.WriteLine("텍스트박스를 그립니다.=" + Control.ToString());
        }
    }
}