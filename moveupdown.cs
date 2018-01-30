using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveupdown : MonoBehaviour {
	Vector3 startPosition;
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(startPosition.x, startPosition.y + Mathf.Sin(Time.time * 5), startPosition.z);
	}
}
