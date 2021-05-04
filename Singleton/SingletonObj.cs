using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class SingletonObj
    {
        private static SingletonObj Instance;

        protected SingletonObj()
        {

        }
        
        public static SingletonObj GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonObj();
            }
            return Instance;
        }
    }
}
