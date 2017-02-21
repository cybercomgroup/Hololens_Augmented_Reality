using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class KeyboardButton : MonoBehaviour, IInputClickHandler
{
    Vector3 originalPosition;
    public GameObject keyboard;
    // Use this for initialization
    void Start()
    {
        //keyboard = GameObject.Find("KeyboardCanvas");
    }

    public virtual void OnInputClicked(InputEventData eventData)
    {
        Debug.Log("Clicked for keyboard");
        keyboard.SetActive(true);
    }
}