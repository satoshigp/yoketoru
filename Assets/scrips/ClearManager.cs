using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClearManager : MonoBehaviour {
	/*public float vx = 10f;
	public float vy = 10f;
	public*/
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1")){
			SceneManager.LoadSceneAsync ("title");
		}

		if (Input.GetKeyDown (KeyCode.R)) {
		
		}
	}
}
