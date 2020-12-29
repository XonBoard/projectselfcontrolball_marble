using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfController : MonoBehaviour
{
    public GameObject point;
    public GameObject point2;
    bool go = false;
    bool more = false;
    Vector3 next;
    void Start()
    {
        
    }


    void Update()
    {
        next = SetNextPoint(0);
        next = SetNextPoint(1);
        if (!go)
        {
            
            
            go = true;
        }
        if (transform.position.z >= next.z && !more)
        {
            Debug.Log("stop");

            
            

            Debug.Log("x= "+next.x+"\ty= "+ next.y+"\tz= "+ next.z);
            more = true;
        }


        //if (go && !more)
        //{
        //    next = SetNextPoint(1);
        //    more = false;
        //}

        //float step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.Lerp(transform.position, next, Time.deltaTime * 2);
        //transform.Translate(/*point.transform.position*/Vector3.MoveTowards (next) * Time.deltaTime * 0.1f, Space.World);
    }

    Vector3 SetNextPoint(int i)
    {
        Vector3 target;
        if (i == 0)
        {
            target = new Vector3(point.transform.position.x, transform.position.y, point.transform.position.z);
            transform.LookAt(target);
            
        }

        else
        {
            target = new Vector3(point2.transform.position.x, transform.position.y, point2.transform.position.z);
            transform.LookAt(target);

        }

        return target;
    }
}
