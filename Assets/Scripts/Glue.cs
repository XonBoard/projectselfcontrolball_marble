using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glue : MonoBehaviour
{
    public Transform target;
    public float step;
    public Vector3 offset;
    public float distrance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position + offset ,step);
        //transform.LookAt(target.transform,Vector3.forward);
        
        if (Vector3.Distance(transform.position, target.position) > distrance)
        {
            transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * 2);
            transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime * 2);
        }

    }
}
