using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class LazySingletonObj
    {
        LazySingletonObj()
        {
            Console.WriteLine("LazySingletonObj()");
        }
        private class Holder
        {
            public readonly static LazySingletonObj Instance = new LazySingletonObj();

            static Holder()
            {
                Console.WriteLine("static Holder()");
            }
        }

        public static LazySingletonObj GetInstance()
        {
            return Holder.Instance;
        }
    }
}
