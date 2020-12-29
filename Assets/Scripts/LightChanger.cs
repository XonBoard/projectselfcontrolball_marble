using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChanger : MonoBehaviour
{
    public GameObject Red;
    public GameObject Green;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Starter());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator Starter()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(3);
        Red.SetActive(false);
        Green.SetActive(true);
        Time.timeScale = 4;
        GameObject.Find("SceneManager").GetComponent<Timer>().enabled = true;
    }
}
