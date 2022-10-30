using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex03 : MonoBehaviour
{
    // Positions to save random values.
    private float xPosition;
    private float zPosition;
    private float yPosition;
    //Range
    private float xRange = 5f; //Range X
    private float yRange = 5f; //Range Y
    private float zRange = 1f; //Range Z

    void Update()
    {
        // If we press the space key the function is activated.
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Genera valores aleatorios dentro de los límites.
            xPosition = Random.Range(-xRange, xRange);
            yPosition = Random.Range(-yRange, yRange);
            zPosition = Random.Range(-zRange, zRange);

            // Moves the object to a random position.
            transform.position = new Vector3(xPosition, yPosition, zPosition);
        }
    }
}
