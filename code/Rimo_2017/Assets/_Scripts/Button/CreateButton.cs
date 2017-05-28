using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateButton : MonoBehaviour {

	public Texture img;//公有变量图片/
	private Texture img0;
	private string info;//显示的信息/
	private int frameTime;//记录按下的时间/

	void Start()
	{
		// Use this for initialization
		info = "请您点击按钮";
		frameTime = 0;
	}

	void OnGUI()
	{
		//标签/
		GUI.Label(new Rect(50,10,200,20),info);		
		//普通按钮，点击后显示Hello World
		if(GUI.Button(new Rect(50,250,200,20),"Hello World"))
		{
			info = "Hello World";
		}
		//标签/
		GUI.Label(new Rect(280,10,200,200),img0);
		//图片按钮,点击后显示图片/
		if(GUI.Button(new Rect(280,250,200,200),img))
		{
			img0 = img;
			info = "您点击了图片按钮";
		}
		//标签/
		GUI.Label(new Rect(500,10,200,20),"持续按下的时间：" + frameTime);
		//连续按钮，点击后显示按下的时间/
		if(GUI.RepeatButton(new Rect(500,250,200,20),"持续按下"))
		{
			frameTime ++ ;
			info = "您按下了连续按钮";
		}		
		//每当鼠标按下时将frameTime重置，一遍进行下次记录/
		if(Input.GetMouseButtonDown(0))
		{
			frameTime = 0;
		}
	}

	// Update is called once per frame
	void Update () {

	}
}

