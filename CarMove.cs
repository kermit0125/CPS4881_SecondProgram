using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class CarMove : MonoBehaviour {
	public GameObject player;
	public Transform point;
	void Start(){
		SoundManager.Instance.PlayAudioByName ("car");
		transform.DOLocalMoveX (-1f, 2).OnComplete (() => {
			GameObject.Instantiate(player,point.position,Quaternion.identity);
			Camera.main.GetComponent<FlootPlay>().enabled = true;
			Destroy(gameObject,0.5f);
		});

	}


}
