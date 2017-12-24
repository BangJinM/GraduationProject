using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrance : MonoBehaviour {
    UIControllerBase uIControllerBase;
    CameraController cameraController;
    // Use this for initialization
    void Start () {
        //界面--状态机
        uIControllerBase = new UIControllerBase();

        //摄像机的控制
        //cameraController = new CameraController();
        //cameraController.GameStart();
        //主角
	}
	
	// Update is called once per frame
	void Update () {
        //uIControllerBase.GPUpdate();

        //cameraController.GPUpdate();
	}
}
