using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {
	public static string NextScene="";

	// Use this for initialization
	void Start () {
		GameParams.SetScore (0);

	}
	
	// Update is called once per frame
	void Update () {

		GameParams.AddScore (1);

		if (Input.GetKeyDown (KeyCode.O)) {
			NextScene = "gameover";
		} else if (Input.GetKeyDown (KeyCode.C)) {
			NextScene = "clear";

		}
		//Aキー
		else if (Input.GetKey (KeyCode.A)) {
			GameParams.AddScore (10000);
		} else if (Input.GetMouseButtonDown(1)) {
			GameParams.AddScore (10000);
		
		}
		if(NextScene.Length>0){
			SceneManager.LoadSceneAsync (NextScene,LoadSceneMode.Additive);
			NextScene = "";
			enabled = false;
		}
	}
}
