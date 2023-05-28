using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
		//游戏胜利
			GameObject.Find("Canvas").GetComponent<GameUI>().GoToEnd();
		}
	}
}
