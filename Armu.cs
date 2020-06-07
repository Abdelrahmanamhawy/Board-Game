using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Armu : MonoBehaviour {
	Vector3 movement;
	public Rigidbody playerRigidBody;
	public int i;
	public float xMin,xMax,zMin,zMax,yMin,yMax;
	public int speed;


	// Use this for initialization
	void Start () {
		i = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
	
		//transform.Translate(movement * speed* Time.deltaTime, Space.Self);
		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, xMin, xMax),
			Mathf.Clamp(transform.position.y, yMin, yMax),
			Mathf.Clamp(transform.position.z, zMin, zMax));

	


	}
}
