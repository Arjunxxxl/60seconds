using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public TMP_Text t;
	public GameObject gameover;
	public GameObject pause;
	float time = 60.0f;
	public static bool res = false;
	public bool gpause = false;
	string current;
	public GameObject loadingscreen;
	public Slider slider;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1f;
		Scene s = SceneManager.GetActiveScene ();
		current = s.name;
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;

		t.text = (int)time +"";

		if ( time < 0 )
		{
			gameover.SetActive (true);
			Time.timeScale = 0f;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (res) {
				Resume();
			} else {
				pause0 ();
			}
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			Time.timeScale = 1f;
			SceneManager.LoadSceneAsync (current);
		}
	}

	public void Resume(){
		pause.SetActive (false);
		Time.timeScale = 1.0f;
		res = false;
		gpause = false;
	}
	public void pause0(){
		pause.SetActive (true);
		Time.timeScale = 0f;
		res = true;
		gpause = true;
	}

	/*public void restart(){
		if (Input.GetButtonDown (KeyCode.R)) {
			SceneManager.LoadSceneAsync ("dastv0.1");
		}
	}*/

	public void selectlevel(){
		StartCoroutine (level ("play"));
	}

	public void tomenu(){
		StartCoroutine (level ("mainmenu"));
	}

	IEnumerator level(string name){
		AsyncOperation op = SceneManager.LoadSceneAsync (name);
		loadingscreen.SetActive (true);
		while(!op.isDone)
		{
			float progress = Mathf.Clamp01 (op.progress / 0.9f);
			slider.value = progress;
			yield return null;
		}
	}

}
