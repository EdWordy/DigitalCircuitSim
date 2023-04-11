using DigitalCircuits.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DigitalCircuits.Core.XML;
using TMPro;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// A component class for adding tooltip functionality to a GameObject.
    /// </summary>
    
    public class Tooltip : MonoBehaviour
    {
        // Fields
        public GameObject UIElement;
        [SerializeField]
        private TooltipData TooltipData;

        // Events
        private void OnMouseEnter()
        {
            SimManager._instance.ShowPanel = true;
            SimManager._instance.TooltipPanel.SetActive(true);

            SelectionManager._instance.Selection = gameObject;

            // create new UI elements
            GameObject SelectedGameObjectUI = Instantiate(UIElement, GameObject.Find("Tooltip").transform);
            SelectionManager._instance.SelectionUI = SelectedGameObjectUI;

            // load XML
            GameObject nameTextGO = GameObject.Find("Name Text");
            TextMeshProUGUI nameText = nameTextGO.GetComponent<TextMeshProUGUI>();
            nameText.text = TooltipData.Name;

            GameObject typeTextGO = GameObject.Find("Type Text");
            TextMeshProUGUI typeText = typeTextGO.GetComponent<TextMeshProUGUI>();
            typeText.text = TooltipData.Type;
        }
        private void OnMouseExit()
        {
            // clear sleection
            SelectionManager._instance.Selection = null;

            // clear old UI elements
            Destroy(SelectionManager._instance.SelectionUI.gameObject);

            // hide the UI
            SimManager._instance.ShowPanel = false;
        }

        public void SetTooltip(TooltipData data)
        {
            TooltipData = data;
        }

        public TooltipData GetTooltip()
        {
            return TooltipData;
        }    
    }
}