using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class KeyBoardOutput : MonoBehaviour {
    GameObject keyboardText;
    private string cursor = "|";
    private float blink_TimeStamp;
    private bool cursing = true;
    private bool typing = false;
    private bool symbol = false;

    // Update is called once per frame
    public void Start()
    {
        keyboardText = GameObject.Find("KeyboardText");
        keyboardText.GetComponentInChildren<Text>().text = cursor;
    }

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
        GameObject keyboard = GameObject.Find("KeyboardCanvas");
        Text[] hello = keyboard.GetComponentsInChildren<Text>();
        for(int i = 0; i < hello.Length; i++) {
            if (Regex.Matches(hello[i].text, @"[a-zåäö]").Count == 1) {
                hello[i].text = hello[i].text.ToUpper();
            } else {
                if(hello[i].text.Length == 1)
                    hello[i].text = hello[i].text.ToLower();
            }
        }
    }

    public void backSpace()
    {
        keyboardText = GameObject.Find("KeyboardText");
        if (keyboardText.GetComponentInChildren<Text>().text.Length != 1)
        {
            string text = keyboardText.GetComponentInChildren<Text>().text;
            text = text.Substring(0, text.Length - 2);
            keyboardText.GetComponentInChildren<Text>().text = text + cursor;
        } else {
            Debug.Log("Textfield Empty");
        }
    }

    public void newRow()
    {
        keyboardText = GameObject.Find("KeyboardText");
        string text = keyboardText.GetComponentInChildren<Text>().text;
        if (text.Length > 0)
        {
            text = text.Substring(0, text.Length - 1);
        }
        keyboardText.GetComponentInChildren<Text>().text = text + "\n" + cursor; 
    }

    public void symbols()
    {
        GameObject keyboard = GameObject.Find("KeyboardCanvas");
        string[] symbols = { "+", "*", "/", "=", "%", "_", "€", "£", "$", "[", "]", "#", "¤", "&", "(", ")", "{", "}",
                            "^", "¨", "~", "\"", "|", "´", "°", "<", ">", ";","½"};
        string[] letters = { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "å", "a", "s", "d", "f", "g", "h", "j",
                            "k", "l", "ö", "ä", "z", "x", "c", "v", "b", "n", "m"};
        Text[] hello = keyboard.GetComponentsInChildren<Text>();
        int j = 0;
        for (int i = 0; i < hello.Length; i++)
        {
            if (hello[i].transform.parent.tag == "Letter" && symbol != true)
            {
                if(symbols[j].Equals("½"))
                {
                    symbol = true;
                }
                hello[i].text = symbols[j];
                j++;
            } else if (hello[i].transform.parent.tag == "Letter")
            {
                if(letters[j].Equals("m"))
                {
                    symbol = false;
                }
                hello[i].text = letters[j];
                j++;
            }
        }
    } 

    public void navigate()
    {
        keyboardText = GameObject.Find("KeyboardText");
        string text = keyboardText.GetComponentInChildren<Text>().text;
        text = text.Substring(0, text.Length - 1);
    }

   /*IEnumerator typingCursorDelay()
    {
        yield return new WaitForSeconds(1);
        typing = false;

    }*/

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
