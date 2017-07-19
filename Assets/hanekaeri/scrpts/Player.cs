using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float MAX_SPEED = 6f;
	public Bounds MoveBounds;

	void OnDrawGizmos(){
		Gizmos.DrawWireCube (MoveBounds.center, MoveBounds.size);
	
	
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log (Input.mousePosition);

		Vector3 mpos = Input.mousePosition;
		mpos.z = transform.position.z - Camera.main.transform.position.z;
		Vector3 target = Camera.main.ScreenToWorldPoint (mpos);

		//自分からマウスのベクトル（一発で目的地に到達する）
		//Vector3 dir = target - transform.position;
		//dirの長さが最大速度より長かったら長さを最大速度にする


		//unityには
		Vector3 newpos=Vector3.MoveTowards(
			transform.position,
		target,
			MAX_SPEED*Time.deltaTime);//Time.deltaTimeで一回分の経過時間

		transform.position = newpos;

		//newpos画外に出ないように調整
		newpos.x=Mathf.Clamp(newpos.x,MoveBounds.min.x,MoveBounds.max.x);
		newpos.y=Mathf.Clamp(newpos.y,MoveBounds.min.y,MoveBounds.max.y);
			
	}

	void OnTriggerEnter(Collider col){
		if(col.CompareTag("teki")){
			Destroy (gameObject);
			gamemanager.NextScene = "gameover";
		}
	}

}
