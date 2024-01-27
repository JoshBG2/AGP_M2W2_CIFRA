using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCubeHandler : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Color collisionColor = Color.blue; 

    private bool hasCollided = false;

    void Update()
    {
        // Cube Movement
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (!hasCollided && other.CompareTag("Wall"))
        {
            ChangeColor();
            hasCollided = true;
        }
    }

    void ChangeColor()
    {
        // Change Cube Color
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.color = collisionColor;
    }
}
