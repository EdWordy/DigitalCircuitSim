using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

namespace DigitalCircuits.Core.XML
{
    /// <summary>
    /// A class of helper methods for XML functions 
    /// such as Saving and Loading XML.
    /// </summary>

    public static class XMLUtils
    {
        // Methods
        public static void SaveXML(XMLData data)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(XMLData));
            TextWriter writer = new StreamWriter("SaveData.xml");
            serializer.Serialize(writer, data);
            writer.Close();
        }

        public static XMLData LoadXML(string path)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(XMLData));
            TextReader reader = new StreamReader(path + "SaveData.xml");
            XMLData data = (XMLData)deserializer.Deserialize(reader);
            reader.Close();
            return data;
        }
    }
}