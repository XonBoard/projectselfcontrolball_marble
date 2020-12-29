using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ignore : MonoBehaviour
{
    
    public Collider C; //collider of the bucket
    public Collider P;
    private float ttime1 = 1.3f; //timer of the bucket
    public bool cf = false; //coinflip detector
    public Text txt1; //UI text 
    public float UserTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        //Reset();
    }
    //public void Reset()
    //{
    //    _slider.minValue = Time.time;
    //    _slider.maxValue = Time.time + ttime1;
    //}

    // Update is called once per frame
    //control the bucket system
    void Update()
    {

        //StartCoroutine(Ig()); 
        
        Physics.IgnoreCollision(P, C, false);
        UserTimer +=Time.unscaledDeltaTime;
        if (UserTimer > ttime1)
        {
            Physics.IgnoreCollision(P, C, true);
            txt1.text = ttime1.ToString("F1");

        }
        if (UserTimer > ttime1 + 2)
        {
            UserTimer = 0;
        }
        Debug.LogError(UserTimer);

    }

    //IEnumerator Ig()
    //{
    //    Physics.IgnoreCollision(P, C, false);
    //    yield return new WaitForSecondsRealtime(ttime1);
    //    Physics.IgnoreCollision(P, C, true);
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "flip")
        {
            txt1.text = " ";

        }
        if (other.tag == "flip" && cf == true)
        {
            ttime1 = 2.3f;
            if (Random.value <= 0.5f) //Random value for the coin flip
            {
                ttime1 = 2.3f;
            }
            if (Random.value > 0.5f)
            {
                ttime1 = 0.3f;

            }
        }
        if (other.name == "pointD")
        {
            UserTimer = 0;
            Physics.IgnoreCollision(P, C, false);

        }
    }
}
