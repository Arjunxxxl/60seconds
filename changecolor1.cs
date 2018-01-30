using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changecolor1 : MonoBehaviour {

	public TMP_Text text;
	Color ye;
	Color or;

	// Use this for initialization
	void Start () {
		text.color = Color.white;
		ye = new Color (255f,248f,0f,255f);
		or = new Color (255f,80f,0f,255f);
		StartCoroutine (waitplz ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//19 10 9
	IEnumerator waitplz(){
		yield return new WaitForSeconds (29.0f);
		text.color = Color.Lerp(Color.white,ye,1f);
		Debug.Log ("1");
		yield return new WaitForSeconds (7.0f);
		text.color = Color.Lerp(Color.white,Color.red,1f);
		Debug.Log ("2");

	}




}
