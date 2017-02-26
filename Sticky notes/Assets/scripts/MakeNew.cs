using UnityEngine;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;

public class MakeNew : MonoBehaviour
{
    private Vector3 originalPosition;
    public GameObject Notepad;
    // Use this for initialization
    void Start()
    {
    

    }

    public void makeNew()
    {
        Instantiate(Notepad, Camera.main.transform.forward, Quaternion.identity);
    }
}