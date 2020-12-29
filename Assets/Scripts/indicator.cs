using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indicator : MonoBehaviour

{
    public GameObject target;
    public Vector3 offset;
    public Vector3 rt;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
        transform.Rotate(rt, 30f);
    }
}
