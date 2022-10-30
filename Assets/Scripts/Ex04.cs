using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex04 : MonoBehaviour
{
    public GameObject sphere;

    // Change the scale of the object.
    public void SphereScale(float value)
    {
        sphere.transform.localScale = new Vector3(value, value, value);
    }
}
