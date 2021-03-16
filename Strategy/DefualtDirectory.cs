using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class DefualtDirectory : IDirectory
    {
        public DefualtDirectory()
        {

        }

        public string DirectoryName { get; set; }

        public abstract string MakeDirectoryName();
    }
}
