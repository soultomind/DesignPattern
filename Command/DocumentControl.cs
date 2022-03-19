using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class DocumentControl : IDocumentControl
    {
        public string Name
        {
            get; set;
        }

        public Point Location
        {
            get; set;
        }

        public Size Size
        {
            get; set;
        }

        public Rectangle Bounds
        {
            get
            {
                return new Rectangle(Location, Size);
            }
        }

        public DocumentControl(string name, Point pt1, Point pt2)
        {
            Name = name;
            Pt1 = pt1;
            Pt2 = pt2;
            InitializeBounds();
        }

        protected void InitializeBounds()
        {
            Location = (Pt1.Y > Pt2.Y) ? Pt2 : Pt1;

            int width = (Pt1.X > Pt2.X) ? Pt1.X - Pt2.X : Pt2.X - Pt1.X;
            if (Location == Pt1)
            {
                int height = Pt1.Y - Pt2.Y;
                Size = new Size(width, height);
            }
            else
            {
                int height = Pt2.Y - Pt1.Y;
                Size = new Size(width, height);
            }
        }

        public Point Pt1 { get; set; }
        public Point Pt2 { get; set; }

        public void PerformClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
        public event DocumentControlEventHandler Click;


        public override string ToString()
        {
            return new StringBuilder()
                .AppendFormat("Name={0}, Location={1}, Size={2}", Name, Location, Size)
                .ToString();
        }
    }
}
