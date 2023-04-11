using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// An interface for the creation of digital circuit components.
    /// requires:
    /// int Fire()
    /// </summary>

    public interface IComponent
    {
        public abstract int Fire();
    }
}