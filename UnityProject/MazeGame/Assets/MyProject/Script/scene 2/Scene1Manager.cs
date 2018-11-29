using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Manager : MonoBehaviour {
    public GameObject cupboard;
    protected static Scene1Manager instance;
    private BlackMask blackMask;
    private BaseSceneTest baseSceneTest;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }
    // Use this for initialization
    void Start () {
      
        blackMask = BlackMask.Instance;
        baseSceneTest = GetComponent<BaseSceneTest>();
    }
    public static Scene1Manager Instance
    {
        get { return instance; }
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenCupBoard()
    {
        blackMask.ChangeScene("OpenCupboardCallBack", gameObject,0.16f);
    }
    public void OpenCupboardCallBack()
    {
        baseSceneTest.baseScene = false;
        cupboard.SetActive(true);
    }

    public void SceneGoBack()
    {
        blackMask.ChangeScene("CloseCupboard", gameObject,0.16f);

    }
    public void CloseCupboard()
    {
        cupboard.SetActive(false);
        baseSceneTest.baseScene = true;

    }
    public void GoBackCallBack()
    {
        
    }
}
