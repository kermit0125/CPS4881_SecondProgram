using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hostage : MonoBehaviour {
	public GameObject gift;
	private Animator animator;
	private Rigidbody2D rigidbody2D;
	void Start(){
		animator = GetComponent<Animator> ();
		rigidbody2D = GetComponent<Rigidbody2D> ();
	}	
	public void OnTriggerEnter2D(Collider2D collision){
		if (collision.tag == "Player") {
			animator.SetInteger ("releasted", 1);
		}
	}
	public void GiveGift(){
		GameObject.Instantiate (gift);
	}
	public void RunAway(){
		rigidbody2D.velocity = new Vector2 (-2, 0);
	}
	public void Destory(){
		rigidbody2D.velocity = Vector2.zero;
		GameObject.Destroy(gameObject,5f);
		SoundManager.Instance.PlayAudioByName ("pang");
	}

}