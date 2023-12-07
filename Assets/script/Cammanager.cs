using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammanager : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cam1.enabled = false;
            cam3.enabled = false;
            cam2.enabled = true;
            cam2.fieldOfView = 10f;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            cam1.enabled = false;
            cam3.enabled = true;
            cam2.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam1.enabled = true;
            cam3.enabled = false;
            cam2.enabled = false;
        }
    }
}
