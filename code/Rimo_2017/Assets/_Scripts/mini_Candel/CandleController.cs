using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleController : MonoBehaviour {
    public GameObject candleFire;
    public bool isCandleFired;
    private int count = 1;
    // Use this for initialization
    void Start() {
        candleFire.SetActive(isCandleFired);
    }

    // Update is called once per frame
    void Update() {

    }
    public void SetCandleFireTrue() {
        if (isCandleFired)
            isCandleFired = false;
        else
            isCandleFired = true;
        candleFire.SetActive(isCandleFired);
    }

}
