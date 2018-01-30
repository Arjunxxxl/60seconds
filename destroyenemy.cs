using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyenemy : MonoBehaviour {

	float health = 5.0f;
	public GameObject exp;
	public bool dis;
	public AudioSource a;

	// Use this for initialization
	void Start () {
		dis = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "shots") {
			Destroy (col.gameObject);
			health -= 1.0f;
			Debug.Log (health);
			if (health == 0) {
				dis = true;
				a.Play ();
				StartCoroutine (onesec (col));
			} 
		}
	}
	IEnumerator onesec(Collider col){
		yield return new WaitForSeconds (0.1f);
		Destroy (exp);
	}

}
