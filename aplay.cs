using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class aplay : MonoBehaviour {

	public aloadlevel level;

	void Start(){
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
	}

	public void menu1(){
		level.LoadLevel("mainmenu");
	}

	public void l1(){
		level.LoadLevel("dastv0.1");
	}

	public void l2(){
		level.LoadLevel("level2");
	}

	public void l3(){
		level.LoadLevel("level3");
	}

	public void l4(){
		level.LoadLevel("level4");
	}

	public void l5(){
		level.LoadLevel("level5");
	}
}
