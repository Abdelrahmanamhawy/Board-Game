using UnityEngine;
using System.Collections;

public class HoldItems : MonoBehaviour
{

    
    public Transform player;
    public float throwForce = 10;
    bool hasPlayer = false;
    public bool beingCarried = false;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            hasPlayer = true;
            Debug.Log("True");
        }
    
    }

    void OnTriggerExit(Collider other)
    {
        hasPlayer = false;
    }

    void FixedUpdate()
    {
        //if (beingCarried)
        //{
            if (Input.GetKey(KeyCode.Space))
            {
                rb.isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                rb.AddForce(player.forward * throwForce);
                
            }
        //}
        else
        {
            if (Input.GetMouseButtonDown(0) && hasPlayer)
            {
                rb.isKinematic = true;
                transform.parent = player;
                rb.AddForce(player.forward * throwForce);
                beingCarried = true;
                


            }
        }
    }
}//class

