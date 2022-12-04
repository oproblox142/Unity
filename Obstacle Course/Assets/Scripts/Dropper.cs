using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigid;
    [SerializeField] float TimeWanted = 3f;
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rigid = GetComponent<Rigidbody>();
        render.enabled = false;
        rigid.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > TimeWanted) {
            render.enabled = true;
            rigid.useGravity = true;
        }
    }
}
