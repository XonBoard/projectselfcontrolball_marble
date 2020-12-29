using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGameCounter : MonoBehaviour
{
    public int i,lap = 0;
    public bool lapit = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            i++;
            
        }
        if (i == 6)
        {
            i = 0;
            lap += 1;
            Debug.Log(lap);
        }
        if (lap == 6)
        {
            lapit = true;
        
        }
    }
}
