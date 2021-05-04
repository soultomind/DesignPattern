using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DesignPattern Singleton Pattern");

            Console.WriteLine("============== SingletonObj ==============");
            SingletonObj so1 = SingletonObj.GetInstance();
            SingletonObj so2 = SingletonObj.GetInstance();
            if (object.ReferenceEquals(so1, so2))
            {
                Console.WriteLine("SingletonObj object.ReferenceEquals lso1 == lso2 True!");
            }

            Console.WriteLine("============== LazySingletonObj ==============");
            LazySingletonObj lso1 = LazySingletonObj.GetInstance();
            LazySingletonObj lso2 = LazySingletonObj.GetInstance();

            if (object.ReferenceEquals(lso1, lso2))
            {
                Console.WriteLine("LazySingleton object.ReferenceEquals lso1 == lso2 True!");
            }
        }
    }
}
