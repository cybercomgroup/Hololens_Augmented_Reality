using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class KeyBoardOutput : MonoBehaviour {
    GameObject keyboardText;
    private char cursor = '|';
    private float blink_TimeStamp;
    private bool cursing = true;
    private bool typing = false;

    // Update is called once per frame
    public void OnClick () {
        typing = true;
        Text Letter = GetComponentInChildren<Text>();
        keyboardText = GameObject.Find("KeyboardText");
        string text = keyboardText.GetComponentInChildren<Text>().text;
        if (text.Length > 0)
        {
            text = text.Substring(0, text.Length - 1);
        }
        if (Letter.text.Equals("Space")) {
            keyboardText.GetComponentInChildren<Text>().text = text + " " + cursor;
        } else {
            keyboardText.GetComponentInChildren<Text>().text = text + Letter.text + cursor;
        }
	}

    public void Enter() {
       keyboardText = GameObject.Find("KeyboardText");
       Text NotepadText = GameObject.FindWithTag("NoteText").GetComponentInChildren<Text>();
       NotepadText.text = keyboardText.GetComponentInChildren<Text>().text;
        GameObject.FindWithTag("KeyboardCanvas").SetActive(false);
    }

    public void changeCase() {
        GameObject keyboard = GameObject.Find("Keyboard");
        Text[] hello = keyboard.GetComponentsInChildren<Text>();
        for(int i = 0; i < hello.Length; i++) {
            if (Regex.Matches(hello[i].text, @"[a-zåäö]").Count == 1) {
                hello[i].text = hello[i].text.ToUpper();
            } else {
                hello[i].text = hello[i].text.ToLower();
            }
        }
    }

    public void backSpace()
    {
        keyboardText = GameObject.Find("KeyboardText");
        if (keyboardText.GetComponentInChildren<Text>().text.Length != 0)
        {
            string text = keyboardText.GetComponentInChildren<Text>().text;
            text = text.Substring(0, text.Length - 1);
            keyboardText.GetComponentInChildren<Text>().text = text;
        } else {
            Debug.Log("Textfield Empty");
        }
    }

    public void newRow()
    {
        keyboardText = GameObject.Find("KeyboardText");
        keyboardText.GetComponentInChildren<Text>().text = keyboardText.GetComponentInChildren<Text>().text + '\n'; 
    }

   IEnumerator typingCursorDelay()
    {
        yield return new WaitForSeconds(1);
        typing = false;

    }

    public void Update()
    {
        /*if(typing == true)
        {
            typingCursorDelay();
        }
        if(Time.time - blink_TimeStamp >= 0.5 && typing == false)
        {
            blink_TimeStamp = Time.time;
            keyboardText = GameObject.Find("KeyboardText");
            string text = keyboardText.GetComponentInChildren<Text>().text;
            if (text.Length > 0 && cursing == true)
            {
                cursing = false;
                text = text.Substring(0, text.Length - 1);
                keyboardText.GetComponentInChildren<Text>().text = text;
            } else
            {
                cursing = true;
                if(!keyboardText.GetComponentInChildren<Text>().text.Contains("|"))
                {
                    keyboardText.GetComponentInChildren<Text>().text += cursor;
                }  
            }
        }*/
    }

}
