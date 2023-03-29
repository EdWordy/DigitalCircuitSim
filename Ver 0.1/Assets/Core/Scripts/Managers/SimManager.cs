using DigitalCircuits.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core
{

    /// <summary>
    /// The class that is responsible for managing the simulation.
    /// </summary>

    public class SimManager : MonoBehaviour
    {
        // singleton
        public static SimManager _instance;

        // Fields
        public bool IsSimRunning = false;
        public bool ShowPanel = false;
        public GameObject TooltipPanel;

        public List<CircuitBoard> Circuits;
        public float simulationTime;

        // Methods
        void Awake()
        {
            if (_instance == null || _instance != this)
                _instance = this;
            else
                Destroy(_instance);

            Application.targetFrameRate = 60;
        }

        private void Update()
        {
            // tooltip panel
            if (ShowPanel)
            {
                TooltipPanel.SetActive(true);
            }
            else if (!ShowPanel)
            {
                TooltipPanel.SetActive(false);
            }

            // simulation
            if (IsSimRunning)
            { 
                // iterate thru the board list and evalute each board
                foreach (CircuitBoard board in Circuits)
                {
                    board.Evaluate();
                }
                simulationTime += Time.deltaTime;

                // add code to handle simulation time and other parameters

            }
            else
            {
                // do nothing
            }
        }

        public void SwitchSim()
        {
            if (IsSimRunning)
                IsSimRunning = false;
            else
                IsSimRunning = true;
        }

        public void Simulate()
        {
            IsSimRunning = true;
        }

        public void Stop()
        {
            IsSimRunning = false;
        }
    }
}