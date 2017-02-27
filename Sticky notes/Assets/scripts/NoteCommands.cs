using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class NoteCommands : MonoBehaviour, IInputClickHandler
{
    private Vector3 originalPosition;
    private GameObject move;
    // Use this for initialization
    void Start()
    {

    }

    public virtual void OnInputClicked(InputEventData eventData)
    {
        Debug.Log("Clicked for menu");
        move.SetActive(true);
   }
}