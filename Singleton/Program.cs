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

            LazySingleton o1 = LazySingleton.GetInstance();
            LazySingleton o2 = LazySingleton.GetInstance();

            if (object.ReferenceEquals(o1, o2))
            {
                Console.WriteLine("LazySingleton object.ReferenceEquals o1 == o2 True!");
            }
        }
    }
}
