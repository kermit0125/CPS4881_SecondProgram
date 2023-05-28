using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jet : MonoBehaviour {
	jetMove jetmove;
	private JetHealth jethealth;
	private jetAttack jetattack;
	// Use this for initialization
	void Start () {
		jetmove = GetComponent<jetMove> ();
		jetattack = GetComponent<jetAttack> ();
		jethealth = GetComponent<JetHealth> ();
		jethealth.OnDieHandler += JetHealth_OnDieHandler;
	}

	// Update is called once per frame
	void Update () {
		if (jetmove.Moveing()) {
			//do nothing
		} else {
		//attack
			jetattack.Attack();
		}
	}
	private void JetHealth_OnDieHandler(){
		//播放飞机死的动画
		GetComponent<Animator>().enabled= true;
		GetComponent<Rigidbody2D> ().isKinematic = false;
		//播放音乐
		SoundManager.Instance.PlayAudioByName("jetExplosion");
		//销毁飞机
		Destroy(gameObject,1f);
	}
}
