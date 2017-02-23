using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class MakeNew : MonoBehaviour, IInputClickHandler
{
    private Vector3 originalPosition;
    public GameObject Notepad;
    // Use this for initializationS
    void Start()
    {
    

    }

    public virtual void OnInputClicked(InputEventData eventData)
    {
        Instantiate(Notepad, transform.position, Quaternion.identity);
    }
}