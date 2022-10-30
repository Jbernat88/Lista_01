using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex06 : MonoBehaviour
{
    public GameObject cylinder;

    private Material cylinderMat;

    private void Start()
    {
        // Gets the material from component.
        cylinderMat = cylinder.GetComponent<Renderer>().material;
    }

    // Change the color of cylinder.
    public void ChangeCylinderColor(int index)
    {
        switch (index)
        {
            case 0:
                cylinderMat.color = Color.white;
                break;

            case 1:
                cylinderMat.color = Color.green;
                break;

            case 2:
                cylinderMat.color = Color.black;
                break;

            case 3:
                cylinderMat.color = Color.red;
                break;

            case 4:
                cylinderMat.color = Color.yellow;
                break;

            case 5:
                cylinderMat.color = Color.blue;
                break;

            default:
                cylinderMat.color = Color.white;
                break;
        }
    }
}
