using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updownslow : MonoBehaviour {
	Vector3 startPosition;
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(startPosition.x, startPosition.y + Mathf.Sin(Time.time * 2), startPosition.z);
	}
}
