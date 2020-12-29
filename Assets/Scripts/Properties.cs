using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Properties : MonoBehaviour
{
    public GameObject  C2, C3, t, l;
    public GameObject camsis;
    public Camera Choosercam;
    public GameObject[] players;
    public int index = 0;
    public GameObject rank;
    private bool s = true;
    public Text[] txt;
    public static string check = "";
    public static string ballName = "";
    public static bool change = false;
    public float mas = 1f, drac = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (change)
        {
            ApplyChanges();
            change = false;
        }
    }
    public void StartGame()
    {

        C2.SetActive(true);
        C3.SetActive(true);
        //t.GetComponent<Timer>().enabled = true;
        l.GetComponent<LightChanger>().enabled = true;
        camsis.SetActive(true);
        Choosercam.enabled = false;
        StartCoroutine(Is());
        s = false;
    }
    public void ApplyChanges()
    {
        Debug.Log(check);
        if (check == "Berzerker")
        {
            berzerker();
            GameObject.Find(ballName).GetComponent<Transform>().localScale = new Vector3 (0.18f, 0.18f, 0.18f);
            Debug.Log(ballName);

        }
        if (check == "Lightning")
            lightning();
        if (check == "CoinFlip")
            coinflip();
        if (check == "FatAss")
            fatass();
        if (check == "Nitro")
            Nitro();
        
    }

    public void fatass()
    {
        //players[index].GetComponent<Rigidbody>().mass += 0.1f;
        //players[index].GetComponent<Rigidbody>().drag += 0.05f;
        GameObject.Find(ballName).GetComponent<Rigidbody>().mass = 0.2f;
        GameObject.Find(ballName).GetComponent<Rigidbody>().drag = 0.045f;
        GameObject.Find(ballName).GetComponent<MaxSpeedF>().enabled = true;
        GameObject.Find(ballName).GetComponent<MaxSpeedS>().enabled = false;


    }
    public void lightning()
    {
        //GameObject.Find(ballName).GetComponent<Rigidbody>().velocity = Vector3.ClampMagnitude(GameObject.Find(ballName).GetComponent<Rigidbody>().velocity, 0.1f);
        GameObject.Find(ballName).GetComponent<Rigidbody>().drag = 0;
        GameObject.Find(ballName).GetComponent<MaxSpeedL>().enabled = true;
        GameObject.Find(ballName).GetComponent<MaxSpeedS>().enabled = false;


        Debug.Log(ballName);



    }
    public void coinflip()
    {

        GameObject.Find(ballName).GetComponent<Ignore>().cf = true;
        //if (Random.value < .5)
        //{
        //    GameObject.Find(ballName).GetComponent<Ignore>().ttime1 += 0.1f;
        //}
        //else
        //{
        //    GameObject.Find(ballName).GetComponent<Ignore>().ttime1 -= 0.1f;
        //}
        Debug.Log(ballName);


    }
    public void berzerker()
    {
        GameObject.Find(ballName).GetComponent<Transform>().localScale = new Vector3(0.186f, 0.186f, 0.186f);
        Debug.Log(ballName);
    }
    public void Nitro()
    {
        GameObject.Find(ballName).GetComponent<pusher>().ntro = true;
        Debug.Log("0");
    }
    IEnumerator Is()
    {
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 2.5f;
    }



}

