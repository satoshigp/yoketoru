using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoveBALL : MonoBehaviour {
	public Text  CountText;

	public float vx = -10f;
	public float vy = -10f;
	public Rigidbody rig;
	public float MIN_x = -9f;
	public float MAX_x = 9f;
	public float MIN_y = -4f;
	public float MAX_y = 6f;

	//ボールの個数
	private static int ballCount = 0;

	public static void clearBallCount(){
		ballCount = 0;
	}


	// Use this for initialization
	void Awake () {
		rig = GetComponent<Rigidbody> ();
		rig.velocity = new Vector3 (vx, vy, 0f);

		//自分の座標をランダムで設定
		Vector3 pos = new Vector3 (
			              Random.Range (MIN_x, MAX_x),
			              Random.Range (MIN_y, MAX_y),
			              0f);
		transform.position = pos;
		Debug.Log ("start: "+tag+"/"+transform.position);
		//自分のタグがitemか確認
		//いｆ文で条件式が省略されていた場合
		//条件式のところがtrueかfalseを返すようになっている
		if(CompareTag("itrm")){
		ballCount++;

	//	CountText.text = "" + ballCount;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	 void OnTriggerEnter(Collider col){
		if (col.CompareTag ("Player")) {
			if (CompareTag ("itrm")) {
				GameParams.AddScore (100);
				Destroy (gameObject);
				ballCount--;
				//	CountText.text = "" + ballCount;

				if (ballCount <= 0) {
					gamemanager.NextScene = "clear";
				}
			}

			Destroy (gameObject);
		}
	}
}
