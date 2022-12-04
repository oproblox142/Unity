using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    Rigidbody rbody;
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rbody.AddTorque(transform.up * 1, ForceMode.Acceleration);
    }
}
