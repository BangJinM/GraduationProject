using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour {
    UIControllerBase uIControllerBase;
    // Use this for initialization
    void Start () {
        //界面--状态机
        uIControllerBase = new UIControllerBase();

        //主角
	}
	
	// Update is called once per frame
	void Update () {
        uIControllerBase.UIUpdate();
	}
}
