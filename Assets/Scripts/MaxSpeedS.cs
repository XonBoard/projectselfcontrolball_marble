using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeedS : MonoBehaviour
{
    public Rigidbody rb;
    public float MaxS = 1.35f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxS);
    }
}
