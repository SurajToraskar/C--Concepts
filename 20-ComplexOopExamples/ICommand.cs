using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_ComplexOopExamples
{
    interface ICommand
    {
        void Execute();

        void Undo();

        void IncreaseVolume();
        void DecreaseVolume();
    }
}
