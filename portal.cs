using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {

	public GameObject finalpos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			Debug.Log ("enter");
			col.gameObject.transform.position = finalpos.transform.position;
		}
	}
}
