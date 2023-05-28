using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetAttack : MonoBehaviour {
	public GameObject Boom;
	public Transform firePoint;
	private float speed = 2f;
	private float Timer = 2f;
	public void Attack(){
		Timer += Time.deltaTime;
		if (Timer > speed) {
			GameObject.Instantiate (Boom, firePoint.transform.position, new Quaternion ());
			Timer = 0;
		}
	}

}
