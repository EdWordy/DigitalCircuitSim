using DigitalCircuits.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// A component class for adding background functionality to a Scene object.
    /// </summary>

    public class Background : MonoBehaviour
    {
        private void OnMouseDown()
        {
            // clear sleection
            SelectionManager._instance.Selection = null;

            // clear old UI elements
            Destroy(SelectionManager._instance.SelectionUI.gameObject);

            // hide the UI
            SimManager._instance.ShowPanel = false;
        }
    }
}