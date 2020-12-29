using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicCam : MonoBehaviour
{
    public GameObject player; //Selected Marble
    public Vector3 offset; //offsets the cam away from the marble

    //creates the offset depending on location
    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    //follows the Marble with offset in mind.
    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}

