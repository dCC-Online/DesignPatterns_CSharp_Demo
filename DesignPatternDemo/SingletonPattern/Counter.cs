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

        //Private constructor ensures the class cannot be instantiated elsewhere
        private Counter()
        {
            count = 0;
        }

        //This method will instantiate a new Counter the first time it is called in the program
        //Any subsequent calls will return the previously instantiated version, NOT a new one
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
