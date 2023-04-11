using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml.Serialization;
using Unity.VisualScripting;

namespace DigitalCircuits.Core.XML
{
    /// <summary>
    /// The class responsible for handling serializable XML data for a tooltip.
    /// </summary>

    [Serializable]
    public class TooltipData : XMLData
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Type")]
        public string Type { get; set; }

        [XmlElement("Size")]
        public string Size { get; set; }

        [XmlElement("Components")]
        public string Components { get; set; }

        [XmlElement("Inputs")]
        public List<bool> Inputs { get; set; }

        [XmlElement("Output")]
        public bool Output { get; set; }
    }
}