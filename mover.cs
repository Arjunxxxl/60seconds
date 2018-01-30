using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

	float speed = 30.0f;

	// Use this for initialization
	void Start () {
		Rigidbody rb = transform.GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
