using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DigitalCircuits.Core.CodeTRON
{
    /// <summary>
    /// A class for providing pop-out functionality for the CodeTRON.
    /// </summary>

    public class Extendable : MonoBehaviour
    {
        public bool IsExtended;

        public void OnMouseDown()
        {
            // open
            if (gameObject.GetComponent<RectTransform>().anchoredPosition.y == -680.0f)
            {
                for (int i = 0; i < 13; i++)
                    gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(0f, 25f);

                IsExtended = true;
            }
            // close
            else if (gameObject.GetComponent<RectTransform>().anchoredPosition.y == -355.0f)
            {
                for (int i = 0; i < 13; i++)
                    gameObject.GetComponent<RectTransform>().anchoredPosition += new Vector2(0f, -25f);

                IsExtended = false;
            }

        }
    }
}
