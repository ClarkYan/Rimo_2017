using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour {
	//public GameObject text1;
	private int timer = 600;

	Text text1;

	// Use this for initialization
	void Start () {
		text1 = GetComponent <Text> ();
		StartCoroutine ("UpdateTimer");
	}
	
	// Update is called once per frame
	void Update () {
		//UpdateTimer ();
	}

	IEnumerator UpdateTimer(){
		while (timer > 0) {
			timer--;
			yield return new WaitForSeconds (1f);
			text1.text = "Timer:" + timer;
		}
		if (timer == 0) {
			text1.text = "GAME OVER!!";
			//yield return new WaitForSeconds (2f);
			//Application.Quit ();
			SceneManager.LoadScene ("Testing");
			//ButtonController bc = new ButtonController ();
			//TimerController tc = new TimerController();
			//bc.St

		}
	}
}
