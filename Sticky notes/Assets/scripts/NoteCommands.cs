using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class NoteCommands : MonoBehaviour, IInputClickHandler
{
    Vector3 originalPosition;
    GameObject move;
    GameObject edit;
    GameObject keyboard;
    // Use this for initialization
    void Start()
    {
        move = GameObject.Find("MoveCanvas");
        move.SetActive(false);
        edit = GameObject.Find("EditCanvas");
        edit.SetActive(false);
        keyboard = GameObject.Find("KeyboardCanvas");
        keyboard.SetActive(false);

    }

    public virtual void OnInputClicked(InputEventData eventData)
    {
        Debug.Log("Clicked for menu");
        move.SetActive(true);
        edit.SetActive(true);
    }
}