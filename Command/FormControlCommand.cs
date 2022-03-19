using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class FormControlCommand : IFormControlCommand
    {
        public FormControl Control { get; set; }
        public FormControlCommand(FormControl control)
        {
            Control = control;
        }
        public abstract void Execute();
        public abstract void Draw();

    }
}
