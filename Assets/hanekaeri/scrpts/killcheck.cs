using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killcheck : MonoBehaviour {

	//ぶつかったときの処理
	void OnTriggerEnter(Collider col){
		Destroy(gameObject);
			}
	void OnMouseEnter(){
		//ぶつかったら消す

		//Destroy (gameObject);

		//setActive()はVC#でのEnabledとVisivleをあわせたようなもの
		//falseにすると画面から消える

		//gameObject.SetActive (false);
		//Time.timeScale=0f;
	}
}
