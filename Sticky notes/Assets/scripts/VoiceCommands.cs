using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class VoiceCommands : MonoBehaviour
{
    private Vector3 originalPosition;
    public GameObject Notepad;
    public GameObject keyboard;
    // Use this for initialization

    

    public void editNote()
    {
        RaycastHit hitInfo;
        var layermask = 1 << 31;
        if (GazeManager.Instance.IsGazingAtObject && !GameObject.Find("KeyBoard") )
        {
            Instantiate(keyboard, Camera.main.transform.position + 2f  * Camera.main.transform.forward, Quaternion.identity).GetComponent<KeyBoardOutput>().notepad = GazeManager.Instance.HitObject ;
        }

    }

    public void makeNew()
    {
        Instantiate(Notepad, Camera.main.transform.position + 2f * Camera.main.transform.forward, Quaternion.identity);
    }
}