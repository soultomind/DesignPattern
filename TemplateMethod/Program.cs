using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DesignPattern TemplateMethod Pattern");

            AbstractDeviceManager deviceManager = null;

            deviceManager = new ACorpDeviceManager();
            deviceManager.On();
            if (deviceManager.Connect((IntPtr)1010))
            {
                deviceManager.Process();
                deviceManager.About();
            }
            deviceManager.Off();

            deviceManager = new BCorpDeviceManager();
            deviceManager.On();
            if (deviceManager.Connect((IntPtr)2020))
            {
                deviceManager.Process();
                deviceManager.About();
            }
            
            deviceManager.Off();
        }
    }
}