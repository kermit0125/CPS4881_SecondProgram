using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gift : MonoBehaviour {
	public void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag == "Player") {
			GameObject player = collision.gameObject;
			player.BroadcastMessage ("Stengthen", SendMessageOptions.DontRequireReceiver);
			SoundManager.Instance.PlayAudioByName ("MetronomeBeep");
			Destroy (gameObject);
		}
	}
}
