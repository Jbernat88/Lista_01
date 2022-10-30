using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ex09 : MonoBehaviour
{
    public GameObject pointLight;

    public void OnOff(bool isOn)
    {
        // If is ON
        if (isOn)
        {
            // Enable the Point Light.
            pointLight.GetComponent<Light>().enabled = true;
        }
        else
        {
            // Disable the Point Light.
            pointLight.GetComponent<Light>().enabled = false;
        }
    }
}