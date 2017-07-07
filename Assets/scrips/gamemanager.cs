using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {
	public static string NextScene="";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)){
			NextScene = "gameover";
	}
		else if(Input.GetKeyDown(KeyCode.C)){
			NextScene = "clear";

		}
		if(NextScene.Length>0){
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
	}
}
