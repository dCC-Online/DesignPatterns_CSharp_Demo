using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.SingletonPattern
{
    internal class Country
    {
        public string name; 
        public Counter counter;

        public Country(string name)
        {
            this.name = name;
            //Calls the GetInstance method rather than directly instantiate a counter
            //This ensures all created Country objects will share same Counter object.
            counter = Counter.GetInstance();
        }
    }
}
