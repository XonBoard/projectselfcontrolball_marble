using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tcolor : MonoBehaviour
{
    public Color myColor;
    public TrailRenderer tr;
    
    // Start is called before the first frame update
    void Start()
    {
        tr.material.SetColor("_EmissionColor", myColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
