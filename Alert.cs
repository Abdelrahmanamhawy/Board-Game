using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour {
    public bool Range = false;
    
    // Use this for initialization
    void Start () {
        Range = false;
		
	}
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Range = true;
        }

    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Range = false;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
