using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// A class for the simulation of circuit boards.
    /// </summary>
    
    public class CircuitBoard : MonoBehaviour
    {
        // Fields
        public string ID;
        public List<IComponent> Components;

        public void AddComponent(IComponent component)
        {
            // Add code to create and add a new component to the circuit
            Components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            // Add code to remove a component from the circuit
            Components.Remove(component);
        }

        public void Evaluate()
        {
            foreach (IComponent component in Components) 
            {
                component.Fire();
            }
        }
    }
} 