using DigitalCircuits.Core.CodeTRON;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalCircuits.Core.CodeTRON
{
    /// <summary>
    /// The controller class for the CodeTRON.
    /// </summary>

    public class CTController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _screen;
        [SerializeField]
        private Terminal _terminal;
        [SerializeField]
        private TextMeshProUGUI _filebar;

        [Space]

        public bool IsON = false;
        public string CurrentFileName;

        private void Awake()
        {
            // set-up
            _screen.SetActive(false);
        }

        public void ONOFF()
        {
            if (IsON)
            {
                SHUTDOWN();
            }
            else
            {
                BOOT();
            }
        }

        public void BOOT()
        {
            // start-up
            _screen.SetActive(true);
            IsON = true;

            // create a new file
            NEWFILE();

            // print welcome message
            PRNT("Welcome to codeTRON 5000");
            PRNT("by TELTEC Industries.");
            PRNT("===================================");
            PRNT("STATUS: READY");

            // parse the input field
            Parser._instance.Parse(_terminal.InputField.text);

            _terminal.PosStart = 97;

        }

        public void SHUTDOWN()
        {
            // cleanup
            _terminal.InputField.text = string.Empty;
            _filebar.text = string.Empty;
            CurrentFileName = string.Empty;

            // deactivate
            _screen.SetActive(false);
            IsON = false;
        }

        public void PRNT(string msg)
        {
            if (IsON)
            {
                // add the msg to the inputfield
                _terminal.InputField.text += msg + '\n';
            }
        }

        public void NEWFILE()
        {
            if (IsON)
            {
                // clear the display
                _terminal.InputField.text = string.Empty;

                // set the file name
                string fileName = "New File.txt";
                CurrentFileName = fileName
                    ;
                // set the filebar.text component
                _filebar.text = fileName + "\n" + "-------------------------------------";
            }
        }

        public void SAVEFILE()
        { 
            if (IsON)
            {
                // TODO: method SAVEFILE() -> write the file to disk

            }
        }

        public void LOADFILE()
        {
            if (IsON) 
            {
                // TODO: method LOADFILE() -> load from disk to file
            }
        }
    }
}