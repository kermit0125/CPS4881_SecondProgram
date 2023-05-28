using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {
	private Animator animator;
	private Rigidbody2D _rigidbody;
	void Start(){
		SoundManager.Instance.PlayAudioByName ("bombFall");
		animator = GetComponent<Animator> ();
		_rigidbody = GetComponent<Rigidbody2D> ();

	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			GameObject player = other.gameObject;
			player.SendMessage ("TakeDamage", SendMessageOptions.DontRequireReceiver);
			_rigidbody.isKinematic = true;
			animator.SetTrigger ("Boom");
			SoundManager.Instance.PlayAudioByName ("bombExplosion");
			Destroy (gameObject,1f);
		}
	}
}
