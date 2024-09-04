using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ComplexOopExamples
{
    interface IElectronicDevice
    {
        int Volume { get; set; }
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();

    }
}
