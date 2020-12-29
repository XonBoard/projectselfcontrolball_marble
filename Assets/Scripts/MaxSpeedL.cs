using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeedL : MonoBehaviour
{
    public Rigidbody rb;
    public float MaxL = 1.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector3.ClampMagnitude(rb.velocity, MaxL);
    }
}
