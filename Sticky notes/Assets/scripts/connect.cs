using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace conn
{

    public class connect
    {
        string deleteURL = "http://libanaden.com/deleteNote.php";
        string insertURL = "http://libanaden.com/insertData.php";
        string editURL = "http://libanaden.com/editnote.php";


        public void insertString(string user, string note)
        {
            WWWForm form = new WWWForm();
            form.AddField("user", user);
            form.AddField("content", note);
            WWW www = new WWW(insertURL, form);
        }

        public void deleteNote(string id)
        {
            WWWForm form = new WWWForm();
            form.AddField("id", id);
            WWW www = new WWW(deleteURL, form);
        }
		
		public void editNote(string id, string newContent)
        {
            WWWForm form = new WWWForm();
            form.AddField("id", id);
            form.AddField("content", newContent);
            WWW www = new WWW(editURL, form);
        }
    }


}