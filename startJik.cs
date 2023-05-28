using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startJik : MonoBehaviour {
	public GameObject jet;
	public void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			jet.SetActive (true);
		}
	}
	void Start(){
		jet.GetComponent<JetHealth> ().OnDieHandler+=ShowJet_OnDieHeandler;
	}
	private void ShowJet_OnDieHeandler(){
		gameObject.SetActive (false);
	}

}
