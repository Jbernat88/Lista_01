using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex01 : MonoBehaviour
{
    public TextMeshProUGUI textTMP;

    private int minNumber = 0;
    private int maxNumber = 10;

    // Generate a random number using the variables.

    public void RandomNumber()
    {
        // Show the value on the screen.
        textTMP.text = Random.Range(minNumber, maxNumber).ToString();
    }
}
