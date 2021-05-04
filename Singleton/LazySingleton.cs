using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class LazySingleton
    {
        LazySingleton()
        {
            Console.WriteLine("LazySingleton()");
        }
        private class Holder
        {
            public readonly static LazySingleton Instance = new LazySingleton();

            static Holder()
            {
                Console.WriteLine("static Holder()");
            }
        }

        public static LazySingleton GetInstance()
        {
            return Holder.Instance;
        }
    }
}
