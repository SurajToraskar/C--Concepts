using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ComplexOopExamples
{
    class PowerButton:ICommand
    {

        //Variable 
        IElectronicDevice device;

        public PowerButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.On();

        }

        public void Undo()
        {
            device.Off();
        }

        public void IncreaseVolume()
        {
            device.VolumeUp();
        }
        public void DecreaseVolume()
        {
            device.VolumeDown();
        }

    }
}
