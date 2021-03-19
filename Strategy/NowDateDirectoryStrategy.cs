using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class NowDateDirectoryStrategy : IDirectoryStrategy
    {
        public string MakeDirectoryName()
        {
            string directoryName = DateTime.Now.ToString("yyyy.MM.dd");
            Console.WriteLine("NowDateDirectory MakeDirectory={0}", directoryName);
            return directoryName;
        }
    }
}
