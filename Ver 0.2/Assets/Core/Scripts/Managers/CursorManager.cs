using UnityEngine;

namespace DigitalCircuits.Core
{
    /// <summary>
    /// The manager class responsible for handling animation and changing of the cursor.
    /// </summary>

    public class CursorManager : MonoBehaviour
    {
        // Fields
        public Texture2D RegularCursor;
        public Texture2D ClickCursor;

        public Texture2D SolderCursor;
        public Texture2D SolderSparks;

        public Texture2D ScrewdriverCursor;

        public Texture2D WirecutterCursor;
        public Texture2D WirecutterClickCursor;

        // Update is called once per frame
        void Update()
        {
            if (ToolbarManager._instance.IsToolbarActive)
            {
                if (ToolbarManager._instance.IsSolderActive)
                {
                    Cursor.SetCursor(SolderCursor, new Vector2(150, 150), CursorMode.Auto);

                    if (Input.GetMouseButton(0))
                    {
                        // logic to create sparks for solder cursor goes here

                    }
                    else
                    {
                        // do nothing

                    }
                }
                else if (ToolbarManager._instance.IsScrewdriverActive)
                {
                    // logic to manage cursor goes here
                    Cursor.SetCursor(ScrewdriverCursor, new Vector2(150, 150), CursorMode.Auto);


                }
                else if (ToolbarManager._instance.IsWirecutterActive)
                {
                    // logic to manage wirecutter cursor
                    if (Input.GetMouseButton(0))
                        Cursor.SetCursor(WirecutterClickCursor, new Vector2(0, 0), CursorMode.Auto);
                    else
                        Cursor.SetCursor(WirecutterCursor, new Vector2(0, 0), CursorMode.Auto);

                }
                else if (ToolbarManager._instance.IsWireActive)
                {
                    // logic to manage cursor goes here

                }
            }
            else
            {
                if (Input.GetMouseButton(0))
                    Cursor.SetCursor(ClickCursor, new Vector2(150, 150), CursorMode.Auto);
                else
                    Cursor.SetCursor(RegularCursor, new Vector2(150, 150), CursorMode.Auto);
            }
        }
    }
}