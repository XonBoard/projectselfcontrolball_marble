using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class positioning : MonoBehaviour
{
    //scoreboard Controller 
    public GameObject[] dispos;
    private int counter = 0,i = 0;
    private bool rep = false;

    // Update is called once per frame
    void Update()
    {
        //counter = i + 1;
        for (counter = 0; counter <= 5; counter++)
        {
            for (int j = counter; j <= 5; j++)
            {
                if (dispos[counter].GetComponent<Text>().text == dispos[j].GetComponent<Text>().text)
                {
                    rep = true;
                    Debug.Log(dispos[counter].GetComponent<Text>().text);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            dispos[i].GetComponent<Text>().text = other.name;
            i++;

        }
        if (i == 6)
            i = 0;
    }
}
