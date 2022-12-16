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
        StartCoroutine(ExampleCoroutine());

    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(5););
        rb.AddForce(speed, 0, 0, ForceMode.Impulse);
        yield return new WaitForSeconds(5););
        rb.transform.Rotate(90, 0, 0, Space.Self);
        yield return new WaitForSeconds(5););

        rb.AddForce(0, 0, speed, ForceMode.Impulse);
        yield return new WaitForSeconds(5););
        rb.transform.Rotate(90, 0, 0, Space.Self);
        yield return new WaitForSeconds(5););

        rb.AddForce(-1 * speed, 0, 0, ForceMode.Impulse);
        yield return new WaitForSeconds(5););
        rb.transform.Rotate(90, 0, 0, Space.Self);
        yield return new WaitForSeconds(5););

        rb.AddForce(0, 0, -1 * speed, ForceMode.Impulse);
        yield return new WaitForSeconds(5););
        rb.transform.Rotate(90, 0, 0, Space.Self);
        yield return new WaitForSeconds(5););
    }

}
