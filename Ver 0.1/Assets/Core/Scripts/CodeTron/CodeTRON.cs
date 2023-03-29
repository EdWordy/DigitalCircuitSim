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

    public class CodeTRON : MonoBehaviour
    {
        [SerializeField]
        private GameObject _screen;
        [SerializeField]
        private TMP_InputField _input;

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
            Parser._instance.Parse(_input.text);


        }

        public void SHUTDOWN()
        {
            // cleanup
            _input.text = string.Empty;
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
                _input.text += msg + '\n';
            }
        }

        public void UPDATESCRN()
        {
            if (IsON) 
            {
                Parser._instance.Parse(_input.text);
            }
        }    

        public void NEWFILE()
        {
            if (IsON)
            {
                // clear the display
                _input.text = string.Empty;

                // set the file name
                string fileName = "New File.txt";
                CurrentFileName = fileName;
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