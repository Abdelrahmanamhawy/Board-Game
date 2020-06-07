using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TurnTheLights : MonoBehaviour {

    //public GameObject lightGameObject;

    // Use this for initializat
    public GameObject Evidence;
    public Light lightComp;
     public targetmove touch;
    void Start () {
        //GameObject lightGameObject = new GameObject("The Light");
        //lightComp = GetComponent<Light>();

    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player"  && touch.Touching==true )
        {
            lightComp.enabled = true;
            Evidence.SetActive(true);
            Debug.Log("Touched");
        }

    }
    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player" && touch.Touching == true)
        {
            lightComp.enabled = true;
            Evidence.SetActive(true);
            Debug.Log("Touched");
        }
    }
        // Update is called once per frame
        void Update () {
		
	}
}
