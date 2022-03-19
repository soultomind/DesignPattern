using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public delegate void FormControlEventHandler(object sender, EventArgs e);
    public interface IFormControl
    {
        string Name { get; set; }
        Point Location { get; set; }
        Size Size { get; set; }

        void PerformClick();
        event FormControlEventHandler Click;
    }
}
