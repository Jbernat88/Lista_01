using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Ex02 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;
    public int number;

    void Update()
    {
        // If we press the space key the function is activated.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If the remainder is 0, divide the number and the divisor.
            if (number % 2 == 0)
            {
                //Show a message on the screen.
                textTMP.text = number + " is EVEN";
            }
            else
            {
                // Show a message on the screen.
                textTMP.text = number + " is ODD";
            }
        }
    }
}
