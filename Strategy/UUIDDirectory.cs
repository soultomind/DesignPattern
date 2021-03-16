using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class UUIDDirectory : DefualtDirectory
    {
        public override string MakeDirectoryName()
        {
            DirectoryName = Guid.NewGuid().ToString();
            Console.WriteLine("UUIDDirectory MakeDirectory={0}", DirectoryName);
            return DirectoryName;
        }
    }
}
