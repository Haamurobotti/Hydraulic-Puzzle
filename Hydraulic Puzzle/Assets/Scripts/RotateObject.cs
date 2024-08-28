using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 15f;
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("e"))
        {
            this.transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey("q"))
        {
            this.transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }
}
