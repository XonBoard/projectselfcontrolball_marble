using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glue2 : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position,1);
        transform.LookAt(target.transform,Vector3.forward);

    }
}
