using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trailturnoff : MonoBehaviour
{
    public TrailRenderer[] rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            for (int i = 0; i < rend.Length; i++)
                rend[i].enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            for (int i = 0; i < rend.Length; i++)
                rend[i].enabled = true;
        }

    }
}
