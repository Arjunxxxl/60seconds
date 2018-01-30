using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybolt : MonoBehaviour {
	float speed = 10.0f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = transform.GetComponent<Rigidbody> ();
		rb.velocity = transform.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			Rigidbody player = col.GetComponent<Rigidbody> ();
			player.transform.Translate(-player.transform.forward*4.0f,Space.World);
			Debug.Log ("afgshf");
			Destroy (gameObject);
		}
	}

}
