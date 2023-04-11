using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// A component class for anchoring to other GameObjects.
    /// </summary>

    public class Anchorable : MonoBehaviour
    {
        public bool IsAnchored = false;

        public void SetAnchor()
        {
            if (IsAnchored)
                IsAnchored = false;
            else
                IsAnchored = true;
        }
    }
}
