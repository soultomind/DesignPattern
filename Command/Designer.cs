using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class Designer
    {
        public List<Form> Forms { get; set; }
        public Form CurrentSelectionForm { get; set; }
        public Designer()
        {
            Forms = new List<Form>();
        }

        public Form NewForm()
        {
            string name = String.Format("NewForm{0}", Forms.Count + 1);
            Form newForm = new Form(name);
            Forms.Add(newForm);
            CurrentSelectionForm = newForm;
            return newForm;
        }
    }
}
