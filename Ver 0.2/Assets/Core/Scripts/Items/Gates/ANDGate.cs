using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core
{
    public class ANDGate : MonoBehaviour, ILogicGate, IComponent
    {
        public int Output { set; get; }
        public List<int> Inputs { set; get; }
        public string Address { set; get; }
        public string To { set; get; }
        public string From { set; get; }

        // constructor
        public ANDGate()
        {
            Address = Utils.GenerateAddress(8);
        }

        // methods
        public int Fire()
        {
            if (Inputs[0] == 1 && Inputs[1] == 1)
                Output = 1;
            else
                Output = 0;

            return Output;
        }
    }

}
