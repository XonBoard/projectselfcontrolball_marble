using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class pusher : MonoBehaviour
{
    public GameObject Col; //collider 
    public Collider Col2; 
    public Collider cage;
    public Text _t; //text UI 
    Vector3 v = new Vector3(0, 0, 1);
    public Rigidbody rb;
    public bool Go;
    public int tries = 0;
    private float x , z, y;
    public bool coin = false;
    public bool ntro = false;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(0f, 0, 0, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ntro);
        if (Go)
        {
            rb.AddForce(x , y, z, ForceMode.Impulse);
            Go = false;
            //Debug.Log("Trigger");
        }
        //rb.velocity = Vector3.ClampMagnitude(rb.velocity, 1.1f);

    }
    private void OnTriggerEnter(Collider other)
    {
        //nitro activation mechanism 
        if (other.tag == "flip" && ntro == true)
        {
            z = -2f;
            y = 0;
            x = 0;
            Go = true;
            ntro = false;
            Debug.Log("ntro");
        }
        if (other.name == "pointx")
        {
            x = 8f;
            y = 0;
            z = 0;
            Go = true;
            
        }
        if (other.name == "pointz")
        {
            z = 8f;
            y = 0;
            x = 0;
            Go = true;
        }
        if (other.name == "point-z")
        {
            z = -10;
            y = 0;
            x = 0;
            Go = true;
        }
        if (other.name == "point-x")
        {
            x = -5f;
            y = 0;
            z = 0;
            Go = true;
        }
        if (other.name == "point-xS")
        {
            x = -10f;
            y = 0;
            z = 0;
            Go = true;
        }
        if (other.name == "pointxS")
        {
            x = 3f;
            y = 0;
            z = 0;
            Go = true;
        }

        if (other.name == "point-zS")
        {
            x = 0;
            y = 0;
            z = -7f;
            Go = true; 
        }
        if (other.name == "pointzS")
        {
            x = 0;
            y = 0;
            z = 3f;
            Go = true;
        }
        //switches from physics to non physics
        if (other.name == "pointS")
        {
            x = 0;
            y = 0;
            z = 0f;
            rb.velocity = Vector3.zero;
            tries++;
            gameObject.GetComponent<MoveSelf>().enabled = true;
            rb.useGravity = false;
            Go = true;
        }
        if (other.name == "pointC")
        {
            x = 0;
            y = 0;
            z = 0f;
            //Col.GetComponent<Alternator>().enabled = true;
            
            Go = true;
        }
        //repairing UI text + bucket activation
        if (other.name == "pointD")
        {
            x = 0;
            y = 0;
            z = 0f;
            gameObject.GetComponent<Ignore>().enabled = true;
            _t.text = "Repairing";

            Go = true;
        }
        if (other.name == "pointC-")
        {
            x = 0;
            y = 0;
            z = 0f;
            //Col.GetComponent<Ignore>().enabled = false;
            Col2.enabled = true;
            _t.text = " ";
            Go = true;
            
        }
        //Done Massege on UI + bucket system deactivation.
        if (other.name == "pointC--")
        {
            x = 0;
            y = 0;
            z = 0f;
            gameObject.GetComponent<Ignore>().enabled = false;

            _t.text = "Done";
            Go = true;
        }
        if (other.name == "pointC0")
        {
            x = 0;
            y = 0;
            z = 0f;
            //Col.GetComponent<Alternator>().enabled = false;
            Go = true;
        }
        //switches from non physics to physics
        if (other.name == "point-z0")
        {
            x = 0;
            y = 0;
            z = 0f;
            //Debug.Log("gravity");
            gameObject.GetComponent<MoveSelf>().index = 0;
            Debug.LogError("fucking 0");
            gameObject.GetComponent<MoveSelf>().enabled = false;
            rb.useGravity = true;

            Go = true;
        }
        if (other.name == "point-zL")
        {
            x = 0;
            y = 0;
            z = -5f;
            Go = true;
        }
        if (other.name == "pointF1")
        {
            x = 0;
            y = 0;
            z = 0f;
            Physics.IgnoreCollision(gameObject.GetComponent<SphereCollider>(), cage, true);
            Go = true;
        }
        //igonre collider for bucket system.
        if (other.name == "pointF3")
        {
            x = 0;
            y = 0;
            z = 0f;
            Physics.IgnoreCollision(gameObject.GetComponent<SphereCollider>(), cage, true);
            Go = true;
        }
        if (other.name == "pointF2")
        {
            x = 0;
            y = 0;
            z = 0f;
            Physics.IgnoreCollision(gameObject.GetComponent<SphereCollider>(), cage, false);
            Go = true;
        }
        if (other.name == "point-xL")
        {
            x = -5;
            y = 0;
            z = 0f;
            Go = true;
        }

    }
}
