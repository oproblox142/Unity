using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class falling : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;

    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rigidbody = GetComponent<Rigidbody>();        
        rigidbody.useGravity = false;

        transform.Translate(Random.Range(-0.1f, 0.1f), 0, Random.Range(-0.1f, 0.1f));
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait) {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }

}
