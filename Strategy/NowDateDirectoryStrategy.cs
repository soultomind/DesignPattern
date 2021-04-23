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
        public NowDateDirectoryStrategy(string format = "yyyy.MM.dd")
        {
            Format = format;
        }
        public string Format { get; set; }
        public string MakeDirectoryName()
        {
            string directoryName = DateTime.Now.ToString(Format);
            Console.WriteLine("NowDateDirectory MakeDirectory={0}", directoryName);
            return directoryName;
        }
    }
}
