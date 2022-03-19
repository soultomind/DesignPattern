using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class DocumentControlCommand : IDocumentControlCommand
    {
        public DocumentControl Control { get; set; }
        public DocumentControlCommand(DocumentControl control)
        {
            Control = control;
        }
        public abstract void Execute();
        public abstract void Draw();

    }
}
