using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeedF : MonoBehaviour
{
    public Rigidbody rb;
    public float Maxf = 1.5f;//max speed variable
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, Maxf);
    }
}
