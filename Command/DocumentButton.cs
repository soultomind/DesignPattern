using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class DocumentButton : DocumentControl
    {
        public DocumentButton(string name, Point pt1, Point pt2)
            : base(name, pt1, pt2)
        {

        }
        public string Text { get; set; }
    }
}
