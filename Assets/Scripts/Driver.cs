using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public Rigidbody rb;
    private bool z0, z1, x0, x1,xx1,xx0,zz1,zz0;
    public float x, z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (z0)
        {
            rb.AddForce(x, 0, z,ForceMode.Force);
        }
        if(z1)
        {
            z0 = false;

        }
        if (x0)
        {
            rb.AddForce(x, 0, z); 
        }
        if(x1)
        {
            x0 = false;
        }
        if (zz0)
        {
            rb.AddForce(x, 0, z);
        }
        if (zz1)
        {
            zz0 = false;
        }
        if (xx0)
        {
            rb.AddForce(x, 0, z);
        }
        if (xx1)
        {
            xx0 = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "pointx1")
        {
            x1 = true;
        }
        if (other.name == "pointx0")
        {
            x0 = true;

        }
        if (other.name == "pointz1")
        {
            z1 = true;
        }
        if (other.name == "pointz0")
        {
            z0 = true;
        }
        if (other.name == "pointxx1")
        {
            xx1 = true;
        }
        if (other.name == "pointxx0")
        {
            xx0 = true;

        }
        if (other.name == "pointzz1")
        {
            zz1 = true;
        }
        if (other.name == "pointzz0")
        {
            zz0 = true;
        }
    }
}
