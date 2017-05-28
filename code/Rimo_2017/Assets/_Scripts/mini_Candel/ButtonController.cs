using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ButtonOneClicked() {
        button1.GetComponent<CandleController>().SetCandleFireTrue();
		button2.GetComponent<CandleController>().SetCandleFireTrue();
		button5.GetComponent<CandleController>().SetCandleFireTrue();
    }
    public void ButtonTwoClicked() {
        button1.GetComponent<CandleController>().SetCandleFireTrue();
        button2.GetComponent<CandleController>().SetCandleFireTrue();
        button3.GetComponent<CandleController>().SetCandleFireTrue();
    }
    public void ButtonThreeClicked() {
        button2.GetComponent<CandleController>().SetCandleFireTrue();
        button3.GetComponent<CandleController>().SetCandleFireTrue();
		button6.GetComponent<CandleController>().SetCandleFireTrue();
    }
    public void ButtonFourClicked() {
        button4.GetComponent<CandleController>().SetCandleFireTrue();
        button7.GetComponent<CandleController>().SetCandleFireTrue();
    }
    public void ButtonFiveClicked() {
        button1.GetComponent<CandleController>().SetCandleFireTrue();
		button5.GetComponent<CandleController>().SetCandleFireTrue();
		button6.GetComponent<CandleController>().SetCandleFireTrue();
    }
    public void ButtonSixClicked() {
        button3.GetComponent<CandleController>().SetCandleFireTrue();
        button5.GetComponent<CandleController>().SetCandleFireTrue();
		button6.GetComponent<CandleController>().SetCandleFireTrue();
		button7.GetComponent<CandleController>().SetCandleFireTrue();
    }
    public void ButtonSevenClicked() {
        button4.GetComponent<CandleController>().SetCandleFireTrue();
        button6.GetComponent<CandleController>().SetCandleFireTrue();
		button7.GetComponent<CandleController>().SetCandleFireTrue();
    }
}
