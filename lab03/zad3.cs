using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad3 : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Update()
    {

        //rb.constraints = RigidbodyConstraints.FreezeRotationX;
        //rb.constraints = RigidbodyConstraints.FreezeRotationY;
        if (rb.velocity.y == 0 && rb.velocity.x == 0 && rb.velocity.z == 0)
        {
            rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
            rb.transform.Rotate(0, 0, 90, Space.Self);
        }
    }

}
