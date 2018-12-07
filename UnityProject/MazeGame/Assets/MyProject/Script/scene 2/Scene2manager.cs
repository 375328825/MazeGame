using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene2manager : MonoBehaviour
{
    public GameObject cameraView;
    public GameObject food;
    public GameObject shit;
    public GameObject shitButton;
    private BlackMask blackMask;
    private MainManager mainManager;
    // Use this for initialization
    void Start()
    {
        blackMask = BlackMask.Instance;
        mainManager = MainManager.Instance;

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OpenCamera()
    {
        if (mainManager.HotItem == null)
            return;
        if (mainManager.HotItem.name == "camera")
        {
            blackMask.ChangeScene("OpenCameraCallBack", gameObject, 0.16f);


        }
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
    public void AddFood()
    {
        if (mainManager.HotItem == null)
        {
            return;
        }
        if (mainManager.HotItem.name == "food")
        {
            food.SetActive(true);
        }
    }
    public GameObject birdButton;
    public void EatFood()
    {
        if (food.activeSelf == true)
        {
            shit.SetActive(true);
            birdButton.SetActive(false);
        }
    }

    public void OpenShitButton()
    {
        shitButton.SetActive(true);
    }
    public void GetShit()
    {

        shit.SetActive(false);
        mainManager.zhongzi.SetActive(true);
    }
}
