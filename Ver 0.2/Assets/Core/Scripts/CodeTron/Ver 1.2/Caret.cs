using UnityEngine;
using TMPro;

public class Caret : MonoBehaviour
{
    public TMP_Text TextObject;
    public GameObject Cursor;
    public float CursorDelay = 0.3f;
    public Vector3 CursorOffset;

    private string _msg = "";
    private float _timer = 0f;

    private void Update()
    {
        //update msg
        foreach (char c in Input.inputString)
        {
            if (c == '\b') // has backspace/delete been pressed?
            {
                if (_msg.Length != 0)
                {
                    _msg = _msg.Substring(0, _msg.Length - 1);
                }
            }
            else if ((c == '\n') || (c == '\r')) // enter/return
            {
                _msg += "\r\n";
            }
            else
            {
                _msg += c;
            }
        }

        TextObject.text = _msg;

        // place cursor

        //do blink
        _timer += Time.deltaTime;
        if (_timer > CursorDelay)
        {
            _timer = 0f;
            Cursor.SetActive(!Cursor.activeSelf);
        }
    }

}