using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DesignPattern Strategy Pattern");
            string rootDirectory = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            TempDirectoryContext tempDirectoryManager = new TempDirectoryContext(rootDirectory);

            IDirectoryStrategy directoryStrategy = new GuidDirectoryStrategy();
            tempDirectoryManager.DirectoryStrategy = directoryStrategy;
            tempDirectoryManager.CreateDirectory();

            directoryStrategy = new NowDateDirectoryStrategy("yyyy.MM.dd HH");
            tempDirectoryManager.DirectoryStrategy = directoryStrategy;
            tempDirectoryManager.CreateDirectory();
        }
    }
}
