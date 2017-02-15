using UnityEngine;
using dbconnect1;
public class Equal : MonoBehaviour
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
        TextMesh display = GameObject.Find("Display").GetComponentInChildren<TextMesh>();

        dbconnect db = new dbconnect();
        display.text = db.InsertNumber(display.text.ToString());
       
       
    }
}