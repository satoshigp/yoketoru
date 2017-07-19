using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {
	//敵のプレハブ
	public GameObject prefTeki;

	public int TekiCount=4;

	public GameObject prefItem;

	public int ItemCount=10;


	private static string _nextScene="";

	public static string NextScene{
		get{return _nextScene;}
		set{
			if ((NextScene != "clear")||(value=="")) {
				_nextScene = value;
				Time.timeScale = 0;
			}
		}
	}

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		GameParams.SetScore (0);
		_nextScene = "";
		MoveBALL.clearBallCount ();

		/*//アイテム
		for (int s = 0; s < ItemCount; s++) {
			Instantiate (prefItem);
		}

		//敵の出現
		for (int i = 0; i < TekiCount; i++) {
			Instantiate (prefTeki);
		}*/

	}
	
	// Update is called once per frame
	void Update () {

		//GameParams.AddScore (1);

		if (Input.GetKeyDown (KeyCode.O)) {
			NextScene = "gameover";
		} else if (Input.GetKeyDown (KeyCode.C)) {
			NextScene = "clear";
			NextScene="gameover";

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
