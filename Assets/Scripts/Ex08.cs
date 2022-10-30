using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Text.RegularExpressions;

public class Ex08 : MonoBehaviour
{
    public TMP_InputField username;
    public TextMeshProUGUI message;
   
    public void ConfirmUsername()
    {
        // Vertify if the input field is empty.
        if (!(username.text==""))
        {
            // Displays a message on the screen.
            message.text = "Hello " + username.text + ", welcome to this amazing adventure!";
        }
    }
}
