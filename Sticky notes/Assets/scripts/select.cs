using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

/**
 * author anders huynh
 * 
 **/


namespace sellect
{

    [System.Serializable]

    public class Notelist
    {
        public List<Note> Notes;
        public static Notelist CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<Notelist>(jsonString);
        }
    }


    [System.Serializable]

    public class Note
    {
        public string id;
        public string content;
        public string user;

        public static Note CreateFromJSON(string jsonString)
        {
            return JsonUtility.FromJson<Note>(jsonString);
        }
    }


    public class select : MonoBehaviour
    {
        public Text txt;
        string url = "http://libanaden.com/selectAll.php";

        public IEnumerator Start1()
        {
            WWW www = new WWW(url);
            yield return www;
            if (www.error == null)
            {
                Notelist list = Notelist.CreateFromJSON(www.text);
                for (int i = 0; i < list.Notes.Count; i++)
                {
                    Debug.Log(list.Notes[i].content);
                }
            }

            else
            {
                Debug.Log("ERROR: " + www.error);
            }
        }

    }

}
