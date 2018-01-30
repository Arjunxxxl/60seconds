using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy1 : MonoBehaviour {

	public Transform player;
	float safedis = 30.0f;
	float currentdis;
	bool shooting = false;
	public GameObject bolt;
	public Transform guntip;
	float power = 1000.0f;
	float shotdelay = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentdis = Vector3.Distance(transform.position, player.position);

		if(currentdis < safedis){
			transform.LookAt(player);
			if (/*!shooting && */Time.time > shotdelay) {
				shotdelay = Time.time + shotdelay;
				//shooting = true;
				GameObject ebolt = Instantiate (bolt, guntip.position, guntip.rotation);
				//yield return WaitForSeconds (shotdelay);
				//shooting = false;
			}
		}
	}
		
}
