using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameCounter : MonoBehaviour
{
    public int i;
    public bool endit;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            i++;
            Debug.Log("endcount");
        }
        if (i == 6)
        {
            endit = true;
            Debug.Log("end it dude.");
        }
    }
}
