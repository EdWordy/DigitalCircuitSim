using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// A class responsible for managing the Toolbar and its related functionality.
    /// </summary>
    
    public class ToolbarManager : MonoBehaviour
    {
        // singleton
        public static ToolbarManager _instance;

        // Fields
        public bool IsToolbarActive;
        public bool IsSolderActive;
        public bool IsScrewdriverActive;
        public bool IsWirecutterActive;
        public bool IsWireActive;

        // Methods
        void Awake()
        {
            if (_instance == null || _instance != this)
                _instance = this;
            else
                Destroy(_instance);

            IsToolbarActive = false;
        }

        private void Update()
        {
            if (IsToolbarActive)
            {
                if (IsSolderActive) 
                { 
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        SetSolderActive();
                    }
                }
                else if (IsScrewdriverActive)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        SetScrewdriverActive();
                    }
                }
                else if (IsWirecutterActive)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        SetWirecuttersActive();
                    }
                }
                else if (IsWireActive)
                {
                    if (Input.GetKeyDown(KeyCode.Escape))
                    {
                        SetWireActive();
                    }
                }
            }
        }

        public void SetActive()
        {
            if (IsToolbarActive)
                IsToolbarActive = false;
            else
                IsToolbarActive = true;
        }

        public void SetSolderActive()
        {
            if (IsSolderActive)
                IsSolderActive = false;
            else
            {
                IsSolderActive = true;
                IsScrewdriverActive = false;
                IsWirecutterActive = false;
                IsWireActive = false;
            }
        }

        public void SetScrewdriverActive()
        {
            if (IsScrewdriverActive)
                IsScrewdriverActive = false;
            else
            {
                IsScrewdriverActive = true;
                IsSolderActive = false;
                IsWirecutterActive = false;
                IsWireActive = false;
            }
        }

        public void SetWirecuttersActive()
        {
            if (IsWirecutterActive)
                IsWirecutterActive = false;
            else
            {
                IsWirecutterActive = true;
                IsSolderActive = false;
                IsScrewdriverActive = false;
                IsWireActive = false;
            }
        }

        public void SetWireActive()
        {
            if (IsWireActive)
                IsWireActive = false;
            else
            {
                IsWireActive = true;
                IsSolderActive = false;
                IsScrewdriverActive = false;
                IsWirecutterActive = false;
            }
        }
    }
}