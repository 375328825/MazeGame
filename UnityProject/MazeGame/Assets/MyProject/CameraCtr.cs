using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtr : MonoBehaviour {
    void Awake()
    {
      //  Screen.SetResolution(1920, 1080, false);
    }
  //  public Camera mainCamera;
    // Use this for initialization
    void Start () {
        //Screen.SetResolution(1280, 800, true, 60);
       //  mainCamera = Camera.main;
             //  float screenAspect = 1280 / 720;  现在android手机的主流分辨。
        //  mainCamera.aspect --->  摄像机的长宽比（宽度除以高度）
      //  mainCamera.aspect = 1920f/1080f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
