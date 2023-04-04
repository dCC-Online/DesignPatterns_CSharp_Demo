using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.DependencyInjection
{
    public interface IPowerSource
    {
        int Volts { get; set; }
        void EmitPower();
    }
}
