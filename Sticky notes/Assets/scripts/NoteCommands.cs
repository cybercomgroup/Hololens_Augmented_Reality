using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class NoteCommands : MonoBehaviour, IInputClickHandler
{
    private Vector3 originalPosition;
    private GameObject move;
    private GameObject edit;
    public GameObject keyboard;
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
        keyboard.SetActive(true);
    }
}