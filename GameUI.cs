using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameUI : MonoBehaviour {
	public Text txt_HP;
	public Image img_End;
	public void UpdateHP(int hp){
		txt_HP.text = hp.ToString ();
	}
	public void GoToEnd(){
		img_End.gameObject.SetActive (true);
	}
	public void OnResetClick(){
		SceneManager.LoadScene (1);
	}
}
