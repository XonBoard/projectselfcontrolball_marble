using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSelf : MonoBehaviour
{
    //public List<GameObject> points = new List<GameObject>();
    public GameObject[] points;
    bool go = false;
    public Rigidbody rb;
    public int index = 0;
    public float speed1 = 5f;
    void Start()
    {
        // DetectPoints();
    }
    // Update is called once per frame
    void Update()
    {
        if (!go)
        {
            transform.position = Vector3.MoveTowards(transform.position, points[index].transform.position, Time.unscaledDeltaTime * speed1  ) ;

            if (Vector3.Distance(transform.position, points[index].transform.position) < 0.3)
            {
                //transform.LookAt(points[index].transform);
                //Debug.Log(index);
                go = true;
            }
           

        }

        if (go && index < points.Length)
        {
            index++;

            go = false;
        }

        if (index >= points.Length)
        {
            go = true;
        }
        if (index == 29)
        {
            rb.useGravity = true;
            index = 0;
            //Debug.LogError("Index is now zero");
            gameObject.GetComponent<MoveSelf>().enabled = false;
        }

        if(gameObject.GetComponent<pusher>().tries >1)
        {
            index = 0;
            go = true;
            gameObject.GetComponent<pusher>().tries = 0;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "pointS2")
        {
            index = 0;
            go = true;
            //Debug.LogError("Index is now zero");

        }
    }
    //public void DetectPoints()
    //{
    //    GameObject[] myPoints = GameObject.FindGameObjectsWithTag("point");

    //    for (int i = 0; i < myPoints.Length; i++)
    //    {
    //        if (myPoints[i].name == "p")
    //        {
    //            points.Add(myPoints[0]);
    //        }

    //        if (myPoints[i].name == "p (" + i + ")")
    //        {
    //            points.Add(myPoints[i]);
    //            //points.Insert
    //        }
    //    }
    //}
}
