using UnityEngine;
using UnityEngine.UI;

public class NoteCommands : MonoBehaviour
{
    Vector3 originalPosition;
    TouchScreenKeyboard keyboard;
    public static string keyboardText = "";


    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        //originalPosition = this.transform.localPosition;
        //keyboard = new TouchScreenKeyboard("", TouchScreenKeyboardType.Default, false, false, false, false, "Write here");
    }

    // Called by GazeGestureManager when the user performs a Selsect gesture
    void OnSelect()
    {
        keyboard = TouchScreenKeyboard.Open("madafaka", TouchScreenKeyboardType.Default, false, false, false, false);

    }

    private void Update()
    {
        if (TouchScreenKeyboard.visible == false && keyboard != null)
        {
            if (keyboard.done == true)
            {
                keyboardText = keyboard.text;
                keyboard = null;
            }
        }
        Text textObject = GetComponentInChildren<Text>();
        textObject.text = keyboardText;
    }
}