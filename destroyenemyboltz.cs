using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyenemyboltz : MonoBehaviour {

	public GameObject exp;
	public AudioSource a;

	void Start(){
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "ebolt") {
			Destroy (col.gameObject);
			Debug.Log ("ebolt");
			a.Play ();
			StartCoroutine (onesec(col));
		}
	}
	IEnumerator onesec(Collider col){
		GameObject go = Instantiate(exp, col.gameObject.transform.position, col.gameObject.transform.rotation) as GameObject;
		yield return new WaitForSeconds (1.9f);
		Destroy (go);
	}

}
