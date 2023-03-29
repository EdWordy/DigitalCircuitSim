using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

namespace DigitalCircuits.Core.CodeTRON
{
    /// <summary>
    /// A class for handling text input and rendering the CodeTRON display.
    /// </summary>

    public class Terminal : MonoBehaviour
    {
        public TextMeshProUGUI InputField;
        public TextMeshProUGUI LineNumbers;
        public GameObject SelectionCaret;

        public int LineNumberTotal;

        [SerializeField]
        private bool IsMultiSelect;
        [SerializeField]
        private int LineLength;
        [SerializeField]
        public int PosStart;
        [SerializeField]
        private int PosEnd;
        [SerializeField]
        private float BlinkRate;

        [SerializeField]
        private float _time;

        private void Awake()
        {
            // setup
            IsMultiSelect = false;
            BlinkRate = 0.85f;
            PosStart = 0;
            LineLength = 1;

            _time = BlinkRate;
        }



        private void Update()
        {
            HandleInput();


            if (_time <= 0)
            {
                _time = BlinkRate;
                BlinkCaret();
            }
            _time -= Time.deltaTime;
        }

        private void BlinkCaret()
        {
            if (SelectionCaret.gameObject.activeSelf)
            {
                SelectionCaret.gameObject.SetActive(false);
            }
            else
            {
                SelectionCaret.gameObject.SetActive(true);
            }
        }

        public void HandleInput()
        {
            // If theres input check it!
            if (Input.anyKey)
            {
                if (Input.GetKeyDown(KeyCode.A)) // alphabet
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.C))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.D))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.E))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.F))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.G))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.H))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.I))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.J))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.K))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.L))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.M))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.N))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.O))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.P))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Q))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.R))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.S))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.T))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.U))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.V))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.W))
                {
                    InputField.text += Input.inputString;
                    LineLength++;

                }
                else if (Input.GetKeyDown(KeyCode.X))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Y))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Z))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0)) // numbers
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Period)) // punctuation and symbols
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Comma))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Backslash))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Semicolon))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Quote))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.BackQuote))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Slash))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Minus))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Equals))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.LeftBracket))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.RightBracket))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad0)) // numpad
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad1))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad2))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad3))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad4))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad5))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad6))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad7))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad8))
                {
                    InputField.text += Input.inputString;
                }
                else if (Input.GetKeyDown(KeyCode.Keypad9))
                {
                    InputField.text += Input.inputString;
                    LineLength++;
                }
                else if (Input.GetKeyDown(KeyCode.Return))  // special
                {
                    // add a new line
                    InputField.text += '\n';

                    // increase line numbers total and add a line number
                    LineNumberTotal++;
                    Parser._instance.AddLineNum();

                    // move the caret
                    PosStart++;
                    SelectionCaret.transform.position = new Vector3 (-145, 0, 0);
                    SelectionCaret.transform.position += new Vector3(0, 20, 0);

                    LineLength = 1;

                }
                else if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    // remove a line
                    if (InputField.text.Length > 0)
                        InputField.text = InputField.text.Remove(InputField.text.Length - 1);

                    // update the screen
                    Parser._instance.Parse(InputField.text);

                    // move the caret
                    PosStart--;

                    if (LineLength == 1)
                    {
                        SelectionCaret.transform.position += new Vector3(0, 20, 0);
                    }
                    else
                    {
                        SelectionCaret.transform.position -= new Vector3(10, 0, 0);
                    }

                    LineLength--;
                }
                else if (Input.GetKeyDown(KeyCode.Space))
                {
                    // move the caret
                    PosStart++;
                    SelectionCaret.transform.position += new Vector3(0, 20, 0);

                    LineLength++;
                }
            }

        }

    }
}