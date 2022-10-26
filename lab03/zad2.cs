using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad2 : MonoBehaviour
{
    public float speed = 10.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(speed, 0, 0, ForceMode.Impulse);
    }
    void FixedUpdate()
    {
            if (rb.velocity.x == 0)
            {
                rb.AddForce(speed * -1, 0, 0, ForceMode.Impulse);
                
            }
        
       
    }
}
