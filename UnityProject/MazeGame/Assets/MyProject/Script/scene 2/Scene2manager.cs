using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2manager : MonoBehaviour {
    public GameObject cameraView;

    private BlackMask blackMask;
    private MainManager mainManager;
	// Use this for initialization
	void Start () {
        blackMask = BlackMask.Instance;
        mainManager = MainManager.Instance;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OpenCamera()
    {
        // if (mainManager.HotItem.name == "Camera")
        // {
        blackMask.ChangeScene("OpenCameraCallBack", gameObject, 0.16f);
        

        //}
    }
    public void OpenCameraCallBack()
    {
        cameraView.SetActive(true);
        GetComponent<BaseSceneTest>().baseScene = false;

    }

    public void SceneGoBack()
    {
        blackMask.ChangeScene("CloseCameraCallBack", gameObject, 0.16f);

    }
    public void CloseCameraCallBack()
    {
        cameraView.SetActive(false);
        GetComponent<BaseSceneTest>().baseScene = true;


    }
}
