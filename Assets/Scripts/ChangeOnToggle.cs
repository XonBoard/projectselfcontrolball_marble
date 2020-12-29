using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeOnToggle : MonoBehaviour
{
    public void OnChange()
    {
        if(gameObject.GetComponent<Toggle>().isOn)
        {
            Properties.check = gameObject.GetComponentInChildren<Text>().text;
            gameObject.GetComponentInParent<ChangeOnText>().ChangeOnNames();
            Properties.change = true;
        }
    }
}
