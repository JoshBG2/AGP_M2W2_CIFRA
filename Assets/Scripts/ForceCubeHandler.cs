using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceCubeHandler : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody rb;

    void Update()
    {
        rb = GetComponent<Rigidbody>();

        // Cube Movement
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);   
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Vector3 forceDirection = new Vector3(0f,8f,-20f);

            // Apply a force in the opposite direction
            rb.AddForce(forceDirection, ForceMode.Impulse);
        }
    }
}
