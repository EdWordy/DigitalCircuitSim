using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// A component class for adding Selection functionality to a GameObject.
    /// </summary>

    [Obsolete("Selectable is deperecated, please use Tooltip instead")]
    public class Selectable : MonoBehaviour
    {
        private void OnMouseDown()
        {

            Debug.Log("Select");

            SimManager._instance.ShowPanel = true;
            SimManager._instance.TooltipPanel.SetActive(true);

            if (SelectionManager._instance.Selection == null)
            {
                SelectionManager._instance.Selection = gameObject;

                // create new UI elements
                GameObject SelectedGameObjectUI = Instantiate(gameObject.GetComponent<Tooltip>().UIElement, GameObject.Find("Info Panel").transform);
                SelectionManager._instance.SelectionUI = SelectedGameObjectUI;


                Debug.Log("Blip");
            }
            else
            {
                SelectionManager._instance.Selection = gameObject;

                // clear old UI elements
                Destroy(SelectionManager._instance.SelectionUI.gameObject);

                // create new UI elements
                GameObject SelectedGameObjectUI = Instantiate(gameObject.GetComponent<Tooltip>().UIElement, GameObject.Find("Info Panel").transform);
                SelectionManager._instance.SelectionUI = SelectedGameObjectUI;

                Debug.Log("Bleep");
            }
        }
    }

}