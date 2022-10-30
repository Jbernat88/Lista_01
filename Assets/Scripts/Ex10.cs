using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex10 : MonoBehaviour
{
    public TextMeshProUGUI points;

    private int score = 0;

    // Adds +1 to the score.
    public void AddPoint()
    {
        score++;

        points.text = "Points: " + score.ToString();
    }
}
