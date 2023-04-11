using DigitalCircuits.Core.CodeTRON;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace DigitalCircuits.Core.CodeTRON
{
    /// <summary>
    /// The parser class for the CodeTRON.
    /// </summary>

    public class Parser : MonoBehaviour
    {
        public static Parser _instance;

        public List<string> lines = new List<string>();

        public TextMeshProUGUI LineNumbersText;
        [SerializeField]
        private TextMeshProUGUI _input;

        private int LineNumberTotal;

        public void Awake()
        {
            if (_instance == null || _instance != this)
                _instance = this;
            else
                Destroy(_instance);
        }

        public void AddLineNum()
        {
            LineNumbersText.text += LineNumberTotal + " ";

        }

        public void RemoveLineNum()
        {
            string str = LineNumberTotal.ToString() + " ";
            LineNumbersText.text = LineNumbersText.text.Replace(str, "");
        }

        public void Parse(string text)
        {
            if (text != null)
            {
                // setup 1
                lines.Clear();

                // for each string do x
                foreach (string s in text.Split("\n"))
                {
                    // add to lines list
                    lines.Add(s);
                }

                // setup 2
                int i = 1;
                LineNumbersText.text = "";
                LineNumberTotal = 0;

                // for each line do y
                foreach (string line in lines)
                {
                    // line numbering
                    LineNumbersText.text = LineNumbersText.text + i + " ";
                    i++;
                    LineNumberTotal++;
                }

            }
        }

    }
}