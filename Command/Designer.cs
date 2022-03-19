using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Designer
    {
        public List<Document> NewDocuemnts { get; set; }
        public Document CurrentSelectDocument { get; set; }
        public Designer()
        {
            NewDocuemnts = new List<Document>();
        }

        public Document NewDocument()
        {
            string name = String.Format("NewForm{0}", NewDocuemnts.Count + 1);
            Document newDocument = new Document(name);
            NewDocuemnts.Add(newDocument);
            CurrentSelectDocument = newDocument;
            return newDocument;
        }
    }
}
