using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool isFlat = true;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 tilt = Input.acceleration;

        if(isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        rb.AddForce(tilt);
    }
}
