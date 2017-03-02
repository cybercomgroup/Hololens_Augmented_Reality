using UnityEngine;
using System;
using HoloToolkit.Unity.InputModule;
using UnityEngine.UI;
using conn;
using selectnotes;
using System.Collections.Generic;

public class VoiceCommands : MonoBehaviour
{
    public GameObject Notepad;
    public GameObject keyboard;
    public static bool keyboardCreated = false;
    private connect dbconnection;
    private select dbselect;

    // Use this for initialization

    public void Start()
    {
        dbconnection = new connect();
        dbselect = new select();
        
    }

    public void editNote()  
    {
        if (GazeManager.Instance.IsGazingAtObject && !keyboardCreated)
        {
            keyboardCreated = true;
            KeyBoardOutput.createKeyboard(GazeManager.Instance.HitObject.transform.GetChild(0).GetChild(0).gameObject);
        }

    }

    public void makeNew()
    {
        StartCoroutine(dbconnection.insertString((id) =>
        {
            GameObject notepad = Instantiate(Notepad, Camera.main.transform.position + 2f * Camera.main.transform.forward , Quaternion.identity) as GameObject;
            notepad.transform.rotation = Quaternion.LookRotation(Camera.main.transform.position);
            notepad.GetComponentInChildren<NoteCommands>().noteId = Int32.Parse(id);
        }, ""));

    }

    public void deleteNote()
    {
        if (GazeManager.Instance.IsGazingAtObject)
        {
            Destroy(GazeManager.Instance.HitObject.gameObject);
        }
        dbconnection.deleteNote(GazeManager.Instance.HitObject.GetComponentInChildren<NoteCommands>().noteId.ToString());
    }

    public void getNotes()
    {
        StartCoroutine(dbselect.Start1((note) => {
            GameObject notepad;
            for (int i = 0; i < note.Notes.Count; i++)
            {
                notepad = Instantiate(Notepad, Camera.main.transform.position + Camera.main.transform.right * (0.3f * i) + 2f * Camera.main.transform.forward, Quaternion.identity) as GameObject;
                notepad.transform.GetChild(0).GetChild(0).GetComponentInChildren<Text>().text = note.Notes[i].content;
                notepad.GetComponentInChildren<NoteCommands>().noteId = i + 1;
            }
        }));
      

    }
}
