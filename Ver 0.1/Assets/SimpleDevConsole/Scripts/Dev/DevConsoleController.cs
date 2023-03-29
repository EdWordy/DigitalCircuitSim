using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace DigitalCircuits.Core.DevTools
{
    /// <summary>
    /// The core controller class for the SimpleDevConsole package. Simply add new command variables to the command list, and voila!
    /// </summary>

    public class DevConsoleController : MonoBehaviour
    {
        // singleton
        public static DevConsoleController current;

        // member variables
        public GameObject ConsoleGO;
        [SerializeField] private TMP_InputField ConsoleInput;
        [SerializeField] private TMP_Text ConsoleFeed;
        [SerializeField] private Button Button1;
        [SerializeField] private Button Button2;

        // ====================================

        // command list
        public List<object> CommandList;

        // commands
        public static DevCommand CMD1;
        public static DevCommand CMD2;
        public static DevCommand<int> CMD3;

        // Start is called before the first frame update
        void Start()
        {
            if (current == null)
            {
                current = this;
            }
            else
            {
                Destroy(current);
            }

            // setup
            ConsoleGO = GameObject.Find("ConsolePanel");
            ConsoleGO.SetActive(false);

            this.Log("Welcome to Simple Console v0.5! Type HELP for more info" + "\n");

        }

        private void Awake()
        {
            CMD1 = new DevCommand("HELP", "Type this command for more info", "HELP", () =>
            {
                this.Log("HELP selected\n");

                for (int i = 0; i < CommandList.Count; i++)
                {
                    DevCommandBase cmd = CommandList[i] as DevCommandBase;

                    string label = $"{cmd.CommandFormat} - {cmd.CommandDescription}";

                    this.Log(label + "\n");
                }
            });

            CMD2 = new DevCommand("woop", "prints a message", "woop", () =>
            {
                Debug.Log("woop woop");
            });

            CMD3 = new DevCommand<int>("repeat", "repeats some given amount", "repeat <repeat_amount>", (x) =>
            {
                for (int i = 0; i < x; i++)
                {
                    this.Log("Repeat!\n");
                }

            });

            CommandList = new List<object>()
            {
                CMD1,
                CMD2,
                CMD3
            };
        }

        void Update()
        {
            if (Input.GetKeyDown("`"))
            {
                if (ConsoleGO != null & ConsoleGO.activeSelf != true)
                {
                    ConsoleGO.SetActive(true);
                    ConsoleInput.text = "";
                }
                else if (ConsoleGO != null && ConsoleGO.activeSelf == true)
                {
                    ConsoleGO.SetActive(false);
                }

            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (ConsoleInput.text != null)
                {
                    HandleInput();
                }
            }
        }


        public void Log(string content)
        {
            ConsoleFeed.text += content;
        }

        private void HandleInput()
        {
            string[] properties = ConsoleInput.text.Split(' ');

            for (int i = 0; i < CommandList.Count; i++)
            {
                DevCommandBase commandBase = CommandList[i] as DevCommandBase;

                if (ConsoleInput.text.Contains(commandBase.CommandID))
                {
                    if (CommandList[i] as DevCommand != null)
                    {
                        // cast to this type and invoke the command
                        (CommandList[i] as DevCommand).Invoke();
                    }
                    else if (CommandList[i] as DevCommand<int> != null)
                    {
                        (CommandList[i] as DevCommand<int>).Invoke(int.Parse(properties[1]));
                    }
                }
            }
        }



        public void ConsoleEnterButton()
        {
            if (ConsoleFeed.text != null)
            {
                HandleInput();
            }
        }


        public void ConsoleExitButton()
        {
            ConsoleGO.SetActive(false);
        }
    }

}


