using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.SingletonPattern
{
    internal class Counter
    {
        private static Counter instance;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }

        private Counter()
        {
            count = 0;
        }

        public static Counter GetInstance()
        {
            if (instance == null)
            {
                instance = new Counter();
            }
            return instance;
        }

        public void Increment()
        {
            count++;
        }

    }
}
