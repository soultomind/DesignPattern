using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class TempDirectoryContext
    {
        public TempDirectoryContext(string rootDirectory)
        {
            this.RootDirectory = rootDirectory;
        }
        public string RootDirectory { get; internal set;
        }
        public IDirectoryStrategy DirectoryStrategy { get; internal set; }

        public void CreateDirectory()
        {
            if (DirectoryStrategy != null)
            {
                string directoryName = DirectoryStrategy.MakeDirectoryName();
                string path = RootDirectory + Path.DirectorySeparatorChar + directoryName;
                System.IO.Directory.CreateDirectory(path);
            }
        }
    }
}
