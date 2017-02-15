using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace dbconnect1
{


    public class dbconnect : MonoBehaviour
    {
        string InsertNumberURL = "http://libanaden.com/InsertNumber.php";

        public string InsertNumber(string data)
        {
            string[] inputSplit = data.Split('+');
            string number1 = inputSplit[0];
            string number2 = inputSplit[1];
            int sum = Int32.Parse(number1) + Int32.Parse(number2);
            string summa = sum.ToString();
            WWWForm form = new WWWForm();
            form.AddField("number1Post", number1);
            form.AddField("number2Post", number2);
            WWW www = new WWW(InsertNumberURL, form);
            return summa;
        }

    }
}
