using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex07 : MonoBehaviour
{
    public GameObject sphere;

    private Material sphereMat;

    private void Start()
    {
        // Gets the material from the renderer component.
        sphereMat = sphere.GetComponent<Renderer>().material;
    }

    // The Slider change the transparency of the Sphere .
    public void SphereAlpha(float value)
    {
        sphereMat.color = new Vector4(sphereMat.color.r, sphereMat.color.g, sphereMat.color.b, value);
    }
}
