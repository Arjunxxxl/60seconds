using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class amenu : MonoBehaviour {

	public aloadlevel load;

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void quitgame(){
		Application.Quit ();
	}

	public void play(){
		load.LoadLevel ("play");
	}

}
