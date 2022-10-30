using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex10_1 : MonoBehaviour
{
    private Ex10 manager;

    private void Start()
    {
        // Gets the main script.
        manager = FindObjectOfType<Ex10>();
    }

    // If the mouse is over the GameObject.
    private void OnMouseDown()
    {
        // Add point to score.
        manager.AddPoint();

        // Destroy the GameObject.
        Destroy(gameObject);
    }
}
