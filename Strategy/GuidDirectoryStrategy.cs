using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class GuidDirectoryStrategy : IDirectoryStrategy
    {
        public string MakeDirectoryName()
        {
            string directoryName = Guid.NewGuid().ToString();
            Console.WriteLine("GuidDirectory MakeDirectory={0}", directoryName);
            return directoryName;
        }
    }
}
