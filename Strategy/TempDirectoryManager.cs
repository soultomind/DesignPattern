using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class TempDirectoryManager
    {
        public TempDirectoryManager(string rootDirectory)
        {
            this.RootDirectory = rootDirectory;
        }
        public string RootDirectory { get; internal set;
        }
        public DefualtDirectory Directory { get; internal set; }

        public void CreateDirectory()
        {
            if (Directory != null)
            {
                string directoryName = Directory.MakeDirectoryName();
                string path = RootDirectory + Path.DirectorySeparatorChar + directoryName;
                System.IO.Directory.CreateDirectory(path);
            }
        }
    }
}
