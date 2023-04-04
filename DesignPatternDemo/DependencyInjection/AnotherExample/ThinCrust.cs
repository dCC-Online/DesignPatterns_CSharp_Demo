﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.DependencyInjection.AnotherExample
{
    class ThinCrust : IPreparable
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing thin crust pizza!");
        }
    }
}
