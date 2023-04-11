using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core
{
    public class NOTGate : MonoBehaviour, ILogicGate, IComponent
    {
        public int Output { set; get; }
        public List<int> Inputs { set; get; }
        public string Address { set; get; }
        public string To { set; get; }
        public string From { set; get; }

        // constructor
        public NOTGate()
        {
            Address = Utils.GenerateAddress(8);
        }

        // methods
        public int Fire()
        {
            if (Inputs[0] == 1)
                Output = 0;
            else
                Output = 1;

            return Output;

        }
    }
}
