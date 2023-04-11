using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// A component class for adding dragging functionality to a GameObject.
    /// </summary>

    [RequireComponent(typeof(Anchorable))]
    public class Draggeable : MonoBehaviour
    { 
        Vector2 difference = Vector2.zero;

        private void OnMouseDown()
        {
            difference = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - (Vector2)transform.position;
        }

        private void OnMouseDrag()
        {
            if (!ToolbarManager._instance.IsToolbarActive && !gameObject.GetComponent<Anchorable>().IsAnchored)
                transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) - difference;
        }
    }
}