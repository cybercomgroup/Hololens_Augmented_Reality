using UnityEngine;
using dbconnect1;

public class ButtonCommands : MonoBehaviour
{
    Vector3 originalPosition;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        originalPosition = this.transform.localPosition;
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {

        TextMesh textObject = GetComponentInChildren<TextMesh>();
        TextMesh display = GameObject.Find("Display").GetComponentInChildren<TextMesh>();
        string tal = display.text + textObject.text;
        display.text = tal;

    }
}