using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alternator : MonoBehaviour
{
    public Collider C;
    public KeyCode Bucket;
    public KeyCode Bucket_;
    public float ttime;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(Io());

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Io());
        if (Input.GetKeyDown(Bucket))
        {
            ttime = 1;
        }
        if (Input.GetKeyDown(Bucket_))
        {
            ttime = 1.5f;
        }
        Debug.Log(ttime);
    }

    IEnumerator Io()
    {


        C.enabled = true;
        yield return new WaitForSecondsRealtime(ttime);
        C.enabled = false;
        //yield return new WaitForSecondsRealtime(3);
        //yield return null;



    }
}
