using System.Collections.Generic;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// Provides an interface for construction logic gates.
    /// Must implement: 
    /// int Fire()
    ///
    /// </summary>


    public interface ILogicGate
    {
        public int Output { set; get; }
        public List<int> Inputs { set; get; }
        public string Address { set; get; }
        public string To { set; get; }
        public string From { set; get; }

    }
}