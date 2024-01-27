using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastCubeHandler : MonoBehaviour
{
    public float raycastDistance = 2f;

    public float moveSpeed = 5f;
    
    void Update()
    {
        // Cube Movement
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Setting Raycast
        RaycastHit hit;

        // Raycast detection
        Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.green);

        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastDistance))
        {
            if (hit.collider.CompareTag("Wall"))
            {
                Destroy(hit.collider.gameObject);
            } 
        }
    }
}
