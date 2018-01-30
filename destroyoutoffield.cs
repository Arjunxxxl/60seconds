using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyoutoffield : MonoBehaviour {

	void OnTriggerExit(Collider col){
		if (col.gameObject.tag == "shots" || col.gameObject.tag == "ebolt") {
			Destroy (col.gameObject);
			Debug.Log ("efe");

		}
	}
}
