using DigitalCircuits.Core;
using DigitalCircuits.Core.XML;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

namespace DigitalCircuits.Core
{
    public class OnLoad : MonoBehaviour
    {
        /// <summary>
        /// A helper class that looks for and load game objects 
        /// and their respective XML data when the scene plays.
        /// </summary>

        private void Awake()
        {
            // find Circuits and Chips
            GameObject[] Objects = GameObject.FindGameObjectsWithTag("Objects");

            if (Objects != null)
            {
                foreach (GameObject obj in Objects)
                {
                    if (obj != null)
                    {
                        if (obj.GetComponent<CircuitBoard>() != null)
                        {
                            // create the tooltipdata
                            TooltipData data = new TooltipData();
                            data.Name = "Circuit Board";
                            data.Type = "PCB";

                            // set the tooltipdata
                            Tooltip tooltip = obj.GetComponent<Tooltip>();
                            tooltip.SetTooltip(data);
                        }
                        else if (obj.GetComponent<ANDGate>() != null)
                        {
                            // create the tooltipdata
                            TooltipData data = new TooltipData();
                            data.Name = "AND Gate";
                            data.Type = "Logic Gate";

                            // set the tooltipdata
                            Tooltip tooltip = obj.GetComponent<Tooltip>();
                            tooltip.SetTooltip(data);
                        }
                        else if (obj.GetComponent<NANDGate>() != null)
                        {
                            // create the tooltipdata
                            TooltipData data = new TooltipData();
                            data.Name = "NAND Gate";
                            data.Type = "Logic Gate";

                            // set the tooltipdata
                            Tooltip tooltip = obj.GetComponent<Tooltip>();
                            tooltip.SetTooltip(data);
                        }
                        else if (obj.GetComponent<ORGate>() != null)
                        {
                            // create the tooltipdata
                            TooltipData data = new TooltipData();
                            data.Name = "OR Gate";
                            data.Type = "Logic Gate";

                            // set the tooltipdata
                            Tooltip tooltip = obj.GetComponent<Tooltip>();
                            tooltip.SetTooltip(data);
                        }
                        else if (obj.GetComponent<NORGate>() != null)
                        {
                            // create the tooltipdata
                            TooltipData data = new TooltipData();
                            data.Name = "NOR Gate";
                            data.Type = "Logic Gate";

                            // set the tooltipdata
                            Tooltip tooltip = obj.GetComponent<Tooltip>();
                            tooltip.SetTooltip(data);
                        }
                        else if (obj.GetComponent<NOTGate>() != null)
                        {
                            // create the tooltipdata
                            TooltipData data = new TooltipData();
                            data.Name = "NOT Gate";
                            data.Type = "Logic Gate";

                            // set the tooltipdata
                            Tooltip tooltip = obj.GetComponent<Tooltip>();
                            tooltip.SetTooltip(data);
                        }
                    }
                }
            }
            else
            {
                // do nothing
            }
        }
    }
}