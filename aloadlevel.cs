using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class aloadlevel : MonoBehaviour {

	public GameObject loadingscreen;
	public Slider slider;

	public void LoadLevel(string name){
		StartCoroutine (level (name));
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
