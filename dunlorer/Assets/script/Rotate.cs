using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour

{

    public float rotateSpeed = 5f; // A var to augment the rotation speed of this pickup
    
  private void Update()
    {
        // Every frame, make this pickup rotate
        transform.Rotate(new Vector3(15, 30, 45) * rotateSpeed * Time.deltaTime);
    }
}
