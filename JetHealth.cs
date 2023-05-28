using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class JetHealth : MonoBehaviour {
	public event Action OnDieHandler;
	private int beAttackedTimes = 20;
	public void TakeDamage(){
		beAttackedTimes -= 1;
		if (beAttackedTimes <= 0)
			OnDieHandler();
	}
}
