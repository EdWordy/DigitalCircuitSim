using DigitalCircuits.Core;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// The Manager class for handling selection of UI and World GameObjects
    /// </summary>

    public class SelectionManager : MonoBehaviour
    {
        // singleton
        public static SelectionManager _instance;

        // Fields
        public GameObject Selection = null;
        public GameObject SelectionUI = null;

        // Methods
        void Awake()
        {
            if (_instance == null || _instance != this)
                _instance = this;
            else
                Destroy(_instance);
        }
    }
}