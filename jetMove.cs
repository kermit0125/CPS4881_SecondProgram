using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jetMove : MonoBehaviour {
	private float speed=1.5f;
	public bool Moveing(){
		Transform player = GameObject.FindGameObjectWithTag ("Player").transform;
		//设置朝向
		Vector2 r = new Vector2 (0, 0);
		if (player.position.x - transform.position.x > 0) {
			//主角在敌人右边
			r.y=180f;
		}
		transform.rotation = Quaternion.Euler (r);
		//条件判断石佛到了角色上方
		if (Mathf.Abs(transform.position.x-player.position.x)<=0.1f)
			return false;
		float x = Mathf.MoveTowards (transform.position.x, player.position.x, Time.deltaTime*speed);
		transform.position = new Vector2 (x, transform.position.y);
		return true;
	}
}
