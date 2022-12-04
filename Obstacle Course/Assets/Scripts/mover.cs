using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;

    Rigidbody rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 1) {
            rbody.AddForce(transform.right * moveSpeed);
        }
        if (Input.GetAxisRaw("Horizontal") == -1) {
            rbody.AddForce(-transform.right * moveSpeed);
        }
        if (Input.GetAxisRaw("Vertical") == 1) {
            rbody.AddForce(transform.forward * moveSpeed);
        }
        if (Input.GetAxisRaw("Vertical") == -1) {
            rbody.AddForce(-transform.forward * moveSpeed);
        }
    }
}
