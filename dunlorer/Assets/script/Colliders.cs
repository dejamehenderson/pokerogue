using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
  // Example of adding a Box Collider in Unity
    void Start() 
    {
    BoxCollider boxCollider = gameObject.AddComponent<BoxCollider>();
    // Adjust the size and center if necessary
    boxCollider.size = new Vector3(1, 0.2f, 1); // Example dimensions
    boxCollider.center = new Vector3(0, 0.1f, 0); // Example center
    }

// Example of checking collision settings
    void OnControllerColliderHit(ControllerColliderHit hit) 
    {
    if (hit.gameObject.CompareTag("Stairs")) {
        // Handle stair collision
    }
    }



}
