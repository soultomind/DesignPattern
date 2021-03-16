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
            TempDirectoryManager tempDirectoryManager = new TempDirectoryManager(rootDirectory);

            DefualtDirectory defaultDirectory = new UUIDDirectory();
            tempDirectoryManager.Directory = defaultDirectory;
            tempDirectoryManager.CreateDirectory();

            defaultDirectory = new NowDateDirectory();
            tempDirectoryManager.Directory = defaultDirectory;
            tempDirectoryManager.CreateDirectory();
        }
    }
}
