using System;
using System.Collections.Generic;
using DigitalCircuits.Core;
using UnityEngine;

namespace DigitalCircuits.Core
{

    /// <summary>
    /// A class of helper methods and functions 
    /// for components and gates.
    /// </summary>

    public static class Utils
    {
        // fields 
        private static readonly List<char> list = new List<char>()
        {
            'A', 'a',
            'B', 'b',
            'C', 'c',
            'D', 'd',
            'E', 'e',
            'F', 'f',
            'G', 'g',
            'H', 'h',
            'I', 'i',
            'J', 'j',
            'K', 'k',
            'L', 'l',
            'M', 'm',
            'N', 'n',
            'O', 'o',
            'P', 'p',
            'Q', 'q',
            'R', 'r',
            'S', 's',
            'T', 't',
            'U', 'u',
            'V', 'v',
            'W', 'w',
            'X', 'x',
            'Y', 'y',
            'Z', 'z'
        };
        public static List<char> Alphabet52 = list;

        // methods

        public static string GenerateAddress(int length)
        {
            string address = string.Empty;

            System.Random r = new System.Random();

            for (int i = 0; i < length; i++)
            {
                address += Alphabet52[r.Next(0, 51)];
            }

            return address;
        }

        public static void Wire(ILogicGate gate1, ILogicGate gate2)
        {
            gate2.From = gate1.Address;
            gate1.To = gate2.Address;
        }

        public static void Wait(float time)
        {
            for (float i = 0; i < time; i += 600 * Time.deltaTime)
            {
                Debug.Log("Click");
            }
        }
    }
}
