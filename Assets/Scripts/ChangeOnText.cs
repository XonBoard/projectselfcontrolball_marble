using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeOnText : MonoBehaviour
{
    public void ChangeOnNames()
    {
        Properties.ballName = gameObject.GetComponent<Text>().text;
    }
}
