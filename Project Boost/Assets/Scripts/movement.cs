using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] int thrust = 500;
    [SerializeField] int rotater = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        ProcessRotate();
        ProcessThrust();
    }
    void ProcessRotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            ApplyRotate(rotater);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            ApplyRotate(-rotater);
        }
    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            rb.AddRelativeForce(0,thrust * Time.deltaTime,0);
        }
    }
    
    void ApplyRotate(float rotater) 
    {
        rb.freezeRotation = true; //freeze rotation for manual rotate
        transform.Rotate(Vector3.forward * rotater * Time.deltaTime);
        rb.freezeRotation = true; //vis versa
    }
}
