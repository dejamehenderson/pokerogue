using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    Light light;
    
    void Start()
    {

        light = GetComponent<Light>();
    }

    
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            light.enabled = !light.enabled;
        }
    } 
      

}
