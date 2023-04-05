using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.SingletonPattern
{
    internal class Country
    {
        public Counter counter;
        public string name;

        public Country(string name)
        {
            this.name = name;
            counter = Counter.GetInstance();
        }
    }
}
