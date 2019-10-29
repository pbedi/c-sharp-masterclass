using System;
using System.Collections.Generic;
using System.Text;

namespace _09_01_Polymorphic_Parameters
{
    class M3: BMW
    {
        public M3(string hp, string color, string model) : base(hp, color, model)
        {
            
        }

        /* can't override a sealed class
        public override void Repair()
        {
            base.Repair();
        }*/
    }
}
